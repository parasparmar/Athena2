﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena.Models
{
    public class FileDownloads
    {

        public string Name { get; set; }
        // 0. MyDate = The date component of the associated downloaded file.
        public DateTime Date { get; set; }
        public string SourceURL { get; set; }
        public string URLFormat { get; set; }
        public string DownloadFolder { get; set; }

        // 1. URIWithFileName = The complete download path and file name
        public String URIWithFileName { get; set; }
        // 2. FileNameOnServer = Only the file name of the downloaded file.It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the full path and file name of the local file.
        public String FileNameOnServer { get; set; }
        // 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
        public String FileNameAfterUnZip { get; set; }
        // 4. MarketFolder = Needed to segregate the Deflated(unzipped) file into a folder represented by it's Market.
        public String Destination { get; set; }
    }
}
