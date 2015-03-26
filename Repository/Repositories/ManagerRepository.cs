using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Entities;
using NHibernate;
using NHibernate.Linq;

namespace Repository.Repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly ISession _session;

        public ManagerRepository(ISession session)
        {
            _session = session;
        }

        public Manager Get(int id)
        {
            return _session.Get<Manager>(id);
        }

        public Manager GetWithSecretary(int id)
        {
            return _session.Query<Manager>().Fetch(x => x.Secretary).SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Manager> GetManagers(Expression<Func<Manager, bool>> filter)
        {
            return _session.Query<Manager>().Where(filter);
        }

        public IEnumerable<Manager> GetManagersWithDeputies(Expression<Func<Manager, bool>> filter)
        {
            return _session.Query<Manager>().Fetch(x => x.Deputy).Where(filter);
        }

        public void Update(Manager manager)
        {
            _session.Update(manager);
        }
    }
}
