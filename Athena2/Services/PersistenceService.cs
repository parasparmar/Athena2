using Athena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Services
{
    class PersistenceService
    {

        public static async Task<int> SaveDownloadsAsync(List<Download> downloads)
        {
            using (Helper db = new Helper())
            {
                db.Downloads.AddRange(downloads);
                return await db.SaveChangesAsync();
            }
        }

        public static int SaveDownloads(List<Download> downloads)
        {
            using (Helper db = new Helper())
            {
                db.Downloads.AddRange(downloads);
                return db.SaveChanges();
            }
        }
    }
}
