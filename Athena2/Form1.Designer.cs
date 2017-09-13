namespace Athena2
{
    partial class frmDownloader
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbCustomDelimiter = new System.Windows.Forms.TextBox();
            this.tbMetastockPath = new System.Windows.Forms.TextBox();
            this.tbExcelPath = new System.Windows.Forms.TextBox();
            this.tbCustomPath = new System.Windows.Forms.TextBox();
            this.tbCsvPath = new System.Windows.Forms.TextBox();
            this.CheckBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.lblDownloadPath = new System.Windows.Forms.Label();
            this.ofdSettings = new System.Windows.Forms.OpenFileDialog();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.clbMarkets = new System.Windows.Forms.CheckedListBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.tsStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDownloadData4Markets = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnDownload = new System.Windows.Forms.Button();
            this.fbdDownloadLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.tbOne = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbMissingDates = new System.Windows.Forms.CheckBox();
            this.pbOne = new System.Windows.Forms.ProgressBar();
            this.pbTwo = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFilesPath = new System.Windows.Forms.TextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.dgvtbDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtbPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStrip1.SuspendLayout();
            this.tbOne.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(120, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(257, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // tbCustomDelimiter
            // 
            this.tbCustomDelimiter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomDelimiter.Location = new System.Drawing.Point(120, 151);
            this.tbCustomDelimiter.Name = "tbCustomDelimiter";
            this.tbCustomDelimiter.Size = new System.Drawing.Size(67, 22);
            this.tbCustomDelimiter.TabIndex = 65;
            this.tbCustomDelimiter.Text = "Seperator";
            // 
            // tbMetastockPath
            // 
            this.tbMetastockPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetastockPath.Location = new System.Drawing.Point(120, 213);
            this.tbMetastockPath.Name = "tbMetastockPath";
            this.tbMetastockPath.Size = new System.Drawing.Size(257, 22);
            this.tbMetastockPath.TabIndex = 64;
            // 
            // tbExcelPath
            // 
            this.tbExcelPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExcelPath.Location = new System.Drawing.Point(120, 182);
            this.tbExcelPath.Name = "tbExcelPath";
            this.tbExcelPath.Size = new System.Drawing.Size(257, 22);
            this.tbExcelPath.TabIndex = 63;
            // 
            // tbCustomPath
            // 
            this.tbCustomPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomPath.Location = new System.Drawing.Point(193, 151);
            this.tbCustomPath.Name = "tbCustomPath";
            this.tbCustomPath.Size = new System.Drawing.Size(184, 22);
            this.tbCustomPath.TabIndex = 62;
            this.tbCustomPath.Text = "Location";
            // 
            // tbCsvPath
            // 
            this.tbCsvPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCsvPath.Location = new System.Drawing.Point(120, 123);
            this.tbCsvPath.Name = "tbCsvPath";
            this.tbCsvPath.Size = new System.Drawing.Size(257, 22);
            this.tbCsvPath.TabIndex = 61;
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CheckBox4.Location = new System.Drawing.Point(47, 153);
            this.CheckBox4.Name = "CheckBox4";
            this.CheckBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBox4.Size = new System.Drawing.Size(65, 17);
            this.CheckBox4.TabIndex = 60;
            this.CheckBox4.Text = "Custom";
            this.CheckBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.checkBox5.Location = new System.Drawing.Point(33, 215);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox5.Size = new System.Drawing.Size(79, 17);
            this.checkBox5.TabIndex = 59;
            this.checkBox5.Text = "Metastock";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.checkBox6.Location = new System.Drawing.Point(61, 184);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox6.Size = new System.Drawing.Size(51, 17);
            this.checkBox6.TabIndex = 58;
            this.checkBox6.Text = "Excel";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.checkBox7.Location = new System.Drawing.Point(66, 125);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox7.Size = new System.Drawing.Size(46, 17);
            this.checkBox7.TabIndex = 57;
            this.checkBox7.Text = "CSV";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // lblDownloadPath
            // 
            this.lblDownloadPath.AutoSize = true;
            this.lblDownloadPath.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDownloadPath.Location = new System.Drawing.Point(25, 20);
            this.lblDownloadPath.Name = "lblDownloadPath";
            this.lblDownloadPath.Size = new System.Drawing.Size(87, 13);
            this.lblDownloadPath.TabIndex = 56;
            this.lblDownloadPath.Text = "Download Path";
            // 
            // ofdSettings
            // 
            this.ofdSettings.FileName = "ofdSettings";
            // 
            // tbLocation
            // 
            this.tbLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocation.Location = new System.Drawing.Point(120, 17);
            this.tbLocation.Multiline = true;
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(257, 25);
            this.tbLocation.TabIndex = 49;
            this.tbLocation.Click += new System.EventHandler(this.tbLocation_Click);
            // 
            // clbMarkets
            // 
            this.clbMarkets.CheckOnClick = true;
            this.clbMarkets.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbMarkets.FormattingEnabled = true;
            this.clbMarkets.Items.AddRange(new object[] {
            "NSE - Equity",
            "BSE - Equity",
            "AMFII - Mutual Funds"});
            this.clbMarkets.Location = new System.Drawing.Point(120, 71);
            this.clbMarkets.Name = "clbMarkets";
            this.clbMarkets.Size = new System.Drawing.Size(257, 72);
            this.clbMarkets.TabIndex = 48;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(120, 149);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(121, 22);
            this.dtpFromDate.TabIndex = 47;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblFromDate.Location = new System.Drawing.Point(76, 156);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(36, 13);
            this.lblFromDate.TabIndex = 53;
            this.lblFromDate.Text = "Dates";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(258, 149);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(119, 22);
            this.dtpToDate.TabIndex = 52;
            // 
            // tsStatusText
            // 
            this.tsStatusText.Name = "tsStatusText";
            this.tsStatusText.Size = new System.Drawing.Size(427, 17);
            this.tsStatusText.Spring = true;
            this.tsStatusText.Text = "Ready...";
            this.tsStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownloadData4Markets
            // 
            this.lblDownloadData4Markets.AutoSize = true;
            this.lblDownloadData4Markets.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDownloadData4Markets.Location = new System.Drawing.Point(64, 82);
            this.lblDownloadData4Markets.Name = "lblDownloadData4Markets";
            this.lblDownloadData4Markets.Size = new System.Drawing.Size(48, 13);
            this.lblDownloadData4Markets.TabIndex = 55;
            this.lblDownloadData4Markets.Text = "Markets";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Window;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(120, 217);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 25);
            this.btnReset.TabIndex = 51;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusText});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 826);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(442, 22);
            this.StatusStrip1.TabIndex = 54;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(258, 217);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(119, 25);
            this.btnDownload.TabIndex = 50;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tbOne
            // 
            this.tbOne.Controls.Add(this.tabPage1);
            this.tbOne.Controls.Add(this.tabPage2);
            this.tbOne.Location = new System.Drawing.Point(12, 12);
            this.tbOne.Name = "tbOne";
            this.tbOne.SelectedIndex = 0;
            this.tbOne.Size = new System.Drawing.Size(415, 303);
            this.tbOne.TabIndex = 67;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbMissingDates);
            this.tabPage1.Controls.Add(this.pbOne);
            this.tabPage1.Controls.Add(this.pbTwo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.clbMarkets);
            this.tabPage1.Controls.Add(this.lblDownloadPath);
            this.tabPage1.Controls.Add(this.btnDownload);
            this.tabPage1.Controls.Add(this.tbLocation);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.lblDownloadData4Markets);
            this.tabPage1.Controls.Add(this.dtpFromDate);
            this.tabPage1.Controls.Add(this.dtpToDate);
            this.tabPage1.Controls.Add(this.lblFromDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbMissingDates
            // 
            this.cbMissingDates.AutoSize = true;
            this.cbMissingDates.Location = new System.Drawing.Point(120, 48);
            this.cbMissingDates.Name = "cbMissingDates";
            this.cbMissingDates.Size = new System.Drawing.Size(266, 17);
            this.cbMissingDates.TabIndex = 71;
            this.cbMissingDates.Text = "Downoad all Missing Dates at the given folder path";
            this.cbMissingDates.UseVisualStyleBackColor = true;
            this.cbMissingDates.CheckedChanged += new System.EventHandler(this.cbMissingDates_CheckedChanged);
            // 
            // pbOne
            // 
            this.pbOne.Location = new System.Drawing.Point(120, 177);
            this.pbOne.Name = "pbOne";
            this.pbOne.Size = new System.Drawing.Size(257, 14);
            this.pbOne.TabIndex = 70;
            // 
            // pbTwo
            // 
            this.pbTwo.Location = new System.Drawing.Point(120, 197);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(257, 14);
            this.pbTwo.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(87, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(69, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Overall";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.tbFilesPath);
            this.tabPage2.Controls.Add(this.tbMetastockPath);
            this.tabPage2.Controls.Add(this.tbCustomDelimiter);
            this.tabPage2.Controls.Add(this.btnSubmit);
            this.tabPage2.Controls.Add(this.tbExcelPath);
            this.tabPage2.Controls.Add(this.tbCustomPath);
            this.tabPage2.Controls.Add(this.checkBox7);
            this.tabPage2.Controls.Add(this.tbCsvPath);
            this.tabPage2.Controls.Add(this.checkBox6);
            this.tabPage2.Controls.Add(this.CheckBox4);
            this.tabPage2.Controls.Add(this.checkBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Convert";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Download Path";
            // 
            // tbFilesPath
            // 
            this.tbFilesPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFilesPath.Location = new System.Drawing.Point(120, 17);
            this.tbFilesPath.Multiline = true;
            this.tbFilesPath.Name = "tbFilesPath";
            this.tbFilesPath.Size = new System.Drawing.Size(257, 25);
            this.tbFilesPath.TabIndex = 66;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToOrderColumns = true;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtbDate,
            this.dgvtbFile,
            this.dgvtbFolder,
            this.dgvtbPath});
            this.dgvDetails.Location = new System.Drawing.Point(16, 322);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.Size = new System.Drawing.Size(411, 489);
            this.dgvDetails.TabIndex = 68;
            // 
            // dgvtbDate
            // 
            this.dgvtbDate.HeaderText = "Date";
            this.dgvtbDate.Name = "dgvtbDate";
            // 
            // dgvtbFile
            // 
            this.dgvtbFile.HeaderText = "File";
            this.dgvtbFile.Name = "dgvtbFile";
            // 
            // dgvtbFolder
            // 
            this.dgvtbFolder.HeaderText = "Folder";
            this.dgvtbFolder.Name = "dgvtbFolder";
            // 
            // dgvtbPath
            // 
            this.dgvtbPath.HeaderText = "Path";
            this.dgvtbPath.Name = "dgvtbPath";
            // 
            // frmDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 848);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.tbOne);
            this.Controls.Add(this.StatusStrip1);
            this.Name = "frmDownloader";
            this.Text = "The Downloader";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.tbOne.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.TextBox tbCustomDelimiter;
        internal System.Windows.Forms.TextBox tbMetastockPath;
        internal System.Windows.Forms.TextBox tbExcelPath;
        internal System.Windows.Forms.TextBox tbCustomPath;
        internal System.Windows.Forms.TextBox tbCsvPath;
        internal System.Windows.Forms.CheckBox CheckBox4;
        internal System.Windows.Forms.CheckBox checkBox5;
        internal System.Windows.Forms.CheckBox checkBox6;
        internal System.Windows.Forms.CheckBox checkBox7;
        internal System.Windows.Forms.Label lblDownloadPath;
        internal System.Windows.Forms.OpenFileDialog ofdSettings;
        internal System.Windows.Forms.TextBox tbLocation;
        internal System.Windows.Forms.CheckedListBox clbMarkets;
        internal System.Windows.Forms.DateTimePicker dtpFromDate;
        internal System.Windows.Forms.Label lblFromDate;
        internal System.Windows.Forms.DateTimePicker dtpToDate;
        internal System.Windows.Forms.ToolStripStatusLabel tsStatusText;
        internal System.Windows.Forms.Label lblDownloadData4Markets;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.Button btnDownload;
        internal System.Windows.Forms.FolderBrowserDialog fbdDownloadLocation;
        private System.Windows.Forms.TabControl tbOne;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.ProgressBar pbOne;
        private System.Windows.Forms.ProgressBar pbTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox tbFilesPath;
        private System.Windows.Forms.CheckBox cbMissingDates;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtbPath;
    }
}

