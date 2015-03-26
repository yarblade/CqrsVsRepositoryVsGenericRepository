using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CQRS.IRR.Queries;

namespace CQRS.IRR.Extensions
{
    public static class QueryDispatcherExtensions
    {
        public static QueryFor<TResult> Get<TResult>(this IQueryDispatcher dispatcher)
        {
            return new QueryFor<TResult>(dispatcher);
        }

        public static QueryFor<IEnumerable<TResult>> List<TResult>(this IQueryDispatcher dispatcher)
        {
            return new QueryFor<IEnumerable<TResult>>(dispatcher);
        }

        public static int GetCount<TEntity>(this IQueryDispatcher dispatcher, Expression<Func<TEntity, bool>> filter = null)
        {
            return new QueryFor<int>(dispatcher).Count(filter);
        }
    }
}
