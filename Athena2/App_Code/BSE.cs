using System;
using System.Linq;
using CsvHelper.Configuration;
using System.IO;
using CsvHelper;
using System.Collections;
using System.Collections.Generic;
using Athena.Models;

namespace Athena
{
    class BSE : Exchange
    {
        string ServerFile_NameOnly = string.Empty;
        string ServerURI_WFileName = string.Empty;
        public string market { get; set; } = "BSE-Equity";
        public static Stream OutputFile { get; private set; }
        public static string InputFile { get; private set; }

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
        public bool NeededHeaders(ref string[] AllHeadersInCSV)
        {
            bool result = true;
            string[] NeededHeaders = { "SC_CODE", "SC_NAME", "SC_TYPE", "OPEN", "HIGH", "LOW", "CLOSE", "NO_OF_SHRS" };
            foreach (string header in NeededHeaders)
            {
                result = result && AllHeadersInCSV.Contains<string>(header);
            }
            AllHeadersInCSV = NeededHeaders;
            return result;
        }
        public static void BSEParser(string InputFile, string OutputDir)
        {
            if (File.Exists(InputFile))
            {
                String OutputFile = OutputDir + Path.GetFileName(InputFile);
                using (var sr = new StreamReader(InputFile))
                {

                }

            }
        }
        public static void BSEParser(string InputPath)
        {
            if (File.Exists(InputPath))
            {
                //InputPath = @"D:\Desktop\StockData\BSE-Equity\20170925.csv";
                string OutputPath = Path.GetDirectoryName(InputPath) + Path.DirectorySeparatorChar + Path.GetFileNameWithoutExtension(InputPath) + "_output.csv";
                using (var sr = new StreamReader(InputPath))
                {
                    using (var sw = new StreamWriter(OutputFile))
                    {
                        var reader = new CsvReader((IParser)sr);
                        var writer = new CsvWriter((ISerializer)sw);
                        DateTime TheDate;
                        if (DateTime.TryParseExact(Path.GetFileNameWithoutExtension(InputFile), "yyyyMdd", null, System.Globalization.DateTimeStyles.AssumeLocal, out TheDate))
                        {
                            reader.Configuration.HeaderValidated = null;
                            reader.Configuration.MissingFieldFound = null;
                            //CSVReader will now read the whole file into an enumerable
                            IEnumerable records = reader.GetRecords<BSEHeaders>().Where(i => i.SC_TYPE == "Q").ToList();

                            //Write the entire contents of the CSV file into another
                            //writer.WriteRecords(records);


                            //Now we will write the data into the same output file but will do it 
                            //Using two methods.  The first is writing the entire record.  The second
                            //method writes individual fields.  Note you must call NextRecord method after 
                            //using Writefield to terminate the record.

                            //Note that WriteRecords will write a header record for you automatically.  If you 
                            //are not using the WriteRecords method and you want to a header, you must call the 
                            //Writeheader method like the following:
                            //
                            writer.WriteHeader<BSEHeaders>();
                            writer.NextRecord();
                            //
                            //Do not use WriteHeader as WriteRecords will have done that already.
                            string DateString = TheDate.ToString("yyyyMMdd");
                            foreach (BSEHeaders record in records)
                            {
                                //write record field by field
                                writer.WriteField(record.SC_CODE);
                                writer.WriteField(record.SC_NAME);
                                //writer.WriteField(record.SC_TYPE);
                                record.DATE = DateString;
                                writer.WriteField(record.DATE);
                                writer.WriteField(record.OPEN);
                                writer.WriteField(record.HIGH);
                                writer.WriteField(record.LOW);
                                writer.WriteField(record.CLOSE);
                                writer.WriteField(record.NO_OF_SHRS);
                                //ensure you write end of record when you are using WriteField method
                                writer.NextRecord();
                            }
                        }
                    }
                }
            }
        }
    }


}