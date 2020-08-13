using Hangfire;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using BackOfficeFramework;

namespace BackOfficeWorkers
{
    public class SearchProfileByDocnumberWorker : BaseWorker
    {
        public SearchProfileByDocnumberWorker(IElasticClient elasticClient, IArxivarService arxivarService) : base(elasticClient, arxivarService)
        {
        }

        [Queue("search")]
        public void Work(Hangfire.Server.PerformContext performContext, IJobCancellationToken jobCancellationToken, int docnumber)
        {
            //Hangfire.BackgroundJobClient backgroundJobClient = new BackgroundJobClient(performContext.Storage);
            WriteStartChrono(performContext.BackgroundJob.CreatedAt, docnumber.ToString());
            AddStartDetailChrono("start");
            var id = AddStartDetailChrono("login action");
            ArxivarService.Login();
            AddEndDetailChrono(id);

            IO.Swagger.Api.UsersApi usersApi = new IO.Swagger.Api.UsersApi(ArxivarService.Configuration);
            usersApi.UsersGet(2);
            AddDetailChrono("after get users");
            AddDetailChrono("End");
            WriteEndChrono();
        }

    }
}
