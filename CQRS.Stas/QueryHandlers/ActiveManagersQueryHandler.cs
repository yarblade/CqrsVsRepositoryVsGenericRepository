using System.Collections.Generic;
using System.Linq;
using CQRS.Stas.Queries;
using Entities;
using NHibernate;
using NHibernate.Linq;

namespace CQRS.Stas.QueryHandlers
{
    public class ActiveManagersQueryHandler : IQueryHandler<ActiveManagersQuery, IEnumerable<Manager>>
    {
        private readonly ISession _session;

        public ActiveManagersQueryHandler(ISession session)
        {
            _session = session;
        }

        public IEnumerable<Manager> Handle(ActiveManagersQuery query)
        {
            return _session.Query<Manager>().Where(x => x.OutOfOffice == !query.IsActive);
        }
    }
}