using Athena.Models;
using System.Net;
using System.Net.Http.Headers;
namespace Athena.Services;

public class DownloadService
{
    #pragma warning disable SYSLIB0014
    private CookieContainer cookieJar;
    /// <summary>
    /// Downloads a File given the FileDownload object which encapsulates the current file to be downloaded and its associated source and destinations.
    /// </summary>
    /// <param name="CurrentTask">An object of type FileDownload</param>
    /// <returns>A list of files is written to the disk at the specified location.</returns>
    public bool DownloadFile(FileDownload CurrentTask)
    {
        //ISSUE : Although the Synchronous downloader works. It will freeze the UI. This is a known devil.
        try
        {

            HttpWebRequest request;
            HttpWebResponse response;
            request = (HttpWebRequest)WebRequest.Create(CurrentTask.Url);
            //request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
            //request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:78.0) Gecko/20100101 Firefox/78.0";
            //string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36 Edg/115.0.1901.203";
            string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
            request.Headers.Set(HttpRequestHeader.UserAgent, userAgent);
            request.Accept = "*/*";
            request.Headers.Add("Accept-Language", "en-IN");
            request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
            request.Headers.Add("DNT", "1");
            request.CookieContainer = cookieJar;

            using (response = (HttpWebResponse)request.GetResponse())
            {
                return ExtractionService.Writer(response, CurrentTask);
            }
        }
        catch (Exception Ex)
        {
            CurrentTask.Status = Ex.Message.ToString();
            return false;
        }

    }
    #pragma warning restore SYSLIB0014
    public List<MyDownloadTask> createFileDownloads(List<MyDownloadTask> mdt, DateTime FromDate, DateTime ToDate)
    {
        List<FileDownload> fdt;
        var workingDays = BusinessDayService.WorkingDays(FromDate: FromDate, ToDate: ToDate);
        for (int i = 0; i < mdt.Count; i++)
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
                    Url = URLParsingService.getThisDownloadsUrl(mdt[i].UrlFormat, day),
                    Destination = mdt[i].DownloadLocation,
                    // Give the extracted files renaming format
                    FileName = URLParsingService.getThisDownloadsUrl(mdt[i].DestinationFileFormat, day)
                });
            }
            mdt[i].FileDownloads = fdt;
        }
        return mdt;
    }
}


