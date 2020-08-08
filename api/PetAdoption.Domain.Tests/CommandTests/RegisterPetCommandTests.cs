using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetAdoption.Domain.Commands;

namespace PetAdoption.Domain.Tests.CommandTests
{
    [TestClass]
    public class RegisterPetCommandTests
    {
        [TestMethod]
        public void Valid()
        {
            var command = new RegisterPetCommand("Jack", "male", "Cachoeirinha - RS");
            command.Validate();
            Assert.AreEqual(command.Valid, true);
        }
    }
}