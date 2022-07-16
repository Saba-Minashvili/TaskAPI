using Domain;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Persistence
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions options, IConfiguration configuration) :base(options) 
        {
            Configuration = configuration;
        }

        public IConfiguration? Configuration { get; }

        public DbSet<Addressing>? Addressing { get; set; }
        public DbSet<HouseHold>? HouseHold { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("TaskAPIDbConnectionString"));
        }
    }
}
