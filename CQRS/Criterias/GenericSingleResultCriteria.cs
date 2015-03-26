using System;
using System.Linq.Expressions;

namespace CQRS.IRR.Criterias
{
    public class GenericSingleResultCriteria<TEntity> : ICriteria
    {
        public GenericSingleResultCriteria(Expression<Func<TEntity, bool>> filter)
        {
            Filter = filter;
        }

        public Expression<Func<TEntity, bool>> Filter { get; private set; }
    }
}
