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

        
    }
}
