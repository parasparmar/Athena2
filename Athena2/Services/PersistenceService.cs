﻿using Athena.Models;
using Athena.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public static int SaveDownload(Download d)
        {
            using (Helper db = new Helper())
            {
                Download dld = new Download();
                if (d != null && d.Id != null)
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
                if (d != null && d.DownloadTaskId != null)
                {
                    dtd = db.DownloadTasks.Find(d.DownloadTaskId);
                    dld = db.Downloads.Include(a => a.Link).Where(e => e.LinkId==1).FirstOrDefault();
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
