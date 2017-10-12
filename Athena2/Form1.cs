using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper;

namespace Athena2
{
    public partial class frmDownloader : Form
    {

        string MyFolder = string.Empty;
        Engine MyEngine = new Engine();

        public frmDownloader()
        {
            InitializeComponent();
            dtpFromDate.MaxDate = DateTime.Today;
            dtpToDate.MaxDate = DateTime.Today.AddDays(1);
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime FromDate = dtpFromDate.Value;
            DateTime ToDate = dtpToDate.Value;
            if (FromDate > ToDate)
            {
                dtpFromDate.Value = ToDate;
                dtpToDate.Value = FromDate;
                FromDate = dtpFromDate.Value;
                ToDate = dtpToDate.Value;
            }
            // Day's Bhav Copies release at 16.38.
            if (ToDate.Hour < 16 && ToDate.Minute < 38)
            {
                dtpToDate.Value = DateTime.Today.AddDays(-1);
            }

        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Reset From and To dates.
            dtpFromDate.Value = DateTime.Today.Date.AddDays(-1);
            dtpToDate.Value = DateTime.Today.Date;
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            // Objective: btnDownload_Click event handling needs to take as ibpute GUI decisions and 
            // download the same to the destination path.
            // Input : Download Destination, From and To Dates
            // Parameters : 
            // Output : ArrayList of Dates - strongly typed.
            // Status : Production
            // Production : 19-10-2015 17.55
            // Done 1: Collect the selected dates from clbFiles into an MyDatesArray
            // Done 2 :  Collect the selected markets from clbMarkets into a chosenMarketsArray
            // initiated 21-01-2015 17.12 and resolved 22-01-2016 10.46

            Exchange Ex = new Exchange();
            List<DateTime> AllMyDates = new List<DateTime>();
            //D:\Desktop\StockData
            AllMyDates = Ex.DateListGenerator(dtpFromDate.Value, dtpToDate.Value);
            if (AllMyDates.Count > 0)
            {
                //// DateList Generator gets an ArrayList of Weekday dates between the given from and to dates.
                List<string> chosenMarketsArray = new List<string>();
                foreach (var i in clbMarkets.CheckedItems)
                {
                    chosenMarketsArray.Add(i.ToString());
                }
                //Done 3: Check for Internet Connectivity                
                List<Task> T = new List<Task>();
                T = MyEngine.CreateTaskList(chosenMarketsArray, AllMyDates);
                MyEngine.DownloadTaskList(ref T);
                //// Done 5. On Download completion open MyFolder and show it to the user
                System.Diagnostics.Process.Start("explorer", tbLocation.Text.ToString());
            }
        }
        private void tbLocation_Click(object sender, EventArgs e)
        {

            //0. Request the user to select a folder (MyFolder) where the downloaded files will be kept
            fbdDownloadLocation.ShowNewFolderButton = true;
            if (fbdDownloadLocation.ShowDialog() == DialogResult.OK || tbLocation.Text.Length > 0)
            {
                string MyFolder = fbdDownloadLocation.SelectedPath.ToString();
                if (MyFolder.Length == 0) { MyFolder = tbLocation.Text; }
                MyEngine.LocalBasePathToDownload = MyFolder;
                if (Directory.Exists(MyFolder))
                {
                    tbLocation.Text = MyFolder;
                    btnDownload.Enabled = true;
                    tbFilesPath.Text = MyFolder;
                }
                else
                {
                    tbLocation.Text = "Please select the folder to download at.";
                }
            }

        }
        private void cbMissingDates_CheckedChanged(object sender, EventArgs e)
        {
            //tbLocation.Text = @"D:\Desktop\StockData";
            if (cbMissingDates.Checked == true && tbLocation.Text.Length > 1)
            {
                dtpToDate.Value = DateTime.Today.Date;
                dtpToDate.Enabled = false;
                if (tbLocation.Text.Length > 0)
                {
                    //List<DateTime> MissingDates = MyEngine.getMissingDates(tbLocation.Text.ToString());
                    //int i = 0;
                    //foreach (DateTime IndividualDate in MissingDates)
                    //{
                    //    dgvDetails.Rows.Add(1);
                    //    DataGridViewRow dr = dgvDetails.Rows[i];
                    //    dr.Cells["dgvtbDate"].Value = IndividualDate.ToShortDateString();
                    //    i++;
                    //}


                }

            }
        }
        private void tbCsvPath_TextChanged(object sender, EventArgs e)
        {
            fbdDownloadLocation.ShowDialog();
            string FolderToScan = Path.GetFullPath(fbdDownloadLocation.SelectedPath);
            List<string> Directories = Directory.EnumerateDirectories(FolderToScan).ToList<string>();
            List<string> Files = new List<string>();
            foreach (string Folder in Directories)
            {
                Files.AddRange(Directory.GetFiles(Folder, "*.csv").ToList<string>());
            }
            List<DateTime> FoundDates = new List<DateTime>();
            Files.AddRange(Directory.GetFiles(@"D:\Desktop\StockData\BSE - Equity", "*.csv").ToList<string>());



        }

        public void excelreader()
        {
            String myPath = @"D:\Desktop\StockData\BSE-Equity\20170925.csv";
            if (File.Exists(myPath))
            {
                CsvReader csv = new CsvReader(new StreamReader(myPath));

                if (csv.ReadHeader())
                {
                    string[] headers = csv.FieldHeaders;
                    BSE b = new BSE();
                    if (b.NeededHeaders(ref headers))
                    {
                        List<string> columns = headers.ToList<string>();
                        dgv1.Columns.Clear();
                        foreach (string col in headers)
                        {
                            dgv1.Columns.Add(col, col);

                        }
                        dgv1.DataSource = columns;
                    }

                }
            }
        }

        //public sealed class MyMap: CSVClassMap<NSE>

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string filename = @"D:\Desktop\StockData\NSE-Equity\20170925.csv";
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader textIn = new StreamReader(fs);
            //while (textIn.Peek() != -1)
            //{
            string row = textIn.ReadLine();
            string[] columns = row.Split(',');
            int columncount = columns.Length;
            foreach (string col in columns)
            {
                dgv1.Columns.Add(col, col);
            }

            for (int i = 0; i < 50; i++)
            {
                row = textIn.ReadLine();
                columns = row.Split(',');
                dgv1.Rows.Add();
                for (int j = 0; j < columncount; j++)
                {
                    dgv1.Rows[i].Cells[j].Value = columns[j];
                }
            }

            //}

        }

        private void tbFilesPath_TextChanged(object sender, EventArgs e)
        {
            fbdDownloadLocation.ShowDialog();
            string ScanFolder = Path.GetFullPath(fbdDownloadLocation.SelectedPath);
            List<string> Directories = Directory.EnumerateDirectories(ScanFolder).ToList<string>();
            List<string> Files = new List<string>();
            foreach (string Folder in Directories)
            {
                Files.AddRange(Directory.GetFiles(Folder, "*.csv").ToList<string>());
            }



        }

        class CSVConversion
        {
            public string Folder { get; set; }
            public string File { get; set; }
            public string column { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excelreader();
        }
    }
}
