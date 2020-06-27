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
using Athena.ViewModels;
using System.Globalization;
using System.Data.SQLite.EF6;
using System.Data.SQLite.Linq;
using System.Data.Entity;
using System.Drawing.Text;
using System.Web;

namespace Athena
{
    public partial class frmFM : Form
    {
        private string saveFolderPath = string.Empty;
        private string TaskName = string.Empty;
        private string[] stringSeparators = new string[] { "\r\n" };
        private List<MyDownloadTask> tasks = new List<MyDownloadTask>();

        Helper db = new Helper();
        public frmFM()
        {
            InitializeComponent();
            progressBarTask1.Minimum = 0;
            progressBarTask1.Maximum = 100;
            progressBarTask1.Value = 0;
            btnDownload.Enabled = false;

            tasks = FMViewModel.GetTaskList();
            PopulateTaskList(tasks);
        }



        private void PopulateTaskList(List<MyDownloadTask> tasks)
        {
            if (tasks != null)
            {
                clbTaskList.Items.Clear();
                clbTaskList.Items.AddRange(tasks.Select(a => a.TaskName).ToArray());
            }
            else
            {
                clbTaskList.Items.Clear();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult d = fbDownloadLocation.ShowDialog();
            fbDownloadLocation.ShowNewFolderButton = true;
            saveFolderPath = fbDownloadLocation.SelectedPath;
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
            Downloader d = new Downloader();
            var selectedtasks = tasks.Where(b => b.Selected == true).ToList();
            int count = selectedtasks.Count();
            for (int i = 0; i < count; i++)
            {

                d.File(new Models.FileDownloads
                {
                    SourceURL = selectedtasks[i].SourceUrl,
                    DownloadFolder = selectedtasks[i].DownloadLocation,
                    FileNameAfterUnZip = URLParser.getDestinationFileName(selectedtasks[i].SourceUrl, selectedtasks[i].DownloadLocation),
                });
                progressBarTask1.Value = (int)((i / count) * 100);
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
            var d = tasks.SingleOrDefault(a => a.TaskName == TaskName);
            var destinationFormat = URLParser.Tokenize(d.SourceUrl);
            Uri destFormat = new Uri(destinationFormat);
            var f = destFormat.Segments;
            var fileFormat = HttpUtility.UrlDecode(f[f.Length - 1]);
            

            if (d != null)
            {
                nmTaskId.Value = d.TaskId;
                tbTaskName.Text = d.TaskName;
                tbSourceUrl.Text = d.SourceUrl;
                tbUrlFormat.Text = d.UrlFormat;
                tbTaskStatus.Text = d.TaskProgress;
                tbSaveFolderPath.Text = d.DownloadLocation;
                tbDestinationFormat.Text = fileFormat;
                tbTaskName_TextChanged(this, new EventArgs { });
            }
            progressBarTask1.Value = 0;
        }
        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            tasks.ForEach(a => selectTask(a));
            var itemCount = clbTaskList.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                clbTaskList.SetItemCheckState(i, CheckState.Checked);
            }

        }
        private void selectTask(MyDownloadTask s)
        {
            s.Selected = true;
        }
        private void unSelectTask(MyDownloadTask s)
        {
            s.Selected = false;
        }

        private void toggleSelectionOfTask(MyDownloadTask s)
        {
            s.Selected = s.Selected ? false : true;
        }
        private void btnSelectNone_Click(object sender, EventArgs e)
        {
            tasks.ForEach(a => unSelectTask(a));
            var itemCount = clbTaskList.Items.Count;
            for (int i = 0; i < itemCount; i++)
            {
                clbTaskList.SetItemCheckState(i, CheckState.Unchecked);
            }

        }

        private void btnSelectInvert_Click(object sender, EventArgs e)
        {
            tasks.ForEach(a => toggleSelectionOfTask(a));
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
            var myTask = new MyDownloadTask
            {
                TaskId = (int)nmTaskId.Value,
                TaskName = tbTaskName.Text.Trim(),
                SourceUrl = tbSourceUrl.Text.Trim(),
                UrlFormat = tbUrlFormat.Text.Trim(),
                DownloadLocation = tbSaveFolderPath.Text.Trim(),
                Selected = true
            };
            tasks = FMViewModel.AddOrUpdateTasks(myTask);
            PopulateTaskList(tasks);
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
            var taskId = (int)nmTaskId.Value;
            if (taskId > 0)
            {
                var a = FMViewModel.GetMyDownloadTaskById(taskId);
                tasks = FMViewModel.RemoveTasks(a);
                PopulateTaskList(tasks);
            }
        }

        private void btnManualTokens_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tasks = FMViewModel.GetTaskList();
            PopulateTaskList(tasks);
        }

        private void clbTaskList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var taskName = clbTaskList.Items[e.Index].ToString();
            var thisTask = tasks.SingleOrDefault(a => a.TaskName == taskName);

            // We receive the event before the item checking occurs. 
            // Hence the reverse condition is needed to ascertain if the item is checked.
            if (!clbTaskList.GetItemChecked(e.Index))
            {
                thisTask.Selected = true;
            }
            else
            {
                thisTask.Selected = false;
            }
        }
    }
}
