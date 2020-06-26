using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp;
using AngleSharp.Dom;
using Athena.Services;
using Athena.Models;
using System.Globalization;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Linq;
using System.Data.Entity;

namespace Athena
{
    public partial class frmFM : Form
    {
        private string saveFolderPath = string.Empty;
        private string TaskName = string.Empty;
        private string[] stringSeparators = new string[] { "\r\n" };
        Helper db = new Helper();
        public frmFM()
        {
            InitializeComponent();
            progressBarTask1.Minimum = 0;
            progressBarTask1.Maximum = 100;
            progressBarTask1.Value = 0;
            btnDownload.Enabled = false;

            populateTaskList();
        }

        private void populateTaskList()
        {
            clbTaskList.Items.Clear();
            var items = db.DownloadTasks.ToArray();
            clbTaskList.Items.AddRange(items.Select(a => a.Name).ToArray());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult d = saveToFile.ShowDialog();
            saveFolderPath = saveToFile.FileName;
            tbSaveFolderPath.Text = saveFolderPath;
        }

        private void tbSaveFolderPath_TextChanged(object sender, EventArgs e)
        {
            saveFolderPath = tbSaveFolderPath.Text;
            btnDownload.Enabled = true;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Downloading {TaskName} to {saveFolderPath}");
            var url = new Uri(tbSourceUrl.Text);
            Downloader d = new Downloader();
            var myPath = url.AbsolutePath.Split('/');
            myPath[myPath.Count() - 1] = myPath[myPath.Count() - 1].Replace(".zip", ".csv");

            var FileNameAfterUnZip = $"D:\\Desktop\\Stocks\\{myPath[myPath.Count() - 1]}";
            d.File(new Models.FileDownloads
            {
                SourceURL = url.AbsoluteUri,
                Destination = @"D:\Desktop\Stocks",
                FileNameAfterUnZip = FileNameAfterUnZip,
                URIWithFileName = url.AbsoluteUri
            });
            for (int i = 1; i <= 100; i++)
            {
                progressBarTask1.Value = i;
            }

        }

        private void tbTaskName_TextChanged(object sender, EventArgs e)
        {
            TaskName = tbTaskName.Text;
            groupBoxTask1.Text = TaskName;
        }

        private void clbTaskList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TaskName = clbTaskList.SelectedItem.ToString();
            var d = db.DownloadTasks
                .Include(a => a.Link)
                .SingleOrDefault(g => g.Name.ToLower().Trim().Contains(TaskName.ToLower().Trim()));

            if (d != null)
            {
                nmTaskId.Text = d.Id.ToString();
                tbTaskName.Text = d.Name;
                tbSourceUrl.Text = d.Link.SourceURL;
                tbUrlFormat.Text = d.Link.FormattedURL;
                tbTaskName_TextChanged(this, new EventArgs { });
            }
            progressBarTask1.Value = 0;
        }




        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            var itemCount = clbTaskList.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                clbTaskList.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            var itemCount = clbTaskList.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                clbTaskList.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void btnSelectInvert_Click(object sender, EventArgs e)
        {
            var itemCount = clbTaskList.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                if (clbTaskList.GetItemChecked(i))
                {
                    clbTaskList.SetItemCheckState(i, CheckState.Unchecked);
                }
                else
                {
                    clbTaskList.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void clbTaskList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
                //var a = e.Data.GetData(DataFormats.Text).ToString();
                //tbSourceUrl.Text = a;
                //tbUrlFormat.Text = URLParser.Tokenize(new Uri(a));
                //MessageBox.Show($"Drag and drop of {a}");

                //var htmlFragment = e.Data.GetData(DataFormats.Html).ToString().Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                //var source = htmlFragment[8];
                //retrieveBrowserData(source);
                ////var testing = TestOfDragDropFormats(e);
            }
            else
            {
                e.Effect = DragDropEffects.None;
                MessageBox.Show("Invalid type for drag and drop.");
            }
        }


        private string TestOfDragDropFormats(DragEventArgs e)
        {

            Array data = ((IDataObject)e.Data).GetFormats() as Array;

            StringBuilder sb = new StringBuilder();


            foreach (var item in data)
            {
                string dataFormat = item.ToString();
                sb.Append(dataFormat);
                sb.Append(", ");
                var abc = ((IDataObject)e.Data).GetData(item.ToString());
                Debug.WriteLine($"{dataFormat} : {abc}");

            }
            string allowedformats = sb.ToString();
            Debug.WriteLine(allowedformats);
            return allowedformats;
        }

        private async Task retrieveBrowserData(string source)
        {
            //Use the default configuration for AngleSharp
            var config = Configuration.Default;

            //Create a new context for evaluating webpages with the given config
            var context = BrowsingContext.New(config);

            //Just get the DOM representation
            //var document = await context.OpenAsync(req => req.Content(source) );
            var document = await context.OpenAsync(req => req.Content(source));
            tbTaskName.Text = document.DocumentElement.QuerySelector("a").Text().ToString();



            //Serialize it back to the console
            Console.WriteLine(document.DocumentElement.OuterHtml);
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            clbTaskList.Items.Remove(clbTaskList.SelectedItems);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            bool isExistingTask = Int32.TryParse(nmTaskId.Text,out int TaskId);
            var TaskName = tbTaskName.Text.Trim();
            if (isExistingTask)
            {
                var records = db.DownloadTasks.Include(b => b.Link).Include(c => c.Exchange).Where(a => a.Id==TaskId);
                int count = records.Count();
                //Modify this record.
                if (count > 0)
                {
                    DownloadTask record = records.FirstOrDefault();
                    record.Name = TaskName;
                    record.Link.SourceURL = tbSourceUrl.Text.Trim();
                    record.Link.FormattedURL = tbUrlFormat.Text.Trim();
                    record.Link.Destination = tbSaveFolderPath.Text.Trim();
                    db.SaveChanges();
                }
            }
            else
            {
                //Add a new record with this TaskName.
                Link l = new Link
                {
                    Name = $"{TaskName} Link",
                    SourceURL = tbSourceUrl.Text.ToLower().Trim(),
                    FormattedURL = tbUrlFormat.Text.Trim(),
                    Destination = tbSaveFolderPath.Text.Trim(),
                    DestinationFormat = tbSaveFolderPath.Text.Trim()
                };
                db.Links.Add(l);
                Exchange exchange = new Exchange();
                if (l.SourceURL.ToLower().Contains("nseindia"))
                {
                    exchange = db.Exchanges.SingleOrDefault(x => x.Name == "NSE");
                }
                else if (l.SourceURL.ToLower().Contains("bseindia"))
                {
                    exchange = db.Exchanges.SingleOrDefault(x => x.Name == "BSE");
                }
                else
                {
                    exchange = new Exchange { Name = l.SourceURL };
                    db.Exchanges.Add(exchange);
                    db.SaveChanges();
                }
                db.SaveChanges();
                DownloadTask dt = new DownloadTask
                {
                    Name = TaskName,
                    LinkId = l.Id,
                    ExchangeId = exchange.Id
                };
                db.DownloadTasks.Add(dt);
                db.SaveChanges();
            }
            
            populateTaskList();

        }

        private void clbTaskList_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
                nmTaskId.Text = string.Empty;
                var a = e.Data.GetData(DataFormats.Text).ToString();
                tbSourceUrl.Text = a;
                tbUrlFormat.Text = URLParser.Tokenize(new Uri(a));
                MessageBox.Show($"Drag and drop of {a}");

                var htmlFragment = e.Data.GetData(DataFormats.Html).ToString().Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                var source = htmlFragment[8];
                retrieveBrowserData(source);
                //var testing = TestOfDragDropFormats(e);
            }
            else
            {
                e.Effect = DragDropEffects.None;
                MessageBox.Show("Invalid type for drag and drop.");
            }
        }

        private void btnRemoveThisTaskfromTaskList_Click(object sender, EventArgs e)
        {

        }
    }
}
