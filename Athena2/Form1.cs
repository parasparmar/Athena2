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
using System.Collections;
using System.Globalization;

namespace Athena2
{
    public partial class frmDownloader : Form
    {

        string MyFolder = string.Empty;
        Engine MyEngine = new Engine();

        public frmDownloader()
        {
            InitializeComponent();
            tbLocation.Text = @"D:\Desktop\StockData";
        }
        private void dtpDate_ValueChanged()
        {
            DateTime temp = dtpToDate.Value;

            if (dtpFromDate.Value >= dtpToDate.Value)
            {
                dtpToDate.Value = dtpFromDate.Value;
                dtpFromDate.Value = temp;
            }

            // Day's Bhav Copies release at 16.38.
            if (dtpToDate.Value.Hour < 16 && dtpToDate.Value.Minute < 38)
            {
                dtpToDate.Value = dtpToDate.Value.AddDays(-1);
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
                    List<DateTime> MissingDates = MyEngine.getMissingDates(tbLocation.Text.ToString());
                    int i = 0;
                    foreach (DateTime IndividualDate in MissingDates)
                    {
                        dgv1.Rows.Add(1);
                        DataGridViewRow dr = dgv1.Rows[i];
                        dr.Cells["dgvtbDate"].Value = IndividualDate.ToShortDateString();
                        i++;
                    }


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



        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void tbFilesPath_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Standardize Formats takes the BSE Files, parses their contents so that only 
        /// scrips of type Q (Equity) remain. It appends the filename with _output.csv to differentiate
        /// the source and converted files.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStandardizeFormats_Click(object sender, EventArgs e)
        {



            //Convert each File in original location to new parsed file using BSEPARSER. Delete original, keep new.
            //Get Path to Scan.
            string FolderToScan = Path.GetFullPath(tbLocation.Text);

            if (FolderToScan.Length > 0)
            {
                //Check How many confirm to the BSE Equity Pattern
                IEnumerable<string> BSE_Dir = Directory.EnumerateDirectories(FolderToScan, "*bse*eq*", SearchOption.AllDirectories);
                int i = 0;
                foreach (string dir in BSE_Dir)
                {
                    //If Backup is checked, copy/backup the files to a peer folder suffixed with _Backup
                    DirectoryInfo d = new DirectoryInfo(dir);
                    //string backupLocation = d.Parent.FullName;
                    //string backupFile = d.Name;
                    string backupFullPath = d.Parent.FullName + Path.DirectorySeparatorChar + d.Name + "_backup";
                    if (!Directory.Exists(backupFullPath)) { Directory.CreateDirectory(backupFullPath); }


                    //List<string> BSE_InputFiles = new List<string>();
                    //BSE_InputFiles.AddRange(Directory.GetFiles(dir, "*.csv"));
                    //DateTime dtFile;
                    //foreach (var file in BSE_InputFiles)
                    //{
                    //    if (!DateTime.TryParseExact(file.Replace(".csv", ""), "yyyymmdd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dtFile))
                    //    {
                    //        BSE_InputFiles.Remove(file + ".csv");
                    //    }
                    //}

                    //// The Output path is where the input files should be backed up.
                    ////String OutputDirectory = Directory.CreateDirectory(Path.GetDirectoryName(InputFile) + Path.DirectorySeparatorChar + "backup").ToString();    
                    //DirectoryInfo d = new DirectoryInfo(dir);
                    //if (i == 0)
                    //{
                    //    d = Directory.CreateDirectory(Directory.GetParent(dir).FullName.ToString() + Path.DirectorySeparatorChar + Directory.GetParent(dir).Name+ " Backup");

                    //}
                    //else
                    //{
                    //    d = new DirectoryInfo(Directory.GetParent(dir).ToString() + Path.DirectorySeparatorChar + Directory.GetParent(dir).Name + " Backup");
                    //}
                    //string OutputDir = d.FullName;

                    //foreach (var f in BSE_InputFiles)
                    //{
                    //    BSE.BSEParser(f, OutputDir);
                    //}
                    //i++;
                }
            }


        }

        private void backupFiles(string PathToScan)
        {
            //Convert each File in original location to new parsed file using BSEPARSER. Delete original, keep new.
            //Get Path to Scan.
            string FolderToScan = Path.GetFullPath(PathToScan);

        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
