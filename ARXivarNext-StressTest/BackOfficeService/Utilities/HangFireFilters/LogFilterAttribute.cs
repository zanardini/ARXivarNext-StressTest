using Hangfire;
using System;
using Hangfire.Common;
using Hangfire.States;
using Hangfire.Storage;

namespace BackOfficeService.Utilities.HangFireFilters
{
    public class LogFilterAttribute : JobFilterAttribute,
        IApplyStateFilter
    {
        public LogFilterAttribute()
        {
            Order = 28;
        }

        public void OnStateApplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
            try
            {
                if (context.NewState is SucceededState)
                {
                    var succecssState = context.NewState as SucceededState;
                    Serilog.Log.Information(" SucceededAt " + succecssState.SucceededAt);
                    //    LatencyMs = succecssState.Latency, //da quando è messo in cosa a quando è elaborato
                    //    PerformanceDurationMs = succecssState.PerformanceDuration, //tempo di esecuzione
                    //    Result = succecssState.Result
                    //};
                }
                else if (context.NewState is FailedState)
                {
                    var failedState = context.NewState as FailedState;
                    //jobNotifyStateBase = new JobNotifyStateFailed
                    //{
                    //    FailedAt = failedState.FailedAt,
                    //    Exception = failedState.Exception
                    //};
                }
                else if (context.NewState is AwaitingState)
                {
                    var awaitState = context.NewState as AwaitingState;
                    //jobNotifyStateBase = new JobNotifyStateAwaiting();
                }
                else if (context.NewState is ScheduledState)
                {
                    var scheduledState = context.NewState as ScheduledState;
                    //jobNotifyStateBase = new JobNotifyStateScheduled
                    //{
                    //    ScheduledAt = scheduledState.ScheduledAt
                    //};
                }
                else if (context.NewState is DeletedState)
                {
                    var deletedState = context.NewState as DeletedState;
                    //jobNotifyStateBase = new JobNotifyStateDeleted
                    //{
                    //    DeletedAt = deletedState.DeletedAt
                    //};
                }
                else if (context.NewState is ProcessingState)
                {
                    var processingState = context.NewState as ProcessingState;
                    //jobNotifyStateBase = new JobNotifyStateProcessing
                    //{
                    //    StartedAt = processingState.StartedAt,
                    //    ServerId = processingState.ServerId,
                    //    WorkerId = processingState.WorkerId
                    //};
                }
                else if (context.NewState is EnqueuedState)
                {
                    var enqueuedState = context.NewState as EnqueuedState;
                    // jobNotifyStateBase = new JobNotifyStateEnqueued();
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Unknown state: " + context.NewState.Name);
                }

                // Recupero il context corretto in base al tipo di metodo

                // Loggo:
                Serilog.Log.Information(
                    "Job `{0}` state was changed from `{1}` to `{2}`",
                    context.BackgroundJob.Id,
                    context.OldStateName,
                    context.NewState.Name);
            }
            catch (Exception e)

            {
                Serilog.Log.Error("NotifyServiceBus error: {0}", e);
                throw;
            }
        }

        public void OnStateUnapplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
            // Questo metodo non mi interessa
        }
    }
}
