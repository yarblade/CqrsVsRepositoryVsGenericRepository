namespace CQRS.IRR.Command
{
    public interface ICommandDispatcher
    {
        int Dispatch<TParams>(TParams @params)
            where TParams : ICommandParams;
    }
}