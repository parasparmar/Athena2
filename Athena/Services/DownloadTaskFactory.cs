using Athena.Models;

namespace Athena.Services
{
    public class DownloadTaskFactory
    {
        public static List<MyDownloadTask> createFileDownloads(List<MyDownloadTask> mdt, DateTime FromDate, DateTime ToDate)
        {
            List<FileDownload> fdt;
            var workingDays = BusinessDay.WorkingDays(FromDate: FromDate, ToDate: ToDate);
            for(int i = 0; i< mdt.Count; i++)
            {
                fdt = new List<FileDownload>();
                foreach (var day in workingDays)
                {
                    // Create the actual List of downloadables here.
                    fdt.Add(new FileDownload
                    {
                        Id = mdt[i].DownloadTaskId,
                        TaskId = mdt[i].DownloadTaskId,
                        Date = day,
                        // Give the exact url to download
                        Url = URLParser.getThisDownloadsUrl(mdt[i].UrlFormat, day),
                        Destination = mdt[i].DownloadLocation,
                        // Give the extracted files renaming format
                        FileName = URLParser.getThisDownloadsUrl(mdt[i].DestinationFileFormat, day)                        
                    });
                }
                mdt[i].FileDownloads = fdt;
            }
            return mdt;
        }
    }
}
