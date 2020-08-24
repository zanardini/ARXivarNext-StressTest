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
            
            
            //Avvio il cronometro
            ChronoStart(performContext.BackgroundJob.CreatedAt, docnumber.ToString());
            
            //Aggiungo un dettaglio al cronometro
            ChronoDetailAdd("start");

            //Aggiungo un dettaglio al cronometro prendendomi l'ID del dettaglio
            var id = ChronoDetailAddStart("login action");

            //Eseguo la call di login
            ArxivarService.Login();
            
            //Aggiungo l'End al dettaglio del cronometro dato l'ID 
            ChronoDetailAddEnd(id);

            //Eseguo la call di get user
            IO.Swagger.Api.UsersApi usersApi = new IO.Swagger.Api.UsersApi(ArxivarService.Configuration);
            usersApi.UsersGet(2);

            //Aggiungo un dettaglio al cronometro
            ChronoDetailAdd("after get users");
            
            //Aggiungo un dettaglio al cronometro
            ChronoDetailAdd("End");

            //Aggiungo l'End al cronometro iniziale
            ChronoEnd();
        }
    }
}