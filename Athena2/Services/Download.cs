using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Athena.Services
{
    class Download
    {
        private CookieContainer cookieJar;
        public String LocalBasePathToDownload;

        public bool File(Task CurrentTask)
        {
            //ISSUE : Although the Synchronous downloader works. It will freeze the UI. This is a known devil.
            try
            {
                HttpWebRequest request;
                HttpWebResponse response;

                request = (HttpWebRequest)HttpWebRequest.Create(CurrentTask.URIWithFileName);

                //IWebProxy proxy = request.Proxy;
                //if (proxy != null)
                //{
                //    string proxyuri = proxy.GetProxy(request.RequestUri).ToString();
                //    request.UseDefaultCredentials = true;
                //    request.Proxy = new WebProxy(proxyuri, false);
                //    request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                //}

                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; Trident/7.0; rv:11.0) like Gecko";
                request.Accept = "text/html, application/xhtml+xml, */*";
                ////.Connection = "Keep-Alive";
                request.Headers.Add("Accept-Language", "en-IN");
                request.Headers.Add("Accept-Encoding", "gzip, deflate");
                request.Headers.Add("DNT", "1");
                request.CookieContainer = cookieJar;

                response = (HttpWebResponse)request.GetResponse();
                //// DownloadWriter downloads and renames the expected ZIP from response into a localfile named DeflatedFileName
                //// Returns true if successful and false if not.
                if (DownloadWriter(ref response, ref CurrentTask))
                {
                    //// Tidy up the HTTPWebResponse
                    response.Close();
                    return true;
                }
                else
                {
                    //// Tidy up the HTTPWebResponse
                    response.Close();
                    return false;
                }
            }
            catch (Exception Ex)
            {
                Console.Write(Ex.Message.ToString());
                return false;
            }
        }

        // private async Task<Task> DownloadAgent(Task CurrentTask) { }
        public bool DownloadWriter(ref HttpWebResponse response, ref Task currentTask)
        {
            //    ' Take the HTTP Web response from Downloader.
            //    ' Unzip it to the destination folder.
            if (response.ContentType == "application/zip" || response.ContentType == "application/x-zip-compressed")
            {
                long intLen = response.ContentLength;
                using (Stream stmResponse = response.GetResponseStream())
                {
                    Decimal n = 0;
                    Decimal numBytesRead = 0;
                    Decimal numBytesToRead = (int)intLen;
                    byte[] buffer = new byte[intLen];

                    do
                    {

                        n = stmResponse.Read(buffer, (int)numBytesRead, (Int32)numBytesToRead);
                        numBytesRead += n;
                        numBytesToRead -= n;
                    } while (numBytesToRead > 0);

                    MemoryStream memStream = new MemoryStream(buffer);
                    string res = false.ToString();
                    //'' A wrapper function to Ionic.Zip library is used here.
                    res = ZipExtracttoFile(memStream, LocalBasePathToDownload + "\\" + currentTask.MarketFolder);


                    string WhatIDownloaded = (LocalBasePathToDownload + "\\" + currentTask.MarketFolder + "\\" + res).ToString();
                    WhatIDownloaded = WhatIDownloaded.Replace(".zip", "");
                    string WhatToRenameTo = (LocalBasePathToDownload + "\\" + currentTask.MarketFolder + "\\" + currentTask.FileNameAfterUnZip).ToString();

                    try
                    {
                        if (!File.Exists(WhatIDownloaded))
                        {
                            // This statement ensures that the file is created,
                            // but the handle is not kept.
                            using (FileStream fs = File.Create(WhatIDownloaded)) { }
                        }

                        // Ensure that the target does not exist.
                        if (File.Exists(WhatToRenameTo))
                            File.Delete(WhatToRenameTo);

                        // Move the file.
                        File.Move(WhatIDownloaded, WhatToRenameTo);
                        //Console.WriteLine("{0} was moved to {1}.", path, path2);

                        // See if the original exists now.
                        if (File.Exists(WhatIDownloaded))
                        {
                            // Console.WriteLine("The original file still exists, which is unexpected.");
                        }
                        else
                        {
                            //Console.WriteLine("The original file no longer exists, which is expected.");
                        }

                    }
                    catch (Exception e)
                    {
                        // Console.WriteLine("The process failed: {0}", e.ToString());
                    }

                    //  File.Move(WhatIDownloaded, WhatToRenameTo);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
