using PetAdoption.Domain.Commands;
using PetAdoption.Domain.Commands.Contracts;
using PetAdoption.Domain.Entities;
using PetAdoption.Domain.Handlers.Contracts;
using PetAdoption.Domain.Repositories;

namespace PetAdoption.Domain.Handlers
{
    public class PetHandler : IHandler<RegisterPetCommand>
    {
        private readonly IPetRepository _repository;

        public PetHandler(IPetRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(RegisterPetCommand command)
        {
            var pet = new Pet(command.Name, command.Sex, command.Location);
            _repository.Create(pet);
            
            return new GenericCommandResult(true, "Pet registrado!", pet);
        }
    }
}