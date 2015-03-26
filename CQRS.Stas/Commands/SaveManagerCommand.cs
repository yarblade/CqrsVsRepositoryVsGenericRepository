using Entities;

namespace CQRS.Stas.Commands
{
    public class SaveManagerCommand : ICommand
    {
        public Manager Manager { get; private set; }

        public SaveManagerCommand(Manager manager)
        {
            Manager = manager;
        }
    }
}