using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using CQRS.IRR.Criterias;
using CQRS.IRR.Queries;

namespace CQRS.IRR.Extensions
{
    public static class QueryForExtensions
    {
        public static TResult ById<TResult, TId>(this QueryFor<TResult> get, TId id)
        {
            return get.By(new ByIdCriteria<TId>(id));
        }

        public static IEnumerable<TResult> All<TResult>(this QueryFor<IEnumerable<TResult>> list)
        {
            return list.By(new ListCriteria());
        }

        public static IEnumerable<TResult> All<TResult>(this QueryFor<IEnumerable<TResult>> list, int skip, int take)
        {
            return list.By(new ListCriteria { Skip = skip, Take = take });
        }

        public static int Count<TEntity>(this QueryFor<int> queryFor, Expression<Func<TEntity, bool>> filter = null)
        {
            return queryFor.By(new CountCriteria<TEntity> { Filter = filter });
        }

        public static TResult ByFilter<TResult>(this QueryFor<TResult> get, Expression<Func<TResult, bool>> filter)
        {
            return get.By(new GenericSingleResultCriteria<TResult>(filter));
        }

        public static IEnumerable<TResult> ByFilter<TResult>(this QueryFor<IEnumerable<TResult>> get, Expression<Func<TResult, bool>> filter, int skip = 0, int take = 0)
        {
            return get.By(new GenericListResultCriteria<TResult>(filter) { Skip = skip, Take = take });
        }
    }
}
