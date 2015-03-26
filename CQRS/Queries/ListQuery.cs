using System.Collections.Generic;
using CQRS.IRR.Criterias;
using CQRS.IRR.Extensions;
using NHibernate;

namespace CQRS.IRR.Queries
{
    public class ListQuery<TCriteria, TEntity> : QueryBase<TCriteria, IEnumerable<TEntity>>
        where TCriteria : ListCriteria
        where TEntity : class
    {
        public ListQuery(ISession session)
            : base(session)
        {
        }

        public override IEnumerable<TEntity> Ask(TCriteria criteria)
        {
            return Query<TEntity>().Apply(criteria);
        }
    }
}