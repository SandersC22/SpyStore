using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage;

namespace SpyStore.DAL.EF
{
    public class MyConnectionStrategy : ExecutionStrategy
    {
        public MyConnectionStrategy(ExecutionStrategyContext context) :
            base(context, ExecutionStrategy.DefaultMaxRetryCount,
                ExecutionStrategy.DefaultMaxDelay)
        {
        }

        public MyConnectionStrategy(
            ExecutionStrategyContext context,
            int maxRetryCount,
            TimeSpan maxRetryDelay) : base(context, maxRetryCount, maxRetryDelay)
        {
        }

        protected override bool ShouldRetryOn(Exception exception)
        {
            return true;
        }
    }
}