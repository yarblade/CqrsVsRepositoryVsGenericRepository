using CQRS.Stas.Commands;

namespace CQRS.Stas.CommandServices
{
    public interface ICommandService
    {
        void Handle<T>(T command) where T : ICommand;
    }
}