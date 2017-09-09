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
            this.pbTwo = new System.Windows.Forms.ProgressBar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tsProgressBar1 = new System.Windows.Forms.ProgressBar();
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
            this.tbDownloadLocation = new System.Windows.Forms.TextBox();
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
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbTwo
            // 
            this.pbTwo.Location = new System.Drawing.Point(101, 323);
            this.pbTwo.Name = "pbTwo";
            this.pbTwo.Size = new System.Drawing.Size(257, 14);
            this.pbTwo.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(101, 343);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(257, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(68, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(50, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Overall";
            // 
            // tsProgressBar1
            // 
            this.tsProgressBar1.Location = new System.Drawing.Point(101, 303);
            this.tsProgressBar1.Name = "tsProgressBar1";
            this.tsProgressBar1.Size = new System.Drawing.Size(257, 14);
            this.tsProgressBar1.TabIndex = 66;
            // 
            // tbCustomDelimiter
            // 
            this.tbCustomDelimiter.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomDelimiter.Location = new System.Drawing.Point(101, 213);
            this.tbCustomDelimiter.Name = "tbCustomDelimiter";
            this.tbCustomDelimiter.Size = new System.Drawing.Size(67, 22);
            this.tbCustomDelimiter.TabIndex = 65;
            this.tbCustomDelimiter.Text = "Seperator";
            // 
            // tbMetastockPath
            // 
            this.tbMetastockPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMetastockPath.Location = new System.Drawing.Point(101, 275);
            this.tbMetastockPath.Name = "tbMetastockPath";
            this.tbMetastockPath.Size = new System.Drawing.Size(257, 22);
            this.tbMetastockPath.TabIndex = 64;
            // 
            // tbExcelPath
            // 
            this.tbExcelPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExcelPath.Location = new System.Drawing.Point(101, 244);
            this.tbExcelPath.Name = "tbExcelPath";
            this.tbExcelPath.Size = new System.Drawing.Size(257, 22);
            this.tbExcelPath.TabIndex = 63;
            // 
            // tbCustomPath
            // 
            this.tbCustomPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomPath.Location = new System.Drawing.Point(174, 213);
            this.tbCustomPath.Name = "tbCustomPath";
            this.tbCustomPath.Size = new System.Drawing.Size(184, 22);
            this.tbCustomPath.TabIndex = 62;
            this.tbCustomPath.Text = "Location";
            // 
            // tbCsvPath
            // 
            this.tbCsvPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCsvPath.Location = new System.Drawing.Point(101, 185);
            this.tbCsvPath.Name = "tbCsvPath";
            this.tbCsvPath.Size = new System.Drawing.Size(257, 22);
            this.tbCsvPath.TabIndex = 61;
            // 
            // CheckBox4
            // 
            this.CheckBox4.AutoSize = true;
            this.CheckBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.CheckBox4.Location = new System.Drawing.Point(28, 215);
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
            this.checkBox5.Location = new System.Drawing.Point(14, 277);
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
            this.checkBox6.Location = new System.Drawing.Point(42, 246);
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
            this.checkBox7.Location = new System.Drawing.Point(47, 187);
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
            this.lblDownloadPath.Location = new System.Drawing.Point(6, 20);
            this.lblDownloadPath.Name = "lblDownloadPath";
            this.lblDownloadPath.Size = new System.Drawing.Size(87, 13);
            this.lblDownloadPath.TabIndex = 56;
            this.lblDownloadPath.Text = "Download Path";
            // 
            // ofdSettings
            // 
            this.ofdSettings.FileName = "ofdSettings";
            // 
            // tbDownloadLocation
            // 
            this.tbDownloadLocation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDownloadLocation.Location = new System.Drawing.Point(101, 17);
            this.tbDownloadLocation.Multiline = true;
            this.tbDownloadLocation.Name = "tbDownloadLocation";
            this.tbDownloadLocation.Size = new System.Drawing.Size(257, 25);
            this.tbDownloadLocation.TabIndex = 49;
            this.tbDownloadLocation.Click += new System.EventHandler(this.tbDownloadLocation_Click);
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
            this.clbMarkets.Location = new System.Drawing.Point(101, 48);
            this.clbMarkets.Name = "clbMarkets";
            this.clbMarkets.Size = new System.Drawing.Size(257, 72);
            this.clbMarkets.TabIndex = 48;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Location = new System.Drawing.Point(101, 126);
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
            this.lblFromDate.Location = new System.Drawing.Point(57, 133);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(36, 13);
            this.lblFromDate.TabIndex = 53;
            this.lblFromDate.Text = "Dates";
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(239, 126);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(119, 22);
            this.dtpToDate.TabIndex = 52;
            // 
            // tsStatusText
            // 
            this.tsStatusText.Name = "tsStatusText";
            this.tsStatusText.Size = new System.Drawing.Size(365, 17);
            this.tsStatusText.Spring = true;
            this.tsStatusText.Text = "Ready...";
            this.tsStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownloadData4Markets
            // 
            this.lblDownloadData4Markets.AutoSize = true;
            this.lblDownloadData4Markets.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDownloadData4Markets.Location = new System.Drawing.Point(45, 48);
            this.lblDownloadData4Markets.Name = "lblDownloadData4Markets";
            this.lblDownloadData4Markets.Size = new System.Drawing.Size(48, 13);
            this.lblDownloadData4Markets.TabIndex = 55;
            this.lblDownloadData4Markets.Text = "Markets";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Window;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(101, 154);
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
            this.StatusStrip1.Location = new System.Drawing.Point(0, 381);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(380, 22);
            this.StatusStrip1.TabIndex = 54;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(239, 154);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(119, 25);
            this.btnDownload.TabIndex = 50;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 403);
            this.Controls.Add(this.tsProgressBar1);
            this.Controls.Add(this.tbCustomDelimiter);
            this.Controls.Add(this.tbMetastockPath);
            this.Controls.Add(this.tbExcelPath);
            this.Controls.Add(this.tbCustomPath);
            this.Controls.Add(this.tbCsvPath);
            this.Controls.Add(this.CheckBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.lblDownloadPath);
            this.Controls.Add(this.tbDownloadLocation);
            this.Controls.Add(this.clbMarkets);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.lblDownloadData4Markets);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pbTwo);
            this.Name = "frmDownloader";
            this.Text = "Equity Bhav Copy Downloader";
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar pbTwo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ProgressBar tsProgressBar1;
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
        internal System.Windows.Forms.TextBox tbDownloadLocation;
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
    }
}

