namespace CQRS.IRR.Command
{
    public interface ICommand<in TParams>
        where TParams : ICommandParams
    {
        int Execute(TParams @params);
    }
}