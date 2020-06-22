namespace Athena
{
    partial class frmMessenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDownload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpDownload = new System.Windows.Forms.TabPage();
            this.clbTaskList = new System.Windows.Forms.CheckedListBox();
            this.groupBoxTask1 = new System.Windows.Forms.GroupBox();
            this.progressBarTask1 = new System.Windows.Forms.ProgressBar();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaveFolderPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelected = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpConvert = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.saveToFile = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tbpDownload.SuspendLayout();
            this.groupBoxTask1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(776, 300);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 20);
            this.textBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpDownload);
            this.tabControl1.Controls.Add(this.tbpConvert);
            this.tabControl1.Location = new System.Drawing.Point(8, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 355);
            this.tabControl1.TabIndex = 3;
            // 
            // tbpDownload
            // 
            this.tbpDownload.Controls.Add(this.clbTaskList);
            this.tbpDownload.Controls.Add(this.groupBoxTask1);
            this.tbpDownload.Controls.Add(this.btnDownload);
            this.tbpDownload.Location = new System.Drawing.Point(4, 22);
            this.tbpDownload.Name = "tbpDownload";
            this.tbpDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDownload.Size = new System.Drawing.Size(857, 329);
            this.tbpDownload.TabIndex = 0;
            this.tbpDownload.Text = "Download";
            this.tbpDownload.UseVisualStyleBackColor = true;
            // 
            // clbTaskList
            // 
            this.clbTaskList.FormattingEnabled = true;
            this.clbTaskList.Items.AddRange(new object[] {
            "NSE EOD Bhav Copy",
            "BSE EOD Bhav Copy",
            "NSE FnO Market Deliverables",
            "BSE FnO Market Deliverables",
            "NSE FNO Open Interest",
            "BSE FNO Open Interest",
            "NSE EOD Bhav Copy"});
            this.clbTaskList.Location = new System.Drawing.Point(7, 7);
            this.clbTaskList.Name = "clbTaskList";
            this.clbTaskList.Size = new System.Drawing.Size(268, 319);
            this.clbTaskList.TabIndex = 8;
            // 
            // groupBoxTask1
            // 
            this.groupBoxTask1.Controls.Add(this.progressBarTask1);
            this.groupBoxTask1.Controls.Add(this.tbTaskName);
            this.groupBoxTask1.Controls.Add(this.btnSaveFolder);
            this.groupBoxTask1.Controls.Add(this.textBox1);
            this.groupBoxTask1.Controls.Add(this.label3);
            this.groupBoxTask1.Controls.Add(this.tbSaveFolderPath);
            this.groupBoxTask1.Controls.Add(this.label4);
            this.groupBoxTask1.Controls.Add(this.label2);
            this.groupBoxTask1.Controls.Add(this.cbSelected);
            this.groupBoxTask1.Controls.Add(this.label1);
            this.groupBoxTask1.Location = new System.Drawing.Point(281, 6);
            this.groupBoxTask1.Name = "groupBoxTask1";
            this.groupBoxTask1.Size = new System.Drawing.Size(570, 168);
            this.groupBoxTask1.TabIndex = 7;
            this.groupBoxTask1.TabStop = false;
            this.groupBoxTask1.Text = "Task Name";
            // 
            // progressBarTask1
            // 
            this.progressBarTask1.Location = new System.Drawing.Point(122, 131);
            this.progressBarTask1.Name = "progressBarTask1";
            this.progressBarTask1.Size = new System.Drawing.Size(433, 20);
            this.progressBarTask1.TabIndex = 7;
            // 
            // tbTaskName
            // 
            this.tbTaskName.Location = new System.Drawing.Point(122, 29);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(433, 20);
            this.tbTaskName.TabIndex = 2;
            this.tbTaskName.TextChanged += new System.EventHandler(this.tbTaskName_TextChanged);
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Location = new System.Drawing.Point(480, 80);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFolder.TabIndex = 6;
            this.btnSaveFolder.Text = "Save";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task Name";
            // 
            // tbSaveFolderPath
            // 
            this.tbSaveFolderPath.Location = new System.Drawing.Point(122, 82);
            this.tbSaveFolderPath.Name = "tbSaveFolderPath";
            this.tbSaveFolderPath.ReadOnly = true;
            this.tbSaveFolderPath.Size = new System.Drawing.Size(352, 20);
            this.tbSaveFolderPath.TabIndex = 3;
            this.tbSaveFolderPath.TextChanged += new System.EventHandler(this.tbSaveFolderPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Task Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Download Location";
            // 
            // cbSelected
            // 
            this.cbSelected.AutoSize = true;
            this.cbSelected.Checked = true;
            this.cbSelected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSelected.Location = new System.Drawing.Point(122, 108);
            this.cbSelected.Name = "cbSelected";
            this.cbSelected.Size = new System.Drawing.Size(76, 17);
            this.cbSelected.TabIndex = 4;
            this.cbSelected.Text = "Daily Task";
            this.cbSelected.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source URL";
            // 
            // tbpConvert
            // 
            this.tbpConvert.Location = new System.Drawing.Point(4, 22);
            this.tbpConvert.Name = "tbpConvert";
            this.tbpConvert.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConvert.Size = new System.Drawing.Size(857, 329);
            this.tbpConvert.TabIndex = 1;
            this.tbpConvert.Text = "Convert";
            this.tbpConvert.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 378);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMessenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 400);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMessenger";
            this.Text = "Financial Markets - Data Downloader";
            this.tabControl1.ResumeLayout(false);
            this.tbpDownload.ResumeLayout(false);
            this.groupBoxTask1.ResumeLayout(false);
            this.groupBoxTask1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpDownload;
        private System.Windows.Forms.TabPage tbpConvert;
        private System.Windows.Forms.TextBox tbSaveFolderPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbSelected;
        private System.Windows.Forms.SaveFileDialog saveToFile;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.GroupBox groupBoxTask1;
        private System.Windows.Forms.ProgressBar progressBarTask1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbTaskList;
    }
}