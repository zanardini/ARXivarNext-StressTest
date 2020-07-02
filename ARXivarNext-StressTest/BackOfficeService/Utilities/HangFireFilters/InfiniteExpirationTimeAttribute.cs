using Hangfire;
using System;
using Hangfire.Common;
using Hangfire.States;
using Hangfire.Storage;

namespace BackOfficeService.Utilities.HangFireFilters
{

    public class InfiniteExpirationTimeAttribute : JobFilterAttribute, IApplyStateFilter
    {
        public InfiniteExpirationTimeAttribute()
        {
            Order = 1;
        }

        public void OnStateApplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
            //context.JobExpirationTimeout = TimeSpan.MaxValue;
            context.JobExpirationTimeout = TimeSpan.FromDays(365*40);
        }

        public void OnStateUnapplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
        }
    }
}
