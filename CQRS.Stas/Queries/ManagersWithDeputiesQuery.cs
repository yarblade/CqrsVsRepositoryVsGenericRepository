namespace CQRS.Stas.Queries
{
    public class ManagersWithDeputiesQuery : ActiveManagersQuery
    {
        public ManagersWithDeputiesQuery(bool isActive) : base(isActive)
        {
        }
    }
}