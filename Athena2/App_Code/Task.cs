using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena2
{
    public class Task
    {


        // 0. MyDate = The date component of the associated downloaded file.
        public DateTime MyDate;
            // 1. URIWithFileName = The complete download path and file name
            public String URIWithFileName;
            // 2. FileNameOnServer = Only the file name of the downloaded file.It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the full path and file name of the local file.
            public String FileNameOnServer;
            // 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
            public String FileNameAfterUnZip;
            // 4. MarketFolder = Needed to segregate the Deflated(unzipped) file into a folder represented by it's Market.
            public String MarketFolder;

        
    }
}
