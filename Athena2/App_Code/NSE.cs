using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athena.Services;
using Athena.Models;

namespace Athena
{
    class NSE
    {
        string ServerFile_NameOnly = string.Empty;
        string ServerURI_WFileName = string.Empty;
        private string market = "NSE-Equity";
        private DownloadTask currentTask = new DownloadTask();
        
        public bool NeededHeaders(ref string[] AllHeadersInCSV)
        {
            bool result = true;
            string[] NeededHeaders = { "SYMBOL", "TIMESTAMP", "OPEN", "HIGH", "LOW", "CLOSE", "TOTTRDQTY" };
            foreach (string header in NeededHeaders)
            {
                result = result && AllHeadersInCSV.Contains<string>(header);
            }
            AllHeadersInCSV = NeededHeaders;
            return result;
        }

    }
    
}
