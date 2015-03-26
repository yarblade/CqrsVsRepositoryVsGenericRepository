using System.Collections.Generic;
using System.Linq;
using CQRS.IRR.Criterias;
using CQRS.IRR.Extensions;
using Entities;
using NHibernate;
using NHibernate.Linq;

namespace CQRS.IRR.Queries
{
    public class GetManagersWithDeputiesQuery : ListQuery<ManagerWithDeputiesCriteria, Manager>
    {
        public GetManagersWithDeputiesQuery(ISession session) : base(session)
        {
        }

        public override IEnumerable<Manager> Ask(ManagerWithDeputiesCriteria criteria)
        {
            return Query<Manager>().Fetch(x => x.Deputy).Where(criteria.Expression).Apply(criteria);
        }
    }
}
