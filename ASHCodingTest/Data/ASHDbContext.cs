using System.ComponentModel;
using ASHCodingTest.Models;
using Microsoft.EntityFrameworkCore;

namespace ASHCodingTest.Data
{
    public class ASHDbContext : DbContext
    {
        public ASHDbContext(DbContextOptions<ASHDbContext> options) :base(options) { }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PayType> PayTypes { get; set; }

    }
}
