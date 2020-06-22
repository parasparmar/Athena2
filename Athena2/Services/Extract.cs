using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;
using System.IO;

namespace Athena.Services
{
    class Extract
    {              
        public static string ZipExtracttoFile(MemoryStream strm, string strDestDir)
        {
            String ExtractedFileName;
            try
            {
                using (ZipFile zip = ZipFile.Read(strm))
                {
                    ExtractedFileName = zip.EntryFileNames.ToString();
                    zip.ExtractExistingFile = ExtractExistingFileAction.OverwriteSilently;
                    foreach (ZipEntry e in zip)
                    {
                        e.Extract(strDestDir);
                        ExtractedFileName = e.FileName.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"exception: {ex.Message.ToString()}");
                return false.ToString();
            }
            return ExtractedFileName;
        }
    }
}
