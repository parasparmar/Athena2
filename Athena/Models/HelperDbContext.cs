using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace Athena.Models
{
    class Helper : DbContext
    {
        public DbSet<Download> Downloads { get; set; }
        public DbSet<DownloadTask> DownloadTasks { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public Helper(): base()
        {
            // Turn off the Migrations, (NOT a code first Db)
            //Database.SetInitializer<Helper>(null);
    //        var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
    //.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test")
    //.Options;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlite("Data Source='\\Database\\athena.db'");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Database does not pluralize table names
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
