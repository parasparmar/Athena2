using Athena.Models;
using LinqToDB;
using LinqToDB.Data;

namespace Athena.Services
{
    public class PersistenceService
    {
        public static int SaveDownloads(List<Download> downloads)
        {
            using (AthenaDb db = new AthenaDb())
            {
                //db.Downloads.AddRange(downloads);
                var status = db.Downloads.BulkCopy(downloads);
                Console.WriteLine("RowsCopied : " + status.RowsCopied);
                return (int)status.RowsCopied;
            }
        }
        public static int SaveDownloads(List<MyDownloadTask> downloads)
        {
            using AthenaDb db = new AthenaDb();
            List<Download> d = new List<Download>();
            foreach (var item in downloads)
            {
                d.AddRange(item.FileDownloads.Select(a => new Download
                {
                    Id = a.Id,
                    At = a.Date,
                    Status = a.Status,
                    SourceLink = a.Url,
                }));
            }
            //TODO: Save the status of the file downloads to db;
            var e = db.BulkCopy<Download>(d);
            return (int)e.RowsCopied;

        }
        public static int SaveDownload(Download d)
        {
            int e = 0;
            using AthenaDb db = new AthenaDb();
            var dld = new Download();
            if (d != null && d.Id > 0)
            {
                dld = db.Downloads.Find(d.Id);
                if (dld != null)
                {
                    dld.LinkId = d.LinkId;
                    dld.SourceLink = d.SourceLink;
                    dld.Status = d.Status;
                    dld.At = d.At;
                    e = db.Insert<Download>(dld);
                }
            }
            return e;
        }
        public static int SaveDownload(MyDownloadTask d)
        {
            using AthenaDb db = new AthenaDb();
            var dtd = new DownloadTask();
            var dld = new Download();

            if (d != null && d.DownloadTaskId > 0)
            {
                dtd = db.DownloadTasks.Find(d.DownloadTaskId);

                dld = db.Downloads.LoadWith(a => a.LinkId).Where(e => e.LinkId == 1).FirstOrDefault();
                if (dtd != null)
                {
                    dld.LinkId = dtd.LinkId;
                    dld.SourceLink = d.SourceUrl;
                }
                else
                {
                    db.Downloads.Add(dld);
                    db.Entry(dld).State = EntityState.Added;
                }

            }
            return db.SaveChanges();

        }
    }
}
