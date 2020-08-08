using Microsoft.EntityFrameworkCore;
using PetAdoption.Domain.Entities;

namespace PetAdoption.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        
        public DbSet<Pet> Pets { get; set; }
    }
}