using CQRS.IRR.Command;

namespace CQRS.IRR.Extensions
{
    public static class CommandDispatcherExtensions
    {
        public static int Delete<TEntity>(this ICommandDispatcher dispatcher, TEntity instance)
        {
            var @params = new DeleteCommandParams<TEntity>(instance);
            return dispatcher.Dispatch(@params);
        }

        public static int Evict<TEntity>(this ICommandDispatcher dispatcher, TEntity instance)
        {
            var @params = new EvictCommandParams<TEntity>(instance);
            return dispatcher.Dispatch(@params);
        }

        public static int SaveOrUpdate<TEntity>(this ICommandDispatcher dispatcher, TEntity instance)
        {
            var @params = new SaveOrUpdateCommandParams<TEntity>(instance);
            return dispatcher.Dispatch(@params);
        }
    }
}