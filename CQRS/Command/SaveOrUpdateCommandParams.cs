namespace CQRS.IRR.Command
{
    public class SaveOrUpdateCommandParams<TEntity> : EntityBasedCommandParams<TEntity>
    {
        public SaveOrUpdateCommandParams(TEntity instance)
            : base(instance)
        {
        }
    }
}