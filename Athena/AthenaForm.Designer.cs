using System.Resources;

namespace Athena
{
    partial class AthenaForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AthenaForm));
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbSourceUrl = new System.Windows.Forms.TextBox();
            this.tab = new System.Windows.Forms.TabControl();
            this.tbpDownload = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.btnSelectInvert = new System.Windows.Forms.Button();
            this.btnSelectNone = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.clbTaskList = new System.Windows.Forms.CheckedListBox();
            this.groupBoxTask1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.nmTaskId = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveThisTaskfromTaskList = new System.Windows.Forms.Button();
            this.progressBarTask1 = new System.Windows.Forms.ProgressBar();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.tbTaskName = new System.Windows.Forms.TextBox();
            this.btnManualTokens = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbTaskStatus = new System.Windows.Forms.TextBox();
            this.tbDestinationFormat = new System.Windows.Forms.TextBox();
            this.tbUrlFormat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSaveFolderPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpSettings = new System.Windows.Forms.TabPage();
            this.saveToFile = new System.Windows.Forms.SaveFileDialog();
            this.fbDownloadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.tab.SuspendLayout();
            this.tbpDownload.SuspendLayout();
            this.groupBoxTask1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTaskId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDownload.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDownload.Location = new System.Drawing.Point(118, 272);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(396, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // tbSourceUrl
            // 
            this.tbSourceUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSourceUrl.Location = new System.Drawing.Point(118, 106);
            this.tbSourceUrl.Name = "tbSourceUrl";
            this.tbSourceUrl.Size = new System.Drawing.Size(396, 20);
            this.tbSourceUrl.TabIndex = 2;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tbpDownload);
            this.tab.Controls.Add(this.tbpSettings);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(975, 366);
            this.tab.TabIndex = 3;
            // 
            // tbpDownload
            // 
            this.tbpDownload.AutoScroll = true;
            this.tbpDownload.Controls.Add(this.label8);
            this.tbpDownload.Controls.Add(this.btnReset);
            this.tbpDownload.Controls.Add(this.btnRemoveTask);
            this.tbpDownload.Controls.Add(this.btnSelectInvert);
            this.tbpDownload.Controls.Add(this.btnSelectNone);
            this.tbpDownload.Controls.Add(this.btnSelectAll);
            this.tbpDownload.Controls.Add(this.clbTaskList);
            this.tbpDownload.Controls.Add(this.groupBoxTask1);
            this.tbpDownload.Location = new System.Drawing.Point(4, 22);
            this.tbpDownload.Name = "tbpDownload";
            this.tbpDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDownload.Size = new System.Drawing.Size(967, 340);
            this.tbpDownload.TabIndex = 0;
            this.tbpDownload.Text = "Download";
            this.tbpDownload.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "SELECT";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(371, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(58, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(307, 6);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(58, 23);
            this.btnRemoveTask.TabIndex = 9;
            this.btnRemoveTask.Text = "Remove";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.BtnRemoveTask_Click);
            // 
            // btnSelectInvert
            // 
            this.btnSelectInvert.Location = new System.Drawing.Point(190, 6);
            this.btnSelectInvert.Name = "btnSelectInvert";
            this.btnSelectInvert.Size = new System.Drawing.Size(58, 23);
            this.btnSelectInvert.TabIndex = 9;
            this.btnSelectInvert.Text = "Invert";
            this.btnSelectInvert.UseVisualStyleBackColor = true;
            this.btnSelectInvert.Click += new System.EventHandler(this.BtnSelectInvert_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(126, 6);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(58, 23);
            this.btnSelectNone.TabIndex = 9;
            this.btnSelectNone.Text = "None";
            this.btnSelectNone.UseVisualStyleBackColor = true;
            this.btnSelectNone.Click += new System.EventHandler(this.BtnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(62, 6);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(58, 23);
            this.btnSelectAll.TabIndex = 9;
            this.btnSelectAll.Text = "All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // clbTaskList
            // 
            this.clbTaskList.AllowDrop = true;
            this.clbTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.clbTaskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbTaskList.CheckOnClick = true;
            this.clbTaskList.ColumnWidth = 500;
            this.clbTaskList.FormattingEnabled = true;
            this.clbTaskList.Location = new System.Drawing.Point(8, 34);
            this.clbTaskList.MultiColumn = true;
            this.clbTaskList.Name = "clbTaskList";
            this.clbTaskList.Size = new System.Drawing.Size(421, 302);
            this.clbTaskList.TabIndex = 8;
            this.clbTaskList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbTaskList_ItemCheck);
            this.clbTaskList.SelectedIndexChanged += new System.EventHandler(this.ClbTaskList_SelectedIndexChanged);
            this.clbTaskList.DragDrop += new System.Windows.Forms.DragEventHandler(this.ClbTaskList_DragDrop);
            this.clbTaskList.DragEnter += new System.Windows.Forms.DragEventHandler(this.ClbTaskList_DragEnter);
            // 
            // groupBoxTask1
            // 
            this.groupBoxTask1.Controls.Add(this.label10);
            this.groupBoxTask1.Controls.Add(this.label9);
            this.groupBoxTask1.Controls.Add(this.dtpToDate);
            this.groupBoxTask1.Controls.Add(this.dtpFromDate);
            this.groupBoxTask1.Controls.Add(this.nmTaskId);
            this.groupBoxTask1.Controls.Add(this.btnRemoveThisTaskfromTaskList);
            this.groupBoxTask1.Controls.Add(this.progressBarTask1);
            this.groupBoxTask1.Controls.Add(this.btnAddTask);
            this.groupBoxTask1.Controls.Add(this.tbTaskName);
            this.groupBoxTask1.Controls.Add(this.btnManualTokens);
            this.groupBoxTask1.Controls.Add(this.btnBrowse);
            this.groupBoxTask1.Controls.Add(this.tbTaskStatus);
            this.groupBoxTask1.Controls.Add(this.btnDownload);
            this.groupBoxTask1.Controls.Add(this.tbDestinationFormat);
            this.groupBoxTask1.Controls.Add(this.tbUrlFormat);
            this.groupBoxTask1.Controls.Add(this.label4);
            this.groupBoxTask1.Controls.Add(this.tbSourceUrl);
            this.groupBoxTask1.Controls.Add(this.label6);
            this.groupBoxTask1.Controls.Add(this.label3);
            this.groupBoxTask1.Controls.Add(this.tbSaveFolderPath);
            this.groupBoxTask1.Controls.Add(this.label7);
            this.groupBoxTask1.Controls.Add(this.label5);
            this.groupBoxTask1.Controls.Add(this.label2);
            this.groupBoxTask1.Controls.Add(this.label1);
            this.groupBoxTask1.Location = new System.Drawing.Point(435, 28);
            this.groupBoxTask1.Name = "groupBoxTask1";
            this.groupBoxTask1.Size = new System.Drawing.Size(524, 308);
            this.groupBoxTask1.TabIndex = 7;
            this.groupBoxTask1.TabStop = false;
            this.groupBoxTask1.Text = "Task Name";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "To Date";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(244, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "From Date";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(383, 25);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(132, 20);
            this.dtpToDate.TabIndex = 11;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(247, 25);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(131, 20);
            this.dtpFromDate.TabIndex = 10;
            // 
            // nmTaskId
            // 
            this.nmTaskId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nmTaskId.Enabled = false;
            this.nmTaskId.Location = new System.Drawing.Point(118, 25);
            this.nmTaskId.Name = "nmTaskId";
            this.nmTaskId.ReadOnly = true;
            this.nmTaskId.Size = new System.Drawing.Size(123, 20);
            this.nmTaskId.TabIndex = 9;
            // 
            // btnRemoveThisTaskfromTaskList
            // 
            this.btnRemoveThisTaskfromTaskList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemoveThisTaskfromTaskList.Location = new System.Drawing.Point(247, 77);
            this.btnRemoveThisTaskfromTaskList.Name = "btnRemoveThisTaskfromTaskList";
            this.btnRemoveThisTaskfromTaskList.Size = new System.Drawing.Size(131, 23);
            this.btnRemoveThisTaskfromTaskList.TabIndex = 8;
            this.btnRemoveThisTaskfromTaskList.Text = "Remove from Tasklist";
            this.btnRemoveThisTaskfromTaskList.UseVisualStyleBackColor = true;
            this.btnRemoveThisTaskfromTaskList.Click += new System.EventHandler(this.BtnRemoveThisTaskfromTaskList_Click);
            // 
            // progressBarTask1
            // 
            this.progressBarTask1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.progressBarTask1.Location = new System.Drawing.Point(118, 245);
            this.progressBarTask1.Name = "progressBarTask1";
            this.progressBarTask1.Size = new System.Drawing.Size(261, 20);
            this.progressBarTask1.TabIndex = 7;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddTask.Location = new System.Drawing.Point(118, 77);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(123, 23);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add to Tasklist";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // tbTaskName
            // 
            this.tbTaskName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTaskName.Location = new System.Drawing.Point(118, 51);
            this.tbTaskName.Name = "tbTaskName";
            this.tbTaskName.Size = new System.Drawing.Size(396, 20);
            this.tbTaskName.TabIndex = 2;
            this.tbTaskName.TextChanged += new System.EventHandler(this.TbTaskName_TextChanged);
            // 
            // btnManualTokens
            // 
            this.btnManualTokens.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnManualTokens.Location = new System.Drawing.Point(383, 77);
            this.btnManualTokens.Name = "btnManualTokens";
            this.btnManualTokens.Size = new System.Drawing.Size(131, 23);
            this.btnManualTokens.TabIndex = 6;
            this.btnManualTokens.Text = "Manual Tokens";
            this.btnManualTokens.UseVisualStyleBackColor = true;
            this.btnManualTokens.Click += new System.EventHandler(this.BtnManualTokens_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.Location = new System.Drawing.Point(384, 158);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(131, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // tbTaskStatus
            // 
            this.tbTaskStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbTaskStatus.Location = new System.Drawing.Point(118, 219);
            this.tbTaskStatus.Name = "tbTaskStatus";
            this.tbTaskStatus.ReadOnly = true;
            this.tbTaskStatus.Size = new System.Drawing.Size(396, 20);
            this.tbTaskStatus.TabIndex = 2;
            // 
            // tbDestinationFormat
            // 
            this.tbDestinationFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDestinationFormat.Location = new System.Drawing.Point(118, 187);
            this.tbDestinationFormat.Name = "tbDestinationFormat";
            this.tbDestinationFormat.Size = new System.Drawing.Size(396, 20);
            this.tbDestinationFormat.TabIndex = 2;
            // 
            // tbUrlFormat
            // 
            this.tbUrlFormat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbUrlFormat.Location = new System.Drawing.Point(118, 133);
            this.tbUrlFormat.Name = "tbUrlFormat";
            this.tbUrlFormat.Size = new System.Drawing.Size(396, 20);
            this.tbUrlFormat.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Task Progress";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Task Id";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Task Name";
            // 
            // tbSaveFolderPath
            // 
            this.tbSaveFolderPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSaveFolderPath.Location = new System.Drawing.Point(118, 159);
            this.tbSaveFolderPath.Name = "tbSaveFolderPath";
            this.tbSaveFolderPath.ReadOnly = true;
            this.tbSaveFolderPath.Size = new System.Drawing.Size(260, 20);
            this.tbSaveFolderPath.TabIndex = 3;
            this.tbSaveFolderPath.TextChanged += new System.EventHandler(this.TbSaveFolderPath_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "File Name Format";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "URL Format";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Download Location";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source URL";
            // 
            // tbpSettings
            // 
            this.tbpSettings.Location = new System.Drawing.Point(4, 22);
            this.tbpSettings.Name = "tbpSettings";
            this.tbpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSettings.Size = new System.Drawing.Size(967, 340);
            this.tbpSettings.TabIndex = 1;
            this.tbpSettings.Text = "Settings";
            this.tbpSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(975, 366);
            this.Controls.Add(this.tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Financial Markets - Data Downloader";
            this.tab.ResumeLayout(false);
            this.tbpDownload.ResumeLayout(false);
            this.tbpDownload.PerformLayout();
            this.groupBoxTask1.ResumeLayout(false);
            this.groupBoxTask1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTaskId)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox tbSourceUrl;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tbpDownload;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.TextBox tbSaveFolderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveToFile;
        private System.Windows.Forms.FolderBrowserDialog fbDownloadLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.GroupBox groupBoxTask1;
        private System.Windows.Forms.ProgressBar progressBarTask1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox clbTaskList;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelectInvert;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbUrlFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnManualTokens;
        private System.Windows.Forms.Button btnRemoveThisTaskfromTaskList;
        private System.Windows.Forms.NumericUpDown nmTaskId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTaskStatus;
        private System.Windows.Forms.TextBox tbDestinationFormat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}
