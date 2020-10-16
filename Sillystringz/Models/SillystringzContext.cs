using System.Reflection.PortableExecutable;
using Microsoft.EntityFrameworkCore;
namespace Sillystringz.Models
{
    public class SillystringzContext : DbContext
    {
         public  DbSet<Engineer> Engineers { get; set; }
         public  DbSet<Machine> Machine { get; set; }
         public  DbSet<EngineerMachine> EngineerMachine { get; set; } 

        public SillystringzContext(DbContextOptions options) : base(options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}


