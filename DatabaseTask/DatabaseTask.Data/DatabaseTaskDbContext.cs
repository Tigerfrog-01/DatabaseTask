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
        public DbSet<Groups> Group { get;set; }

        public DbSet<Absense> Absence { get; set; }

        public DbSet<Child> Child { get; set; }

        public DbSet<KinderGarten> Kindergarten { get; set; }

        public DbSet<Menu> Menu { get; set; }

        public DbSet<Parent> Parent { get; set; }

        public DbSet<Que> Que { get; set; }

        public DbSet<Staff> Staff { get; set; }

        public DbSet<Workers> Workers { get; set; }
    }
}
