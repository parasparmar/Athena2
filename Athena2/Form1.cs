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

namespace Athena2
{
    public partial class frmDownloader : Form
    {
        string FolderBrowserDialog;
        string MyFolder = string.Empty;
        Engine MyEngine = new Engine();
        public frmDownloader()
        {
            InitializeComponent();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFromDate.Value < DateTime.Today && dtpToDate.Value <= DateTime.Today)
            {
                if (DateTime.Today.Hour >= 15)
                {
                    dtpToDate.Value = DateTime.Today.Date;
                }
                else
                {
                    dtpToDate.Value = DateTime.Today.AddDays(-1).Date;
                }
                tsStatusText.Text = "Please choose a From date before today" + dtpToDate.Value;
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

            Exchange Exc = new Exchange();
            List<DateTime> AllMyDates = new List<DateTime>();
            AllMyDates = Exc.DateListGenerator(dtpFromDate.Value, dtpToDate.Value);
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
                System.Diagnostics.Process.Start("explorer", tbDownloadLocation.Text.ToString());
                
            }

        }

        private void tbDownloadLocation_Click(object sender, EventArgs e)
        {

            //0. Request the user to select a folder (MyFolder) where the downloaded files will be kept
            fbdDownloadLocation.ShowNewFolderButton = true;
            if (fbdDownloadLocation.ShowDialog() == DialogResult.OK)
            {
                string MyFolder = fbdDownloadLocation.SelectedPath.ToString();
                MyEngine.LocalBasePathToDownload = MyFolder;

                if (Directory.Exists(MyFolder))
                {
                    tbDownloadLocation.Text = MyFolder;
                    btnDownload.Enabled = true;
                }
                else
                {
                    tbDownloadLocation.Text = "Please select the folder to download at.";
                }
            }

        }
    }
}

