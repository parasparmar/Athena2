using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using System.IO;
using System.Net;
using Athena.Models;

namespace Athena.Services
{
    class Extract
    {
        public static bool Writer(HttpWebResponse response, ref FileDownload currentTask)
        {
            // Make sure the directory exists. Create it if not.
            if (!Directory.Exists(currentTask.Destination))
            {
                Directory.CreateDirectory(currentTask.Destination);
            }
            var downloadPath = Path.Combine(currentTask.Destination, currentTask.FileName);


            if (response.ContentType.Contains("zip") || response.ContentEncoding.Contains("zip"))
            {
                //It's a zip, then extraction needed by Ionic Zip Library.
                //'' A wrapper function to Ionic.Zip library is used here.
                if (ZippedFiles(response: response, ref currentTask))
                {
                    currentTask.Status = "Completed";
                    currentTask.Progress = 100;
                    return true;
                }
                else
                {
                    currentTask.Status = "Failed";
                    currentTask.Progress = 0;
                    return false;
                }
            }
            else
            {
                if (SingleFile(response, ref currentTask))
                {
                    currentTask.Status = "Completed";
                    currentTask.Progress = 100;
                    return true;
                }
                else
                {
                    currentTask.Status = "Failed";
                    currentTask.Progress = 0;
                    return false;
                }
            }
            
        }
        private static bool SingleFile(HttpWebResponse response, ref FileDownload currentTask)
        {
            var downloadPath = Path.Combine(currentTask.Destination, currentTask.FileName);
            const int BUFFER_SIZE = 16 * 1024;
            long intLen = response.ContentLength;
            byte[] buffer = new byte[intLen];
            //NOt a zip, then no extraction needed.
            using (FileStream fileStream = new FileStream(downloadPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                if (!string.IsNullOrEmpty(currentTask.Url))
                {
                    using (var responseStream = response.GetResponseStream())
                    {
                        buffer = new byte[BUFFER_SIZE];
                        int bytesRead;
                        do
                        {
                            bytesRead = responseStream.Read(buffer, 0, BUFFER_SIZE);
                            fileStream.Write(buffer, 0, bytesRead);
                        } while (bytesRead > 0);
                    }


                    fileStream.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private static bool ZippedFiles(HttpWebResponse response, ref FileDownload currentTask)
        {

            //    ' Take the HTTP Web response from Downloader.
            //    ' Unzip it to the FileName folder.
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

                try
                {
                    using (MemoryStream memStream = new MemoryStream(buffer))
                    {
                        using (ZipFile zip = ZipFile.Read(memStream))
                        {
                            currentTask.ZippedFiles = zip.EntryFileNames.ToList();
                            zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                            foreach (ZipEntry e in zip)
                            {
                                e.Extract(currentTask.Destination, ExtractExistingFileAction.OverwriteSilently);
                                var extractedFile = Path.Combine(currentTask.Destination, e.FileName);
                                if (File.Exists(extractedFile))
                                {
                                    var newFileName = Path.Combine(currentTask.Destination, currentTask.FileName);
                                    File.Move(extractedFile, newFileName);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"exception: {ex.Message.ToString()}");
                    return false;
                }
                return true;
            }


        }
    }
}
