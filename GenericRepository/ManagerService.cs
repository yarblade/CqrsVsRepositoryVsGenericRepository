using System.Collections.Generic;
using System.Linq;
using Common.Interfaces;
using Entities;
using GenericRepository.Extensions;
using GenericRepository.Repositories;

namespace GenericRepository
{
    public class ManagerService : IManagerService
    {
        private readonly IGenericRepository<Manager> _genericRepository;

        public ManagerService(IGenericRepository<Manager> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public Manager GetManager(int id)
        {
            return _genericRepository.All().SingleOrDefault(x => x.Id == id);
        }

        public Manager GetManagerWithSecretary(int id)
        {
            return _genericRepository.All().Include(x => x.Phone).SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Manager> GetActiveManagers()
        {
            return _genericRepository.All().Where(x => !x.OutOfOffice);
        }

        public IEnumerable<Manager> GetInactiveManagersWithDeputies()
        {
            return _genericRepository.All().Include(x => x.Deputy).Where(x => x.OutOfOffice);
        }

        public void SetManagerInactive(Manager manager)
        {
            manager.OutOfOffice = true;

            _genericRepository.Update(manager);
        }
    }
}