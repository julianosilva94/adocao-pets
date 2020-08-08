using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PetAdoption.Domain.Entities;
using PetAdoption.Domain.Infra.Contexts;
using PetAdoption.Domain.Repositories;

namespace PetAdoption.Domain.Infra.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly DataContext _context;

        public PetRepository(DataContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Pet> GetAll()
        {
            return _context.Pets.AsNoTracking();
        }

        public void Create(Pet pet)
        {
            _context.Pets.Add(pet);
            _context.SaveChanges(); 
        }
    }
}