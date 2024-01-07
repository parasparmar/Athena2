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
