using System.Linq;
using CQRS.Stas.Queries;
using Entities;
using NHibernate;
using NHibernate.Linq;

namespace CQRS.Stas.QueryHandlers
{
    public class ManagerWithSecretaryByIdQueryHandler : IQueryHandler<ManagerWithSecretaryByIdQuery, Manager>
    {
        private readonly ISession _session;

        public ManagerWithSecretaryByIdQueryHandler(ISession session)
        {
            _session = session;
        }

        public Manager Handle(ManagerWithSecretaryByIdQuery query)
        {
            return _session.Query<Manager>().Fetch(x => x.Secretary).SingleOrDefault(x => x.Id == query.Id);
        }
    }
}
