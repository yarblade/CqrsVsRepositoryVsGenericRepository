using CQRS.Stas.Queries;

namespace CQRS.Stas.QueryServices
{
    public interface IQueryService
    {
        TResult Query<TResult>(IQuery<TResult> query);
    }
}