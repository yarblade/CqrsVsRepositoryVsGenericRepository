using System.Collections.Generic;
using System.Linq;
using CQRS.IRR.Criterias;
using CQRS.IRR.Extensions;
using NHibernate;

namespace CQRS.IRR.Queries
{
    public class GenericListResultQuery<TCriteria, TEntity> : QueryBase<TCriteria, IEnumerable<TEntity>>
        where TEntity : class
        where TCriteria : GenericListResultCriteria<TEntity>
    {
        public GenericListResultQuery(ISession session)
            : base(session)
        {
        }

        public override IEnumerable<TEntity> Ask(TCriteria criteria)
        {
            return Query<TEntity>().Where(criteria.Filter).Apply(criteria).AsEnumerable();
        }
    }
}