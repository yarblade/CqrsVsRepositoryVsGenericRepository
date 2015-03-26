using System.Linq;
using CQRS.IRR.Criterias;
using Entities;
using NHibernate;
using NHibernate.Linq;

namespace CQRS.IRR.Queries
{
    public class GetManagerWithSecretaryQuery : QueryBase<ManagerWithSecretaryByIdCriteria, Manager>
    {
        public GetManagerWithSecretaryQuery(ISession session) : base(session)
        {
        }

        public override Manager Ask(ManagerWithSecretaryByIdCriteria criteria)
        {
            return Query<Manager>().Fetch(x => x.Secretary).FirstOrDefault(x => x.Id == criteria.Id);
        }
    }
}