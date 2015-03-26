using CQRS.Stas.Queries;

namespace CQRS.Stas.QueryHandlers
{
    public interface IQueryHandler<in TQuery, out TResult>
        where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}