using Athena.Models;
using Microsoft.EntityFrameworkCore;

namespace Athena.Services
{
    class PersistenceService
    {

        //public static async Task<int> SaveDownloadsAsync(List<Download> downloads)
        //{
        //    using (Helper db = new Helper())
        //    {
        //        db.Downloads.AddRange(downloads);
        //        return await db.SaveChangesAsync();
        //    }
        //}

        public static int SaveDownloads(List<Download> downloads)
        {
            using (Helper db = new Helper())
            {
                db.Downloads.AddRange(downloads);
                return db.SaveChanges();
            }
        }

        public static int SaveDownloads(List<MyDownloadTask> downloads)
        {
            using (Helper db = new Helper())
            {
                List<Download> d = new List<Download>();
                foreach (var item in downloads)
                {
                    d.AddRange(item.FileDownloads.Select(a => new Download
                    {
                        Id = a.Id,
                        At = a.Date,
                        Progress = a.Progress,
                        Status = a.Status,
                        SourceLink = a.Url,
                    }));
                }
                //TODO: Save the status of the file downloads to db;


                return db.SaveChanges();
            }
        }
        public static int SaveDownload(Download d)
        {
            using (Helper db = new Helper())
            {
                Download dld = new Download();
                if (d != null && d.Id >0)
                {
                    dld = db.Downloads.Find(d.Id);
                    if (dld != null)
                    {
                        dld.LinkId = d.LinkId;
                        dld.Progress = d.Progress;
                        dld.SourceLink = d.SourceLink;
                        dld.Status = d.Status;
                        dld.At = d.At;
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

        public static int SaveDownload(MyDownloadTask d)
        {
            using (Helper db = new Helper())
            {
                DownloadTask dtd = new DownloadTask();
                Download dld = new Download();
                if (d != null && d.DownloadTaskId > 0)
                {
                    dtd = db.DownloadTasks.Find(d.DownloadTaskId);
                    dld = db.Downloads.Include(a => a.Link).Where(e => e.LinkId == 1).FirstOrDefault();
                    if (dtd != null)
                    {
                        dld.LinkId = dtd.LinkId;
                        dld.Progress = d.TaskProgress;
                        dld.SourceLink = d.SourceUrl;
                        dld.Status = d.TaskStatus;
                        //dld.At = d.
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
}
