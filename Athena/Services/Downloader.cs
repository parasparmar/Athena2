﻿using Athena.Models;
using System;
using System.Net;

namespace Athena.Services
{
    class Downloader
    {
        private CookieContainer cookieJar;
        public String LocalBasePathToDownload;


        public bool DownloadFile(FileDownload CurrentTask)
        {
            //ISSUE : Although the Synchronous downloader works. It will freeze the UI. This is a known devil.
            try
            {
                HttpWebRequest request;
                HttpWebResponse response;
                request = (HttpWebRequest)HttpWebRequest.Create(CurrentTask.Url);
                //request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
                //request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:78.0) Gecko/20100101 Firefox/78.0";
                //string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/115.0.0.0 Safari/537.36 Edg/115.0.1901.203";
                string userAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
                request.Headers.Set(HttpRequestHeader.UserAgent, userAgent);
                request.Accept = "*/*";
                ////.Connection = "Keep-Alive";
                request.Headers.Add("Accept-Language", "en-IN");
                request.Headers.Add("Accept-Encoding", "gzip, deflate, br");
                request.Headers.Add("DNT", "1");
                request.CookieContainer = cookieJar;

                using (response = (HttpWebResponse)request.GetResponse())
                {
                    return Extract.Writer(response, ref CurrentTask);
                }
            }
            catch (Exception Ex)
            {
                CurrentTask.Status = Ex.Message.ToString();                
                return false;
            }
        }
        //public class DownloadItems
        //{
        //    public bool IsSuccess { get; set; }
        //    public Exception Exception { get; set; }
        //}
        //public DownloadItems GetItemStream(string downloadURL = null, string filePath = null)
        //{
        //    DownloadItems downloadItems = new DownloadItems();
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(filePath))
        //        {
        //            using (FileStream fileStream = new System.IO.FileStream(filePath, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write))
        //            {
        //                if (!string.IsNullOrEmpty(downloadURL))
        //                {
        //                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(downloadURL);
        //                    request.Method = WebRequestMethods.Http.Get;
        //                    request.PreAuthenticate = true;
        //                    request.UseDefaultCredentials = true;
        //                    const int BUFFER_SIZE = 16 * 1024;
        //                    {
        //                        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
        //                        {
        //                            using (var responseStream = response.GetResponseStream())
        //                            {
        //                                var buffer = new byte[BUFFER_SIZE];
        //                                int bytesRead;
        //                                do
        //                                {
        //                                    bytesRead = responseStream.Read(buffer, 0, BUFFER_SIZE);
        //                                    fileStream.Write(buffer, 0, bytesRead);
        //                                } while (bytesRead > 0);
        //                            }
        //                        }
        //                        fileStream.Close();
        //                        downloadItems.IsSuccess = true;
        //                    }
        //                }
        //                else
        //                    downloadItems.IsSuccess = false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        downloadItems.IsSuccess = false;
        //        downloadItems.Exception = ex;
        //    }
        //    return downloadItems;
        //}
        //public bool DownloadTaskList(ref List<FileDownloads> TaskList, DateTime fromDate, DateTime toDate)
        //{
        //    // Convert the List<MyDownloadTask> to Individual FileDownloads and handover to the Download agent one by one
        //    // Let the agent be Async
        //    var dateList = BusinessDay.WorkingDays(fromDate, toDate);
        //    List<Download> newTasks = new List<Download>();
        //    foreach (var MyTask in TaskList)
        //    {
        //        // Get the Date format associated with this Link
        //        string[] strArrSourceUrl = MyTask.FileName.Split('{', '}');
        //        string recvdDateFormat = string.Empty;
        //        foreach (var myUrl in strArrSourceUrl)
        //        {
        //            if (URLParser.DateFormats.Contains(myUrl))
        //            {
        //                recvdDateFormat = myUrl;
        //            }
        //        }

        
        //        //MyTask.SourceLink = MyTask.SourceLink.Replace("{" + recvdDateFormat + "}", DateTime.Today.ToString(recvdDateFormat));




        //        foreach (var item in dateList)
        //        {
        //            //Download d = new Download
        //            //{
        //            //    At = DateTime.Today,
        //            //    LinkId = MyTask.TaskId
        //            //    SourceLink = MyTask.UrlFormat.Replace("{" + recvdDateFormat + "}", DateTime.Today.ToString(recvdDateFormat)),        
        //            //    Status = "Scheduled"
        //            //};
        //            //newTasks.Add(d);
        //            //theseDownloads.Add(d);
        //        }

        //        PersistenceService.SaveDownloadsAsync(newTasks);
        //    }
        //    using (Helper db = new Helper())
        //    {
        //        FileDownloads fd = new FileDownloads
        //        {
        //            Date = DateTime.Today,
        //            Url = "https://www1.nseindia.com/archives/equities/bhavcopy/pr/PR030720.zip",
        //            FileName = "NSE EOD Data",
        //            Destination = "D:\\Desktop\\Stocks\\NSE",

        //        };
        //        this.DownloadFile(fd);
        //    }
        //    MessageBox.Show("All Downloads Successful.");
        //    return true;
        //}

    }
}
