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
            btnDownload = new Button();
            tbSourceUrl = new TextBox();
            tab = new TabControl();
            tbpDownload = new TabPage();
            lblSelect = new Label();
            btnReset = new Button();
            btnRemoveTask = new Button();
            btnSelectInvert = new Button();
            btnSelectNone = new Button();
            btnSelectAll = new Button();
            clbTaskList = new CheckedListBox();
            gbTaskDetails = new GroupBox();
            lblTodate = new Label();
            lblFromDate = new Label();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            nmTaskId = new NumericUpDown();
            btnRemoveThisTaskfromTaskList = new Button();
            btnAddTask = new Button();
            tbTaskName = new TextBox();
            btnManualTokens = new Button();
            btnBrowse = new Button();
            tbDestinationFormat = new TextBox();
            tbUrlFormat = new TextBox();
            lblTaskId = new Label();
            lblTaskName = new Label();
            tbSaveFolderPath = new TextBox();
            lblFileNameFormat = new Label();
            lblUrlFormat = new Label();
            lblDownloadLocation = new Label();
            lblSourceURL = new Label();
            tbpSettings = new TabPage();
            saveToFile = new SaveFileDialog();
            fbDownloadLocation = new FolderBrowserDialog();
            tab.SuspendLayout();
            tbpDownload.SuspendLayout();
            gbTaskDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmTaskId).BeginInit();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top;
            btnDownload.BackColor = Color.PaleGoldenrod;
            btnDownload.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnDownload.Location = new Point(138, 314);
            btnDownload.Margin = new Padding(4, 3, 4, 3);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(462, 27);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += BtnDownload_Click;
            // 
            // tbSourceUrl
            // 
            tbSourceUrl.Anchor = AnchorStyles.Top;
            tbSourceUrl.Location = new Point(138, 122);
            tbSourceUrl.Margin = new Padding(4, 3, 4, 3);
            tbSourceUrl.Name = "tbSourceUrl";
            tbSourceUrl.Size = new Size(461, 23);
            tbSourceUrl.TabIndex = 2;
            // 
            // tab
            // 
            tab.Controls.Add(tbpDownload);
            tab.Controls.Add(tbpSettings);
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Margin = new Padding(4, 3, 4, 3);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(1138, 422);
            tab.TabIndex = 3;
            // 
            // tbpDownload
            // 
            tbpDownload.AutoScroll = true;
            tbpDownload.Controls.Add(lblSelect);
            tbpDownload.Controls.Add(btnReset);
            tbpDownload.Controls.Add(btnRemoveTask);
            tbpDownload.Controls.Add(btnSelectInvert);
            tbpDownload.Controls.Add(btnSelectNone);
            tbpDownload.Controls.Add(btnSelectAll);
            tbpDownload.Controls.Add(clbTaskList);
            tbpDownload.Controls.Add(gbTaskDetails);
            tbpDownload.Location = new Point(4, 24);
            tbpDownload.Margin = new Padding(4, 3, 4, 3);
            tbpDownload.Name = "tbpDownload";
            tbpDownload.Padding = new Padding(4, 3, 4, 3);
            tbpDownload.Size = new Size(1130, 394);
            tbpDownload.TabIndex = 0;
            tbpDownload.Text = "Download";
            tbpDownload.UseVisualStyleBackColor = true;
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Location = new Point(9, 13);
            lblSelect.Margin = new Padding(4, 0, 4, 0);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new Size(45, 15);
            lblSelect.TabIndex = 10;
            lblSelect.Text = "SELECT";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(298, 171);
            btnReset.Margin = new Padding(4, 3, 4, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(68, 27);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.Location = new Point(298, 138);
            btnRemoveTask.Margin = new Padding(4, 3, 4, 3);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(68, 27);
            btnRemoveTask.TabIndex = 9;
            btnRemoveTask.Text = "Remove";
            btnRemoveTask.UseVisualStyleBackColor = true;
            btnRemoveTask.Click += BtnRemoveTask_Click;
            // 
            // btnSelectInvert
            // 
            btnSelectInvert.Location = new Point(298, 105);
            btnSelectInvert.Margin = new Padding(4, 3, 4, 3);
            btnSelectInvert.Name = "btnSelectInvert";
            btnSelectInvert.Size = new Size(68, 27);
            btnSelectInvert.TabIndex = 9;
            btnSelectInvert.Text = "Invert";
            btnSelectInvert.UseVisualStyleBackColor = true;
            btnSelectInvert.Click += BtnSelectInvert_Click;
            // 
            // btnSelectNone
            // 
            btnSelectNone.Location = new Point(298, 72);
            btnSelectNone.Margin = new Padding(4, 3, 4, 3);
            btnSelectNone.Name = "btnSelectNone";
            btnSelectNone.Size = new Size(68, 27);
            btnSelectNone.TabIndex = 9;
            btnSelectNone.Text = "None";
            btnSelectNone.UseVisualStyleBackColor = true;
            btnSelectNone.Click += BtnSelectNone_Click;
            // 
            // btnSelectAll
            // 
            btnSelectAll.Location = new Point(298, 39);
            btnSelectAll.Margin = new Padding(4, 3, 4, 3);
            btnSelectAll.Name = "btnSelectAll";
            btnSelectAll.Size = new Size(68, 27);
            btnSelectAll.TabIndex = 9;
            btnSelectAll.Text = "All";
            btnSelectAll.UseVisualStyleBackColor = true;
            btnSelectAll.Click += BtnSelectAll_Click;
            // 
            // clbTaskList
            // 
            clbTaskList.AllowDrop = true;
            clbTaskList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            clbTaskList.BorderStyle = BorderStyle.FixedSingle;
            clbTaskList.CheckOnClick = true;
            clbTaskList.ColumnWidth = 500;
            clbTaskList.FormattingEnabled = true;
            clbTaskList.Location = new Point(9, 39);
            clbTaskList.Margin = new Padding(4, 3, 4, 3);
            clbTaskList.MultiColumn = true;
            clbTaskList.Name = "clbTaskList";
            clbTaskList.Size = new Size(281, 344);
            clbTaskList.TabIndex = 8;
            clbTaskList.ItemCheck += ClbTaskList_ItemCheck;
            clbTaskList.SelectedIndexChanged += ClbTaskList_SelectedIndexChanged;
            clbTaskList.DragDrop += ClbTaskList_DragDrop;
            clbTaskList.DragEnter += ClbTaskList_DragEnter;
            // 
            // gbTaskDetails
            // 
            gbTaskDetails.Controls.Add(lblTodate);
            gbTaskDetails.Controls.Add(lblFromDate);
            gbTaskDetails.Controls.Add(dtpToDate);
            gbTaskDetails.Controls.Add(dtpFromDate);
            gbTaskDetails.Controls.Add(nmTaskId);
            gbTaskDetails.Controls.Add(btnRemoveThisTaskfromTaskList);
            gbTaskDetails.Controls.Add(btnAddTask);
            gbTaskDetails.Controls.Add(tbTaskName);
            gbTaskDetails.Controls.Add(btnManualTokens);
            gbTaskDetails.Controls.Add(btnBrowse);
            gbTaskDetails.Controls.Add(btnDownload);
            gbTaskDetails.Controls.Add(tbDestinationFormat);
            gbTaskDetails.Controls.Add(tbUrlFormat);
            gbTaskDetails.Controls.Add(tbSourceUrl);
            gbTaskDetails.Controls.Add(lblTaskId);
            gbTaskDetails.Controls.Add(lblTaskName);
            gbTaskDetails.Controls.Add(tbSaveFolderPath);
            gbTaskDetails.Controls.Add(lblFileNameFormat);
            gbTaskDetails.Controls.Add(lblUrlFormat);
            gbTaskDetails.Controls.Add(lblDownloadLocation);
            gbTaskDetails.Controls.Add(lblSourceURL);
            gbTaskDetails.Location = new Point(374, 31);
            gbTaskDetails.Margin = new Padding(4, 3, 4, 3);
            gbTaskDetails.Name = "gbTaskDetails";
            gbTaskDetails.Padding = new Padding(4, 3, 4, 3);
            gbTaskDetails.Size = new Size(611, 355);
            gbTaskDetails.TabIndex = 7;
            gbTaskDetails.TabStop = false;
            gbTaskDetails.Text = "Task Details";
            // 
            // lblTodate
            // 
            lblTodate.Anchor = AnchorStyles.Top;
            lblTodate.AutoSize = true;
            lblTodate.Location = new Point(443, 10);
            lblTodate.Margin = new Padding(4, 0, 4, 0);
            lblTodate.Name = "lblTodate";
            lblTodate.Size = new Size(46, 15);
            lblTodate.TabIndex = 12;
            lblTodate.Text = "To Date";
            // 
            // lblFromDate
            // 
            lblFromDate.Anchor = AnchorStyles.Top;
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new Point(285, 10);
            lblFromDate.Margin = new Padding(4, 0, 4, 0);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(62, 15);
            lblFromDate.TabIndex = 12;
            lblFromDate.Text = "From Date";
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(447, 29);
            dtpToDate.Margin = new Padding(4, 3, 4, 3);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(153, 23);
            dtpToDate.TabIndex = 11;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(288, 29);
            dtpFromDate.Margin = new Padding(4, 3, 4, 3);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(152, 23);
            dtpFromDate.TabIndex = 10;
            // 
            // nmTaskId
            // 
            nmTaskId.Anchor = AnchorStyles.Top;
            nmTaskId.Enabled = false;
            nmTaskId.Location = new Point(138, 29);
            nmTaskId.Margin = new Padding(4, 3, 4, 3);
            nmTaskId.Name = "nmTaskId";
            nmTaskId.ReadOnly = true;
            nmTaskId.Size = new Size(144, 23);
            nmTaskId.TabIndex = 9;
            // 
            // btnRemoveThisTaskfromTaskList
            // 
            btnRemoveThisTaskfromTaskList.Anchor = AnchorStyles.Top;
            btnRemoveThisTaskfromTaskList.Location = new Point(288, 89);
            btnRemoveThisTaskfromTaskList.Margin = new Padding(4, 3, 4, 3);
            btnRemoveThisTaskfromTaskList.Name = "btnRemoveThisTaskfromTaskList";
            btnRemoveThisTaskfromTaskList.Size = new Size(153, 27);
            btnRemoveThisTaskfromTaskList.TabIndex = 8;
            btnRemoveThisTaskfromTaskList.Text = "Remove from Tasklist";
            btnRemoveThisTaskfromTaskList.UseVisualStyleBackColor = true;
            btnRemoveThisTaskfromTaskList.Click += BtnRemoveThisTaskfromTaskList_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Anchor = AnchorStyles.Top;
            btnAddTask.Location = new Point(138, 89);
            btnAddTask.Margin = new Padding(4, 3, 4, 3);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(144, 27);
            btnAddTask.TabIndex = 8;
            btnAddTask.Text = "Add to Tasklist";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += BtnAddTask_Click;
            // 
            // tbTaskName
            // 
            tbTaskName.Anchor = AnchorStyles.Top;
            tbTaskName.Location = new Point(138, 59);
            tbTaskName.Margin = new Padding(4, 3, 4, 3);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(461, 23);
            tbTaskName.TabIndex = 2;
            // 
            // btnManualTokens
            // 
            btnManualTokens.Anchor = AnchorStyles.Top;
            btnManualTokens.Location = new Point(447, 89);
            btnManualTokens.Margin = new Padding(4, 3, 4, 3);
            btnManualTokens.Name = "btnManualTokens";
            btnManualTokens.Size = new Size(153, 27);
            btnManualTokens.TabIndex = 6;
            btnManualTokens.Text = "Manual Tokens";
            btnManualTokens.UseVisualStyleBackColor = true;
            btnManualTokens.Click += BtnManualTokens_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top;
            btnBrowse.Location = new Point(448, 182);
            btnBrowse.Margin = new Padding(4, 3, 4, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(153, 27);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // tbDestinationFormat
            // 
            tbDestinationFormat.Anchor = AnchorStyles.Top;
            tbDestinationFormat.Location = new Point(138, 216);
            tbDestinationFormat.Margin = new Padding(4, 3, 4, 3);
            tbDestinationFormat.Name = "tbDestinationFormat";
            tbDestinationFormat.Size = new Size(461, 23);
            tbDestinationFormat.TabIndex = 2;
            // 
            // tbUrlFormat
            // 
            tbUrlFormat.Anchor = AnchorStyles.Top;
            tbUrlFormat.Location = new Point(138, 153);
            tbUrlFormat.Margin = new Padding(4, 3, 4, 3);
            tbUrlFormat.Name = "tbUrlFormat";
            tbUrlFormat.Size = new Size(461, 23);
            tbUrlFormat.TabIndex = 2;
            // 
            // lblTaskId
            // 
            lblTaskId.Anchor = AnchorStyles.Top;
            lblTaskId.AutoSize = true;
            lblTaskId.Location = new Point(14, 31);
            lblTaskId.Margin = new Padding(4, 0, 4, 0);
            lblTaskId.Name = "lblTaskId";
            lblTaskId.Size = new Size(42, 15);
            lblTaskId.TabIndex = 5;
            lblTaskId.Text = "Task Id";
            // 
            // lblTaskName
            // 
            lblTaskName.Anchor = AnchorStyles.Top;
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(15, 62);
            lblTaskName.Margin = new Padding(4, 0, 4, 0);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(64, 15);
            lblTaskName.TabIndex = 5;
            lblTaskName.Text = "Task Name";
            // 
            // tbSaveFolderPath
            // 
            tbSaveFolderPath.Anchor = AnchorStyles.Top;
            tbSaveFolderPath.Location = new Point(138, 183);
            tbSaveFolderPath.Margin = new Padding(4, 3, 4, 3);
            tbSaveFolderPath.Name = "tbSaveFolderPath";
            tbSaveFolderPath.ReadOnly = true;
            tbSaveFolderPath.Size = new Size(303, 23);
            tbSaveFolderPath.TabIndex = 3;
            tbSaveFolderPath.TextChanged += TbSaveFolderPath_TextChanged;
            // 
            // lblFileNameFormat
            // 
            lblFileNameFormat.Anchor = AnchorStyles.Top;
            lblFileNameFormat.AutoSize = true;
            lblFileNameFormat.Location = new Point(15, 219);
            lblFileNameFormat.Margin = new Padding(4, 0, 4, 0);
            lblFileNameFormat.Name = "lblFileNameFormat";
            lblFileNameFormat.Size = new Size(101, 15);
            lblFileNameFormat.TabIndex = 5;
            lblFileNameFormat.Text = "File Name Format";
            // 
            // lblUrlFormat
            // 
            lblUrlFormat.Anchor = AnchorStyles.Top;
            lblUrlFormat.AutoSize = true;
            lblUrlFormat.Location = new Point(14, 157);
            lblUrlFormat.Margin = new Padding(4, 0, 4, 0);
            lblUrlFormat.Name = "lblUrlFormat";
            lblUrlFormat.Size = new Size(69, 15);
            lblUrlFormat.TabIndex = 5;
            lblUrlFormat.Text = "URL Format";
            // 
            // lblDownloadLocation
            // 
            lblDownloadLocation.Anchor = AnchorStyles.Top;
            lblDownloadLocation.AutoSize = true;
            lblDownloadLocation.Location = new Point(14, 187);
            lblDownloadLocation.Margin = new Padding(4, 0, 4, 0);
            lblDownloadLocation.Name = "lblDownloadLocation";
            lblDownloadLocation.Size = new Size(110, 15);
            lblDownloadLocation.TabIndex = 5;
            lblDownloadLocation.Text = "Download Location";
            // 
            // lblSourceURL
            // 
            lblSourceURL.Anchor = AnchorStyles.Top;
            lblSourceURL.AutoSize = true;
            lblSourceURL.Location = new Point(14, 126);
            lblSourceURL.Margin = new Padding(4, 0, 4, 0);
            lblSourceURL.Name = "lblSourceURL";
            lblSourceURL.Size = new Size(67, 15);
            lblSourceURL.TabIndex = 5;
            lblSourceURL.Text = "Source URL";
            // 
            // tbpSettings
            // 
            tbpSettings.Location = new Point(4, 24);
            tbpSettings.Margin = new Padding(4, 3, 4, 3);
            tbpSettings.Name = "tbpSettings";
            tbpSettings.Padding = new Padding(4, 3, 4, 3);
            tbpSettings.Size = new Size(1130, 394);
            tbpSettings.TabIndex = 1;
            tbpSettings.Text = "Settings";
            tbpSettings.UseVisualStyleBackColor = true;
            // 
            // AthenaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1138, 422);
            Controls.Add(tab);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AthenaForm";
            Text = "Financial Markets - Data Downloader";
            tab.ResumeLayout(false);
            tbpDownload.ResumeLayout(false);
            tbpDownload.PerformLayout();
            gbTaskDetails.ResumeLayout(false);
            gbTaskDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmTaskId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox tbSourceUrl;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tbpDownload;
        private System.Windows.Forms.TabPage tbpSettings;
        private System.Windows.Forms.TextBox tbSaveFolderPath;
        private System.Windows.Forms.Label lblDownloadLocation;
        private System.Windows.Forms.Label lblSourceURL;
        private System.Windows.Forms.SaveFileDialog saveToFile;
        private System.Windows.Forms.FolderBrowserDialog fbDownloadLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox tbTaskName;
        private System.Windows.Forms.GroupBox gbTaskDetails;
        private System.Windows.Forms.ProgressBar progressBarTask1;
        private System.Windows.Forms.CheckedListBox clbTaskList;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnSelectNone;
        private System.Windows.Forms.Button btnSelectInvert;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbUrlFormat;
        private System.Windows.Forms.Label lblUrlFormat;
        private System.Windows.Forms.Button btnManualTokens;
        private System.Windows.Forms.Button btnRemoveThisTaskfromTaskList;
        private System.Windows.Forms.NumericUpDown nmTaskId;
        private System.Windows.Forms.Label lblTaskId;        
        private System.Windows.Forms.TextBox tbDestinationFormat;
        private System.Windows.Forms.Label lblFileNameFormat;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblTodate;
    }
}
