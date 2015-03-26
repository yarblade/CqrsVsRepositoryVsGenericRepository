using System;
using System.Linq.Expressions;

namespace CQRS.IRR.Criterias
{
    public class CountCriteria<TEntity> : ICriteria
    {
        public Expression<Func<TEntity, bool>> Filter { get; set; }
    }
}
