using lab2.Rest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab2.Rest.Context
{
    class AzureDbContext : DbContext
    {
        public AzureDbContext(DbContextOptions<AzureDbContext> options) : base(options)
        {

        }
        protected AzureDbContext()
        {

        }
        public DbSet<Person> People { get; set; }
    }
}
