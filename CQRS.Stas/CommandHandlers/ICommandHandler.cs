using CQRS.Stas.Commands;

namespace CQRS.Stas.CommandHandlers
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        void Handle(T command);
    }
}