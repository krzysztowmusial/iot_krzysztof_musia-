using lab2.Rest.Models;
using Microsoft.EntityFrameworkCore;

namespace lab2.Rest.Context
{
    public class AzureDbContext : DbContext
    {
        public AzureDbContext(DbContextOptions options) : base(options)
        {

        }
        // protected AzureDbContext()
        // {

        // }
        public DbSet<Person> People { get; set; }
    }
}
