using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities;

namespace Repository.Repositories
{
    public interface IManagerRepository
    {
        Manager Get(int id);
        Manager GetWithSecretary(int id);
        IEnumerable<Manager> GetManagers(Expression<Func<Manager, bool>> filter);
        IEnumerable<Manager> GetManagersWithDeputies(Expression<Func<Manager, bool>> filter);
        void Update(Manager manager);
    }
}