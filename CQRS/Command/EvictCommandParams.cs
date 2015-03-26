namespace CQRS.IRR.Command
{
    public class EvictCommandParams<TEntity> : EntityBasedCommandParams<TEntity>
    {
        public EvictCommandParams(TEntity instance)
            : base(instance)
        {
        }
    }
}
