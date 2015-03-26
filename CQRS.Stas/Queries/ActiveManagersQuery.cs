using System.Collections.Generic;
using Entities;

namespace CQRS.Stas.Queries
{
    public class ActiveManagersQuery : IQuery<IEnumerable<Manager>>
    {
        public ActiveManagersQuery(bool isActive)
        {
            IsActive = isActive;
        }

        public bool IsActive { get; private set; }
    }
}