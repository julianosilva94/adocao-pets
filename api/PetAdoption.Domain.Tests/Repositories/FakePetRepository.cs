using System.Collections.Generic;
using PetAdoption.Domain.Entities;
using PetAdoption.Domain.Repositories;

namespace PetAdoption.Domain.Tests.Repositories
{
    public class FakePetRepository : IPetRepository
    {
        public IEnumerable<Pet> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Create(Pet pet)
        {
        }
    }
}