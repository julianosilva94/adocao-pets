using System.Collections;
using System.Collections.Generic;
using PetAdoption.Domain.Entities;

namespace PetAdoption.Domain.Repositories
{
    public interface IPetRepository
    {
        IEnumerable<Pet> GetAll();
        void Create(Pet pet);
    }
}