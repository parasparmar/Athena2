using Athena.Models;
using Athena.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Athena.Services
{
    class DownloadTaskFactory
    {
        public static List<FileDownload> createFileDownloads(List<MyDownloadTask> mdt, DateTime FromDate, DateTime ToDate)
        {

            using (Helper db = new Helper())
            {
                

                
            }

            List<FileDownload> fdt = new List<FileDownload>();
            var workingDays = BusinessDay.WorkingDays(FromDate: FromDate, ToDate: ToDate);
            foreach (var task in mdt)
            {
                foreach (var day in workingDays)
                {


                    // Create the actual List of downloadables here.
                    fdt.Add(new FileDownload
                    {
                        Id = task.DownloadTaskId,
                        TaskId = task.DownloadTaskId,
                        Date = day,
                        // Give the exact url to download
                        Url = URLParser.getThisDownloadsUrl(task.UrlFormat, day),
                        Destination = task.DownloadLocation,
                        // Give the extracted files renaming format
                        FileName = URLParser.getThisDownloadsUrl(task.DestinationFileFormat, day),
                        Progress = task.TaskProgress,
                        Status = task.TaskStatus
                    });
                }
            }
            return fdt;
        }
    }
}
