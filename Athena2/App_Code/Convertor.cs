using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;

namespace Athena2.App_Code
{
    class Convertor
    {
        /**
         The Convertor handles the conversion of the downloaded files to an output format more suitable for the end users analytics.
            To convert to a CSV format, the user needs to decide on a few important points.
            A. What columns and in which order does he need them? for eg: certain programs need the format in the order below.
            Date, Symbol, Open, High, Low, Close, Volume, Open Interest.

            B.Does he need a single file per date or a single file per symbol?
            C. What seperator does he need? comma, semi colon, tab, etc....
            D. What's the string qualifier?
            E. Should the settings be saved to an XML file?
            F. What's the output path and what happens to the existing files.
             
             */
        public string MyPath
        {
            get { return MyPath; }
            set
            {
                if (File.Exists(value)) { MyPath = value; } else { return; }

            }


        }
        
            

    }
}
