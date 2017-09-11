using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena2
{
    class BSE : Exchange
    {
        string ServerFile_NameOnly = string.Empty;
        string ServerURI_WFileName = string.Empty;
        private string market = "BSE-Equity";
        private Task currentTask = new Task();


        public Task GetTask(DateTime individual_Day)
        {

            // BSE India Bhav Copy http://www.bseindia.com/download/BhavCopy/Equity/EQ141015_CSV.ZIP
            // http://www.bseindia.com/download/BhavCopy/Equity/EQ160817_CSV.ZIP
            // http://www.bseindia.com/download/BhavCopy/Equity/EQ_ISINCODE_160817.zip
            // BSE India Bhav Copy Prototype http://www.bseindia.com/download/BhavCopy/Equity/EQ<DD><MM><YY>_CSV.ZIP
            // Derivatives http://www.bseindia.com/download/Bhavcopy/Derivative/bhavcopy18-08-14.zip
            // http://www.bseindia.com/download/Bhavcopy/Derivative/bhavcopy16-08-17.zip
            // Equities http://www.bseindia.com/download/BhavCopy/Equity/EQ180814_CSV.ZIP
            // BSE India Bhav Copy http://www.bseindia.com/download/BhavCopy/Equity/EQ141015_CSV.ZIP
            string ServerFile_NameOnly = string.Empty;
            string ServerURI_WFileName = string.Empty;
            ServerFile_NameOnly = "EQ" + individual_Day.ToString("dd") + individual_Day.ToString("MM").ToUpper() + individual_Day.ToString("yy").ToUpper() + "_CSV.zip";
            ServerURI_WFileName = "http://www.bseindia.com/download/BhavCopy/Equity/" + ServerFile_NameOnly;


            // 0. onDate = The date component of the associated downloaded file.
            currentTask.MyDate = individual_Day.Date;
            // 1. URIWithFileName = The complete download path and file name
            currentTask.URIWithFileName = ServerURI_WFileName;
            // 2. FileNameOnServer = Only the file name of the downloaded file. It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the 
            // full path and file name of the local file.
            currentTask.FileNameOnServer = ServerFile_NameOnly;
            // 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
            currentTask.FileNameAfterUnZip = individual_Day.ToString("yyyyMMdd") + ".csv";
            // 4. MarketFolder = The individual path to which each Market's file should be downloaded to.
            currentTask.MarketFolder = market;
            return currentTask;

        }
    }
}
