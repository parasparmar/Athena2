using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Athena.Models;

namespace Athena.Services
{
    class DownloadTaskFactory
    {
        string ServerFile_NameOnly = string.Empty;
        string ServerURI_WFileName = string.Empty;
        private string market = "NSE-Equity";
        private DownloadTask currentTask = new DownloadTask();

        public DownloadTask CreateNSETask(DateTime individual_Day)
        {
            // Status : In Production 09 - 08 - 2014 13.20
            // This function takes in a datearray  and returns a dictionary of filenames and urls from which to download individual files.
            // The target URL is of the format http://www.nseindia.com/content/historical/EQUITIES/<YYYY>/<MMM>/cm<dd><MMM><yyyy>bhav.csv.zip
            // for eg : http://www.nseindia.com/content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip is a bhav copy for 31/Jul/2014
            // https://www.nseindia.com/content/historical/EQUITIES/2017/SEP/cm27SEP2017bhav.csv.zip
            ServerFile_NameOnly = "cm" + individual_Day.ToString("dd") + individual_Day.ToString("MMM").ToUpper() + individual_Day.ToString("yyyy").ToUpper() + "bhav.csv.zip";
            ServerURI_WFileName = "http://www.nseindia.com/content/historical/EQUITIES/" + individual_Day.Year.ToString() + "/" + individual_Day.ToString("MMM").ToUpper() + "/" + ServerFile_NameOnly;
            // 0. onDate = The date component of the associated downloaded file.
            currentTask.Date = individual_Day.Date;
            // 1. URIWithFileName = The complete download path and file name
            currentTask.URIWithFileName = ServerURI_WFileName;
            // 2. FileNameOnServer = Only the file name of the downloaded file. It will be concatenated with fbdDownloadLocation.SelectedPath to acheive the 
            // full path and file name of the local file.
            currentTask.FileNameOnServer = ServerFile_NameOnly;
            // 3. LocalFile_NameOnly = The eventually Deflated(unzipped) file name.
            currentTask.FileNameAfterUnZip = individual_Day.ToString("yyyyMMdd") + ".csv";
            // 4. MarketFolder = The individual path to which each Market's file should be downloaded to.
            currentTask.Destination = market;
            return currentTask;
        }

        // getURLFrom takes in a datearray  and returns a dictionary of filenames and urls from which to download individual files.
        public List<DownloadTask> CreateTaskList(List<String> MarketType, List<DateTime> DateList)
        {
            List<DownloadTask> TaskList = new List<DownloadTask>();
            // Status : In Production 09-08-2014 13.20
            foreach (string Market in MarketType)
            {
                foreach (DateTime Individual_Day in DateList)
                {
                    TaskList.Add(createTask(Market, Individual_Day));
                }
            }
            return TaskList;

        }

        private DownloadTask createTask(string market, DateTime individual_Day)
        {
            // The NSE Equity URL is of the format http://www.nseindia.com/content/historical/EQUITIES/<YYYY>/<MMM>/cm<dd><MMM><YYYY>bhav.csv.zip
            // for eg : http://www.nseindia.com/content/historical/EQUITIES/2014/JUL/cm31JUL2014bhav.csv.zip is a bhav copy for 31/Jul/2014
            // MyMarketsType A string consisting of a limited choice of available Markets and Instruments.
            // MyDate Any date which is not in the future.


            DownloadTask currentTask = new DownloadTask();


            switch (market)
            {
                case "NSE - Equity":
                    
                    currentTask = CreateNSETask(individual_Day);
                    break;

                case "BSE - Equity":
                    BSE A = new BSE();
                    currentTask = A.CreateBSETask(individual_Day);
                    break;

                case "AMFII - Mutual Funds":

                    // Main URL : http://www.amfiindia.com/nav-history-download
                    //GET / DownloadNAVHistoryReport_Po.aspx ? mf = 9 & frmdt = 01 - Jan - 1960 & todt = 25 - Jan - 2016 HTTP / 1.1
                    //Host:           portal.amfiindia.com
                    //                User - Agent: Mozilla / 5.0(Windows NT 10.0; WOW64; rv: 43.0) Gecko / 20100101 Firefox / 43.0
                    //Accept: Text / html, Application / xhtml + Xml, Application / Xml; q = 0.9,*/*;q=0.8
                    //Accept-Language: en-US, en;q=0.5
                    //Accept-Encoding: gzip, deflate
                    //DNT: 1
                    //Referer:        http : //www.amfiindia.com/nav-history-download
                    //Cookie:         __utma = 57940026.105457447.1448689042.1448981552.1453695335.6; __utmz=57940026.1448689042.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); __utmb=57940026.4.10.1453695335; __utmt=1; __utmc=57940026
                    //Connection:     keep-alive
                    //--------------- RESPONSE HEADERS---------------
                    // URL : http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?mf=9&frmdt=01-Jan-1960&todt=25-Jan-2016
                    //                HTTP/ 1.1 200 OK
                    //Cache-Control: no-Cache
                    //Pragma:         no-Cache
                    //Content-Type: Text/ plain
                    //Expires: -1
                    //Vary:           Accept-Encoding
                    //Server:         Microsoft-IIS / 8.5
                    //Set-Cookie: ASP.NET_SessionId = qgdwxu45dgbw4pnhrohc0c45; path=/; HttpOnly
                    //Content-Disposition: inline; filename=NAVHistoryReport250116.txt
                    //X-AspNet - Version:  2.0.50727
                    //X-Powered - By: ASP.NET
                    //                Date : Mon, 25 Jan 2016 04: 17:41 GMT
                    //Content-Length:  93076579
                    //--------------- RESPONSE BODY---------------
                    //HTTP/ 1.1 200 OK
                    //Cache-Control: no-Cache
                    //Pragma:         no-Cache
                    //Content-Type: Text/ plain
                    //Expires: -1
                    //Vary:           Accept-Encoding
                    //Server:         Microsoft-IIS / 8.5
                    //Set-Cookie: ASP.NET_SessionId = qgdwxu45dgbw4pnhrohc0c45; path=/; HttpOnly
                    //Content-Disposition: inline; filename=NAVHistoryReport250116.txt
                    //X-AspNet - Version:  2.0.50727
                    //X-Powered - By: ASP.NET
                    //Date : Mon, 25 Jan 2016 04: 17:41 GMT
                    //Content-Length:  93076579

                    //<select Class="select" id="NavDownMFName" name="NavDownMFName" onchange="return LoadNavHistoryDownload(&#39;0&#39;);"><option value="">--Select Mutual Fund--</option>
                    //<option value = "39" > ABN  AMRO Mutual Fund</Option>
                    //<option value = "50" > AEGON Mutual Fund</Option>
                    //<option value = "1" > Alliance Capital Mutual Fund</Option>
                    //<option value = "53" > Axis Mutual Fund</Option>
                    //<option value = "4" > Baroda Pioneer Mutual Fund</Option>
                    //<option value = "36" > Benchmark Mutual Fund</Option>
                    //<option value = "3" > Birla Sun Life Mutual Fund</Option>
                    //<option value = "59" > BNP Paribas Mutual Fund</Option>
                    //<option value = "46" > BOI AXA Mutual Fund</Option>
                    //<option value = "32" > Canara Robeco Mutual Fund</Option>
                    //<option value = "60" > Daiwa Mutual Fund</Option>
                    //<option value = "31" > DBS Chola Mutual Fund</Option>
                    //<option value = "38" > Deutsche Mutual Fund</Option>
                    //<option value = "58" > DHFL Pramerica Mutual Fund</Option>
                    //<option value = "6" > DSP BlackRock Mutual Fund</Option>
                    //<option value = "47" > Edelweiss Mutual Fund</Option>
                    //<option value = "13" > Escorts Mutual Fund</Option>
                    //<option value = "40" > Fidelity Mutual Fund</Option>
                    //<option value = "51" > Fortis Mutual Fund</Option>
                    //<option value = "27" > Franklin Templeton Mutual Fund</Option>
                    //<option value = "8" > GIC Mutual Fund</Option>
                    //<option value = "49" > Goldman Sachs Mutual Fund</Option>
                    //<option value = "9" > HDFC Mutual Fund</Option>
                    //<option value = "37" > HSBC Mutual Fund</Option>
                    //<option value = "20" > ICICI Prudential Mutual Fund</Option>
                    //<option value = "57" > IDBI Mutual Fund</Option>
                    //<option value = "48" > IDFC Mutual Fund</Option>
                    //<option value = "68" > IIFCL Mutual Fund (IDF)</Option>
                    //<option value = "62" > IIFL Mutual Fund</Option>
                    //<option value = "11" > IL&amp;F S Mutual Fund</Option>
                    //<option value = "65" > IL&amp;FS Mutual Fund (IDF)</Option>
                    //<option value = "63" > Indiabulls Mutual Fund</Option>
                    //<option value = "14" > ING Mutual Fund</Option>
                    //<option value = "16" > JM Financial Mutual Fund</Option>
                    //<option value = "43" > JPMorgan Mutual Fund</Option>
                    //<option value = "17" > Kotak Mahindra Mutual Fund</Option>
                    //<option value = "56" > L&amp;T Mutual Fund</Option>
                    //<option value = "18" > LIC NOMURA Mutual Fund</Option>
                    //<option value = "45" > Mirae Asset Mutual Fund</Option>
                    //<option value = "19" > Morgan Stanley Mutual Fund</Option>
                    //<option value = "55" > Motilal Oswal Mutual Fund</Option>
                    //<option value = "54" > Peerless Mutual Fund</Option>
                    //<option value = "44" > PineBridge Mutual Fund</Option>
                    //<option value = "34" > PNB Mutual Fund</Option>
                    //<option value = "64" > PPFAS Mutual Fund</Option>
                    //<option value = "10" > PRINCIPAL Mutual Fund</Option>
                    //<option value = "41" > Quantum Mutual Fund</Option>
                    //<option value = "21" > Reliance Mutual Fund</Option>
                    //<option value = "42" > Religare Invesco Mutual Fund</Option>
                    //<option value = "35" > Sahara Mutual Fund</Option>
                    //<option value = "22" > SBI Mutual Fund</Option>
                    //<option value = "52" > Shinsei Mutual Fund</Option>
                    //<option value = "67" > Shriram Mutual Fund</Option>
                    //<option value = "66" > SREI Mutual Fund (IDF)</Option>
                    //<option value = "2" > Standard Chartered Mutual Fund</Option>
                    //<option value = "24" > SUN F&amp;C Mutual Fund</Option>
                    //<option value = "33" > Sundaram Mutual Fund</Option>
                    //<option value = "25" > Tata Mutual Fund</Option>
                    //<option value = "26" > Taurus Mutual Fund</Option>
                    //<option value = "61" > Union KBC Mutual Fund</Option>
                    //<option value = "28" > UTI Mutual Fund</Option>
                    //<option value = "29" > Zurich India Mutual Fund</Option>
                    //</select>                 


                    //FileNameOnServer = "NAVHistoryReport" + individual_Day.ToString("ddmmyy") + ".txt";
                    //URIWithFileName = "http://portal.amfiindia.com/DownloadNAVHistoryReport_Po.aspx?mf=9+frmdt=" + individual_Day.ToString("dd-MMM-YYYY") + "+todt=" + individual_Day.ToString("dd-MMM-YYYY");

                    break;
                default:
                    break;

            }
            return currentTask;



        }

    }
}
