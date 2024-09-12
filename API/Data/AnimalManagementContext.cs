using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AnimalManagementContext : DbContext
    {
        public AnimalManagementContext(DbContextOptions<AnimalManagementContext> options) : base(options)
        {
            
        }

        public DbSet<Grouping> Groupings { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
