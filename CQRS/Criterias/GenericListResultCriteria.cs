using System;
using System.Linq.Expressions;

namespace CQRS.IRR.Criterias
{
    public class GenericListResultCriteria<TEntity> : ListCriteria
    {
        public GenericListResultCriteria(Expression<Func<TEntity, bool>> filter)
        {
            Filter = filter;
        }

        public Expression<Func<TEntity, bool>> Filter { get; private set; }
    }
}
