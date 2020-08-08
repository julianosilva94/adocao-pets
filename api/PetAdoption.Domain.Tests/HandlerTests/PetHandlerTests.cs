using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetAdoption.Domain.Commands;
using PetAdoption.Domain.Handlers;
using PetAdoption.Domain.Tests.Repositories;

namespace PetAdoption.Domain.Tests.HandlerTests
{
    [TestClass]
    public class PetHandlerTests
    {
        private readonly PetHandler _handler;

        public PetHandlerTests()
        {
            _handler = new PetHandler(new FakePetRepository());
        }

        [TestMethod]
        public void ValidCommandShouldRegisterPet()
        {
            var command = new RegisterPetCommand("Jack", "male", "Cachoeirinha - RS");
            var result = (GenericCommandResult) _handler.Handle(command);
            
            Assert.AreEqual(result.Success, true);
        }
    }
}