using System.Collections.Generic;
using Entities;

namespace Common.Interfaces
{
    public interface IManagerService
    {
        Manager GetManager(int id);
        Manager GetManagerWithSecretary(int id);
        IEnumerable<Manager> GetActiveManagers();
        IEnumerable<Manager> GetInactiveManagersWithDeputies();
        void SetManagerInactive(Manager manager);
    }
}