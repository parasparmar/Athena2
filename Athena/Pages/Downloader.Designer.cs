namespace Athena.Pages
{
    partial class Downloader
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
            split1 = new SplitContainer();
            split2 = new SplitContainer();
            splitContainer1 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)split1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            split1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)split2).BeginInit();
            split2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // split1
            // 
            split1.Location = new Point(28, 83);
            split1.Name = "split1";
            // 
            // split1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer1);
            split1.Size = new Size(657, 299);
            split1.SplitterDistance = 140;
            split1.TabIndex = 0;
            // 
            // split2
            // 
            split2.Location = new Point(34, 53);
            split2.Name = "split2";
            split2.Orientation = Orientation.Horizontal;
            split2.Size = new Size(279, 192);
            split2.SplitterDistance = 93;
            split2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(split2);
            splitContainer1.Size = new Size(513, 299);
            splitContainer1.SplitterDistance = 350;
            splitContainer1.TabIndex = 0;
            // 
            // Downloader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(split1);
            Name = "Downloader";
            Text = "Downloader";
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split1).EndInit();
            split1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)split2).EndInit();
            split2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer split1;
        private SplitContainer split2;
        private SplitContainer splitContainer1;
    }
}