using Hangfire;
using System;
using Hangfire.Common;
using Hangfire.States;
using Hangfire.Storage;

namespace BackOfficeService.Utilities.HangFireFilters
{
    public class ProlongExpirationTimeAttribute : JobFilterAttribute, IApplyStateFilter
    {
        private readonly int _retentionDays;

        public ProlongExpirationTimeAttribute()
        {
            Order = 1;
        }

        public ProlongExpirationTimeAttribute(int retentionDays)
        {
            _retentionDays = retentionDays;
        }

        public void OnStateApplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
            context.JobExpirationTimeout = TimeSpan.FromDays(_retentionDays);

        }

        public void OnStateUnapplied(ApplyStateContext context, IWriteOnlyTransaction transaction)
        {
        }
    }

}
