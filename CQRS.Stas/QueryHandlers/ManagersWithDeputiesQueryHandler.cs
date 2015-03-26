using System.Collections.Generic;
using System.Linq;
using CQRS.Stas.Queries;
using Entities;
using NHibernate;
using NHibernate.Linq;

namespace CQRS.Stas.QueryHandlers
{
    public class ManagersWithDeputiesQueryHandler : IQueryHandler<ManagersWithDeputiesQuery, IEnumerable<Manager>>
    {
        private readonly ISession _session;

        public ManagersWithDeputiesQueryHandler(ISession session)
        {
            _session = session;
        }

        public IEnumerable<Manager> Handle(ManagersWithDeputiesQuery query)
        {
            return _session.Query<Manager>().Fetch(x => x.Deputy).Where(x => x.OutOfOffice == !query.IsActive);
        }
    }
}