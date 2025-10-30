using System.Text.RegularExpressions;
using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

     
        public DbSet<JobTitle> JobTitle { get; set; }
        public DbSet<Groups> Groups { get;set; }

        public DbSet<Absense> Absense { get; set; }

        public DbSet<Child> Child { get; set; }
      
        public DbSet<Menu> Menu { get; set; }


        public DbSet<Queue> Queue { get; set; }

        public DbSet<ChildGroupHistory> ChildGroupHistory { get; set; }

        public DbSet<Staff> Staff { get; set; }

     
    }
}
