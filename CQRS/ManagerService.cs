using System.Collections.Generic;
using Common.Interfaces;
using CQRS.IRR.Command;
using CQRS.IRR.Criterias;
using CQRS.IRR.Extensions;
using CQRS.IRR.Queries;
using Entities;

namespace CQRS.IRR
{
    public class ManagerService : IManagerService
    {
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly ICommandDispatcher _commandDispatcher;

        public ManagerService(IQueryDispatcher queryDispatcher, ICommandDispatcher commandDispatcher)
        {
            _queryDispatcher = queryDispatcher;
            _commandDispatcher = commandDispatcher;
        }

        public Manager GetManager(int id)
        {
            return _queryDispatcher.Get<Manager>().ById(id);
        }

        public Manager GetManagerWithSecretary(int id)
        {
            return _queryDispatcher.Get<Manager>().By(new ManagerWithSecretaryByIdCriteria(id));
        }

        public IEnumerable<Manager> GetActiveManagers()
        {
            return _queryDispatcher.List<Manager>().ByFilter(x => !x.OutOfOffice);
        }

        public IEnumerable<Manager> GetInactiveManagersWithDeputies()
        {
            return _queryDispatcher.List<Manager>().By(new ManagerWithDeputiesCriteria(x => x.OutOfOffice));
        }

        public void SetManagerInactive(Manager manager)
        {
            manager.OutOfOffice = true;
            
            _commandDispatcher.SaveOrUpdate(manager);
        }
    }
}
