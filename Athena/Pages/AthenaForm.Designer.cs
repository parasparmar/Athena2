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
            label8 = new Label();
            btnReset = new Button();
            btnRemoveTask = new Button();
            btnSelectInvert = new Button();
            btnSelectNone = new Button();
            btnSelectAll = new Button();
            clbTaskList = new CheckedListBox();
            groupBoxTask1 = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            nmTaskId = new NumericUpDown();
            btnRemoveThisTaskfromTaskList = new Button();
            progressBarTask1 = new ProgressBar();
            btnAddTask = new Button();
            tbTaskName = new TextBox();
            btnManualTokens = new Button();
            btnBrowse = new Button();
            tbTaskStatus = new TextBox();
            tbDestinationFormat = new TextBox();
            tbUrlFormat = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            tbSaveFolderPath = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbpSettings = new TabPage();
            saveToFile = new SaveFileDialog();
            fbDownloadLocation = new FolderBrowserDialog();
            tab.SuspendLayout();
            tbpDownload.SuspendLayout();
            groupBoxTask1.SuspendLayout();
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
            tbpDownload.Controls.Add(label8);
            tbpDownload.Controls.Add(btnReset);
            tbpDownload.Controls.Add(btnRemoveTask);
            tbpDownload.Controls.Add(btnSelectInvert);
            tbpDownload.Controls.Add(btnSelectNone);
            tbpDownload.Controls.Add(btnSelectAll);
            tbpDownload.Controls.Add(clbTaskList);
            tbpDownload.Controls.Add(groupBoxTask1);
            tbpDownload.Location = new Point(4, 24);
            tbpDownload.Margin = new Padding(4, 3, 4, 3);
            tbpDownload.Name = "tbpDownload";
            tbpDownload.Padding = new Padding(4, 3, 4, 3);
            tbpDownload.Size = new Size(1130, 394);
            tbpDownload.TabIndex = 0;
            tbpDownload.Text = "Download";
            tbpDownload.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 13);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 10;
            label8.Text = "SELECT";
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
            // groupBoxTask1
            // 
            groupBoxTask1.Controls.Add(label10);
            groupBoxTask1.Controls.Add(label9);
            groupBoxTask1.Controls.Add(dtpToDate);
            groupBoxTask1.Controls.Add(dtpFromDate);
            groupBoxTask1.Controls.Add(nmTaskId);
            groupBoxTask1.Controls.Add(btnRemoveThisTaskfromTaskList);
            groupBoxTask1.Controls.Add(progressBarTask1);
            groupBoxTask1.Controls.Add(btnAddTask);
            groupBoxTask1.Controls.Add(tbTaskName);
            groupBoxTask1.Controls.Add(btnManualTokens);
            groupBoxTask1.Controls.Add(btnBrowse);
            groupBoxTask1.Controls.Add(tbTaskStatus);
            groupBoxTask1.Controls.Add(btnDownload);
            groupBoxTask1.Controls.Add(tbDestinationFormat);
            groupBoxTask1.Controls.Add(tbUrlFormat);
            groupBoxTask1.Controls.Add(label4);
            groupBoxTask1.Controls.Add(tbSourceUrl);
            groupBoxTask1.Controls.Add(label6);
            groupBoxTask1.Controls.Add(label3);
            groupBoxTask1.Controls.Add(tbSaveFolderPath);
            groupBoxTask1.Controls.Add(label7);
            groupBoxTask1.Controls.Add(label5);
            groupBoxTask1.Controls.Add(label2);
            groupBoxTask1.Controls.Add(label1);
            groupBoxTask1.Location = new Point(374, 31);
            groupBoxTask1.Margin = new Padding(4, 3, 4, 3);
            groupBoxTask1.Name = "groupBoxTask1";
            groupBoxTask1.Padding = new Padding(4, 3, 4, 3);
            groupBoxTask1.Size = new Size(611, 355);
            groupBoxTask1.TabIndex = 7;
            groupBoxTask1.TabStop = false;
            groupBoxTask1.Text = "Task Name";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Location = new Point(443, 10);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 12;
            label10.Text = "To Date";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Location = new Point(285, 10);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 12;
            label9.Text = "From Date";
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
            // progressBarTask1
            // 
            progressBarTask1.Anchor = AnchorStyles.Top;
            progressBarTask1.Location = new Point(138, 283);
            progressBarTask1.Margin = new Padding(4, 3, 4, 3);
            progressBarTask1.Name = "progressBarTask1";
            progressBarTask1.Size = new Size(304, 23);
            progressBarTask1.TabIndex = 7;
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
            // tbTaskStatus
            // 
            tbTaskStatus.Anchor = AnchorStyles.Top;
            tbTaskStatus.Location = new Point(138, 253);
            tbTaskStatus.Margin = new Padding(4, 3, 4, 3);
            tbTaskStatus.Name = "tbTaskStatus";
            tbTaskStatus.ReadOnly = true;
            tbTaskStatus.Size = new Size(461, 23);
            tbTaskStatus.TabIndex = 2;
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
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Location = new Point(14, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 5;
            label4.Text = "Task Progress";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Location = new Point(14, 31);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 5;
            label6.Text = "Task Id";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Location = new Point(15, 62);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 5;
            label3.Text = "Task Name";
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
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Location = new Point(15, 219);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 5;
            label7.Text = "File Name Format";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Location = new Point(14, 157);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 5;
            label5.Text = "URL Format";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(14, 187);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 5;
            label2.Text = "Download Location";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(14, 126);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "Source URL";
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
            groupBoxTask1.ResumeLayout(false);
            groupBoxTask1.PerformLayout();
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
