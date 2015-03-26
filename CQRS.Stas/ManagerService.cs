using System.Collections.Generic;
using Common.Interfaces;
using CQRS.Stas.Commands;
using CQRS.Stas.CommandServices;
using CQRS.Stas.Queries;
using CQRS.Stas.QueryServices;
using Entities;

namespace CQRS.Stas
{
    public class ManagerService : IManagerService
    {
        private readonly ICommandService _commandService;
        private readonly IQueryService _queryService;

        public ManagerService(IQueryService queryService, ICommandService commandService)
        {
            _queryService = queryService;
            _commandService = commandService;
        }

        public Manager GetManager(int id)
        {
            return _queryService.Query(new ManagerByIdQuery(id));
        }

        public Manager GetManagerWithSecretary(int id)
        {
            return _queryService.Query(new ManagerWithSecretaryByIdQuery(id));
        }

        public IEnumerable<Manager> GetActiveManagers()
        {
            return _queryService.Query(new ActiveManagersQuery(true));
        }

        public IEnumerable<Manager> GetInactiveManagersWithDeputies()
        {
            return _queryService.Query(new ManagersWithDeputiesQuery(false));
        }

        public void SetManagerInactive(Manager manager)
        {
            _commandService.Handle(new SaveManagerCommand(manager));
        }
    }
}