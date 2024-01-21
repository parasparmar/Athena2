using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Athena.Models
{
    class Helper : DbContext
    {
        public DbSet<Download> Downloads { get; set; }
        public DbSet<DownloadTask> DownloadTasks { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<Exchange> Exchanges { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public string DbPath { get; }
        public Helper()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            DbPath = Assembly.GetExecutingAssembly().Location;
            DbPath = DbPath.Replace(Assembly.GetExecutingAssembly().Location, "Database");
            DbPath = Path.Join(DbPath, "athena.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
