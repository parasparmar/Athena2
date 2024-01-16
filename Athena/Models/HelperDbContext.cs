using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.IO;
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
        public string DbPath { get; }
        public Helper()
        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            //var path = Environment.GetFolderPath(folder);
            var path = Assembly.GetExecutingAssembly().Location;
            path = path.Replace(Assembly.GetExecutingAssembly().Location, "Database");
            path = Path.Join(path.ToString(), "athena.db");

            DbPath = path;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }
}
