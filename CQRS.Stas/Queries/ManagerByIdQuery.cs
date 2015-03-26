using Entities;

namespace CQRS.Stas.Queries
{
    public class ManagerByIdQuery : IQuery<Manager>
    {
        public ManagerByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; private set; }
    }
}