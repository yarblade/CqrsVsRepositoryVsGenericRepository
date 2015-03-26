using System.Linq;
using CQRS.IRR.Criterias;
using NHibernate;

namespace CQRS.IRR.Queries
{
    public class CountQuery<TEntity> : QueryBase<CountCriteria<TEntity>, int>
        where TEntity : class
    {
        public CountQuery(ISession session)
            : base(session)
        {
        }

        public override int Ask(CountCriteria<TEntity> criteria)
        {
            var query = Query<TEntity>();

            if (criteria.Filter != null)
            {
                return query.Count(criteria.Filter);
            }

            return query.Count();
        }
    }
}