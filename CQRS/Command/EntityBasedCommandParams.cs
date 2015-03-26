namespace CQRS.IRR.Command
{
    public abstract class EntityBasedCommandParams<TEntity> : ICommandParams
    {
        protected EntityBasedCommandParams(TEntity instance)
        {
            Instance = instance;
        }

        public TEntity Instance { get; set; }
    }
}