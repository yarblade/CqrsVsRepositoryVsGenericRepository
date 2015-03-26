using CQRS.Stas.Queries;
using Entities;
using NHibernate;

namespace CQRS.Stas.QueryHandlers
{
    public class ManagerByIdQueryHandler : IQueryHandler<ManagerByIdQuery, Manager>
    {
        private readonly ISession _session;

        public ManagerByIdQueryHandler(ISession session)
        {
            _session = session;
        }

        public Manager Handle(ManagerByIdQuery query)
        {
            return _session.Get<Manager>(query.Id);
        }
    }
}