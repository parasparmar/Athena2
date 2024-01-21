using Athena.Models;
using System.Net;

namespace Athena.Services
{
    public class Downloader
    {
        private CookieContainer cookieJar;
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
                    return Extract.Writer(response, CurrentTask);
                }
            }
            catch (Exception Ex)
            {
                CurrentTask.Status = Ex.Message.ToString();                
                return false;
            }
        }
    }
}
