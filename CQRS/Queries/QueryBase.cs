using System.Linq;
using NHibernate;
using NHibernate.Linq;
using ICriteria = CQRS.IRR.Criterias.ICriteria;

namespace CQRS.IRR.Queries
{
    public abstract class QueryBase<TCriteria, TResult> : IQuery<TCriteria, TResult>
        where TCriteria : ICriteria
    {
        private readonly ISession _session;

        protected QueryBase(ISession session)
        {
            _session = session;
        }

        public abstract TResult Ask(TCriteria criteria);

        protected TEntity Get<TEntity>(object id)
        {
            return _session.Get<TEntity>(id);
        }

        protected IQueryable<TEntity> Query<TEntity>()
            where TEntity : class
        {
            return _session.Query<TEntity>();
        }

        protected IQueryOver<TEntity> QueryOver<TEntity>()
            where TEntity : class
        {
            return _session.QueryOver<TEntity>();
        }
    }
}
