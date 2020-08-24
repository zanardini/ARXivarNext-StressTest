using Nest;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackOfficeFramework
{
    public abstract class BaseWorker
    {
        private const string IndexName = "BackOfficeService";

        private readonly IElasticClient _elasticClient;
        private readonly IArxivarService _arxivarService;

        protected IArxivarService ArxivarService
        {
            get
            {
                return _arxivarService;
            }
        }


        private ChronoModel _chronoModelMaster = null;
        private List<ChronoModel> _chronoModelDetails = new List<ChronoModel>();
        private DateTime? _lastChronoEnded = null;


        public BaseWorker(IElasticClient elasticClient, IArxivarService arxivarService)
        {
            _elasticClient = elasticClient;
            _arxivarService = arxivarService;
        }

        protected void ChronoStart(DateTime createdAt, string parameters)
        {
            _chronoModelMaster = new ChronoModel()
            {
                Id = Guid.NewGuid(),
                ParentId = Guid.Empty,
                ActionDescription = this.GetType().FullName,
                ScheduledTime = createdAt,
                StartTime = DateTime.Now,
                Parameters = parameters,
            };

            var indexResponse = _elasticClient.Index(_chronoModelMaster, i => i.Index(IndexName));
            if (!indexResponse.IsValid)
                throw new Exception(string.Format("Error during save in Elastic Chrono", indexResponse.OriginalException));
            _chronoModelMaster.StartTime = DateTime.Now; //non mi interessa la latenza della insert
            _lastChronoEnded = _chronoModelMaster.StartTime;
        }

        protected void ChronoEnd()
        {
            _chronoModelMaster.EndTime = DateTime.Now;
            _chronoModelMaster.MSecDuration = (_chronoModelMaster.EndTime - _chronoModelMaster.StartTime).TotalMilliseconds;
            var indexResponse = _elasticClient.Index(_chronoModelMaster, i => i.Index(IndexName));
            if (!indexResponse.IsValid)
                throw new Exception(string.Format("Error during save in Elastic Chrono", indexResponse.ServerError));

            foreach (var chronoModelDetail in _chronoModelDetails)
            {
                chronoModelDetail.ParentId = _chronoModelMaster.Id;
                chronoModelDetail.ScheduledTime = _chronoModelMaster.ScheduledTime;
                var indexResponseDetail = _elasticClient.Index(_chronoModelDetails, i => i.Index(IndexName));
                throw new Exception(string.Format("Error during save detail in Elastic Chrono", indexResponseDetail.ServerError));
            }
        }

        protected Guid ChronoDetailAddStart(string actionDescription)
        {
            ChronoModel detail = new ChronoModel();
            detail.Id = Guid.NewGuid();
            detail.StartTime = _lastChronoEnded == null ? DateTime.Now : _lastChronoEnded.Value;
            detail.EndTime = DateTime.Now;
            detail.MSecDuration = (detail.EndTime - detail.StartTime).TotalMilliseconds;
            detail.ActionDescription = actionDescription;
            detail.Parameters = "";
            _chronoModelDetails.Add(detail);
            _lastChronoEnded = detail.EndTime;
            return detail.Id;
        }

        protected void ChronoDetailAddEnd(Guid detailId)
        {
            var detail = _chronoModelDetails.FirstOrDefault(x => x != null && x.Id == detailId);
            if (detail != null)
                detail.EndTime = DateTime.Now;
            _lastChronoEnded = detail.EndTime;
        }

        protected void ChronoDetailAdd(string actionDescription)
        {
            var id = ChronoDetailAddStart(actionDescription);
            ChronoDetailAddEnd(id);
        }
    }
}