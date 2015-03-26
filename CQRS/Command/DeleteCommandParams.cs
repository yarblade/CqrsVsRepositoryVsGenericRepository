namespace CQRS.IRR.Command
{
    public class DeleteCommandParams<TEntity> : EntityBasedCommandParams<TEntity>
    {
        public DeleteCommandParams(TEntity instance)
            : base(instance)
        {
        }
    }
}
