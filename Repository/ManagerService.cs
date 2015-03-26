using System.Collections.Generic;
using Common.Interfaces;
using Entities;
using Repository.Repositories;

namespace Repository
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerRepository;

        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
        }

        public Manager GetManager(int id)
        {
            return _managerRepository.Get(id);
        }

        public Manager GetManagerWithSecretary(int id)
        {
            return _managerRepository.GetWithSecretary(id);
        }

        public IEnumerable<Manager> GetActiveManagers()
        {
            return _managerRepository.GetManagers(x => !x.OutOfOffice);
        }

        public IEnumerable<Manager> GetInactiveManagersWithDeputies()
        {
            return _managerRepository.GetManagersWithDeputies(x => x.OutOfOffice);
        }

        public void SetManagerInactive(Manager manager)
        {
            manager.OutOfOffice = true;
            _managerRepository.Update(manager);
        }
    }
}