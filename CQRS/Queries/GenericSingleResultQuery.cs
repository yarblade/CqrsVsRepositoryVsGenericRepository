using System.Linq;
using CQRS.IRR.Criterias;
using NHibernate;

namespace CQRS.IRR.Queries
{
    public class GenericSingleResultQuery<TCriteria, TEntity> : QueryBase<TCriteria, TEntity>
        where TEntity : class
        where TCriteria : GenericSingleResultCriteria<TEntity>
    {
        public GenericSingleResultQuery(ISession session)
            : base(session)
        {
        }

        public override TEntity Ask(TCriteria criteria)
        {
            return Query<TEntity>().FirstOrDefault(criteria.Filter);
        }
    }
}