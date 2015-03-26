using CQRS.IRR.Criterias;
using NHibernate;

namespace CQRS.IRR.Queries
{
    public class GetByIdQuery<TId, TEntity> : QueryBase<ByIdCriteria<TId>, TEntity>
        where TEntity : class
    {
        public GetByIdQuery(ISession session)
            : base(session)
        {
        }

        public override TEntity Ask(ByIdCriteria<TId> criteria)
        {
            return Get<TEntity>(criteria.Id);
        }
    }
}