﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athena2
{
    class NSE : Exchange
    {

        string ServerFile_NameOnly = string.Empty;
        string ServerURI_WFileName = string.Empty;
        private string market = "NSE";
        private Task currentTask = new Task();

        public Task GetTask(DateTime individual_Day)
        {
            // Status : In Production 09 - 08 - 2014 13.20
            // This function takes in a datearray  and returns a dictionary of filenames and urls from which to download individual files.
            // The target URL is of the format http://www.nseindia.com/content/historical/EQUITIES/<YYYY>/<MMM>/cm<dd><MMM><yyyy>bhav.csv.zip
            // for eg : http://www.nseindia.com/content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip is a bhav copy for 31/Jul/2014
            ServerFile_NameOnly = "cm" + individual_Day.ToString("dd") + individual_Day.ToString("MMM").ToUpper() + individual_Day.ToString("yyyy").ToUpper() + "bhav.csv.zip";
            ServerURI_WFileName = "http://www.nseindia.com/content/historical/EQUITIES/" + individual_Day.Year.ToString() + "/" + individual_Day.ToString("MMM").ToUpper() + "/" + ServerFile_NameOnly;
            // 0. onDate = The date component of the associated downloaded file.
            currentTask.MyDate = individual_Day.Date;
            // 1. ServerURI_WFileName = The complete download path and file name
            currentTask.ServerURI_WFileName = ServerURI_WFileName;
            // 2. ServerFile_NameOnly = Only the file name of the downloaded file. It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the 
            // full path and file name of the local file.
            currentTask.ServerFile_NameOnly = ServerFile_NameOnly;
            // 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
            currentTask.LocalDeflatedFile_NameOnly = individual_Day.ToString("yyyyMMdd") + ".csv";
            // 4. MktBasedDownloadSubPath = The individual path to which each Market's file should be downloaded to.
            currentTask.MktBasedDownloadSubPath = market;
            return currentTask;
        }
    }
}