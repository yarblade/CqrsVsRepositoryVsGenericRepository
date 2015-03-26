using CQRS.Stas.Containers;
using CQRS.Stas.Queries;
using CQRS.Stas.QueryHandlers;

namespace CQRS.Stas.QueryServices
{
    public class ContainerQueryService : IQueryService
    {
        private readonly IContainer _container;

        public ContainerQueryService(IContainer container)
        {
            _container = container;
        }

        public TResult Query<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>).MakeGenericType(query.GetType(), typeof(TResult));
            var handler = _container.Resolve(handlerType);
            try
            {
                return (TResult)((dynamic)handler).Handle((dynamic)query);
            }
            finally
            {
                _container.Release(handler);
            }
        }
    }
}
