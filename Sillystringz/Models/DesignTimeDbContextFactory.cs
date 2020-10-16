using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace Sillystringz.Models
{
  public class DesignTimeDbContextFactory
  {
    public class SillystringzContextFactory : IDesignTimeDbContextFactory<SillystringzContext>
    {

      SillystringzContext IDesignTimeDbContextFactory<SillystringzContext>.CreateDbContext(string[] args)
      {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<SillystringzContext>();
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        builder.UseMySql(connectionString);

        return new SillystringzContext(builder.Options);
      }
    }
  }
}