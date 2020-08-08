using PetAdoption.Domain.Commands.Contracts;

namespace PetAdoption.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}