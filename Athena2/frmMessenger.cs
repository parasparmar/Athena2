using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athena
{
    public partial class frmMessenger : Form
    {
        private string saveFolderPath = string.Empty;
        private string TaskName = string.Empty;

        public frmMessenger()
        {
            InitializeComponent();
            progressBarTask1.Minimum = 0;
            progressBarTask1.Maximum = 100;
            progressBarTask1.Value = 0;
            btnDownload.Enabled = false;
        }

        private void btnSaveFolder_Click(object sender, EventArgs e)
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
            tbTaskName.Text = TaskName;
            tbTaskName_TextChanged(this, new EventArgs { });
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
                var a = e.Data.GetData(DataFormats.Text).ToString();
                MessageBox.Show($"Drag and drop of {a}");

            }
            else
            {
                e.Effect = DragDropEffects.None;
                MessageBox.Show("Invalid type for drag and drop.");
            }
        }
    }
}
