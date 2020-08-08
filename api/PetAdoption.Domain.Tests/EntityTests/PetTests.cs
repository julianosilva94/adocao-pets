using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetAdoption.Domain.Entities;

namespace PetAdoption.Domain.Tests.EntityTests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void NewPetShouldNotBeMarkedAsAdopted()
        {
            var pet = new Pet("Jack", "male", "Cachoeirinha - RS");
            
            Assert.AreEqual(pet.Adopted, false);
        }
    }
}