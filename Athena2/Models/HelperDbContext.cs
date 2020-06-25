using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Models
{
    class Helper : DbContext
    {
        public DbSet<Download> Downloads { get; set; }
        public DbSet<DownloadTask> DownloadTasks { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public Helper(): base("name=DefaultConnection")
        {
            // Turn off the Migrations, (NOT a code first Db)
            Database.SetInitializer<Helper>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
