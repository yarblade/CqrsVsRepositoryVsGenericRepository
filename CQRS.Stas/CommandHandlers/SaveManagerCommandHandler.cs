using CQRS.Stas.Commands;
using NHibernate;

namespace CQRS.Stas.CommandHandlers
{
    public class SaveManagerCommandHandler : ICommandHandler<SaveManagerCommand>
    {
        private readonly ISession _session;

        public SaveManagerCommandHandler(ISession session)
        {
            _session = session;
        }

        public void Handle(SaveManagerCommand command)
        {
            _session.Save(command.Manager);
        }
    }
}