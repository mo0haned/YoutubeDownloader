
namespace PixelDownloader
{
    partial class Form1
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
            this.Topbtn = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Mini = new System.Windows.Forms.Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.toppanelshadow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.videoLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dataprogress = new System.Windows.Forms.ToolStripStatusLabel();
            this.Vid = new System.Windows.Forms.Panel();
            this.SoundOnly = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AudioQuality = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Start = new System.Windows.Forms.Button();
            this.VidTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Quality = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Downloader_BackProcess = new System.ComponentModel.BackgroundWorker();
            this.Topbtn.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Vid.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topbtn
            // 
            this.Topbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(114)))), ((int)(((byte)(172)))));
            this.Topbtn.Controls.Add(this.Title);
            this.Topbtn.Controls.Add(this.Mini);
            this.Topbtn.Controls.Add(this.Closebtn);
            this.Topbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topbtn.Location = new System.Drawing.Point(0, 0);
            this.Topbtn.Margin = new System.Windows.Forms.Padding(0);
            this.Topbtn.Name = "Topbtn";
            this.Topbtn.Size = new System.Drawing.Size(643, 60);
            this.Topbtn.TabIndex = 0;
            this.Topbtn.Paint += new System.Windows.Forms.PaintEventHandler(this.Top_Paint);
            this.Topbtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_MouseDown);
            this.Topbtn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_MouseMove);
            this.Topbtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_MouseUp);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Almarai Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Title.Location = new System.Drawing.Point(12, 11);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(307, 38);
            this.Title.TabIndex = 4;
            this.Title.Text = "Pixel Youtube Downloader";
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_MouseUp);
            // 
            // Mini
            // 
            this.Mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.Mini.FlatAppearance.BorderSize = 0;
            this.Mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mini.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Mini.Location = new System.Drawing.Point(543, 0);
            this.Mini.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Mini.Name = "Mini";
            this.Mini.Size = new System.Drawing.Size(50, 60);
            this.Mini.TabIndex = 3;
            this.Mini.Text = "_";
            this.Mini.UseVisualStyleBackColor = true;
            this.Mini.Click += new System.EventHandler(this.Mini_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.Font = new System.Drawing.Font("Almarai Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Closebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.Closebtn.Location = new System.Drawing.Point(593, 0);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(50, 60);
            this.Closebtn.TabIndex = 2;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = true;
            this.Closebtn.Click += new System.EventHandler(this.Close_Click);
            this.Closebtn.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Closebtn.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // toppanelshadow
            // 
            this.toppanelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.toppanelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanelshadow.Location = new System.Drawing.Point(0, 60);
            this.toppanelshadow.Margin = new System.Windows.Forms.Padding(0);
            this.toppanelshadow.Name = "toppanelshadow";
            this.toppanelshadow.Size = new System.Drawing.Size(643, 4);
            this.toppanelshadow.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Almarai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "video  Link :";
            // 
            // videoLink
            // 
            this.videoLink.Font = new System.Drawing.Font("Almarai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videoLink.Location = new System.Drawing.Point(124, 79);
            this.videoLink.Multiline = true;
            this.videoLink.Name = "videoLink";
            this.videoLink.Size = new System.Drawing.Size(507, 24);
            this.videoLink.TabIndex = 3;
            this.videoLink.TextChanged += new System.EventHandler(this.Checkbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Almarai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save Location :";
            // 
            // SelectFolder
            // 
            this.SelectFolder.FlatAppearance.BorderSize = 0;
            this.SelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectFolder.Location = new System.Drawing.Point(553, 127);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(78, 26);
            this.SelectFolder.TabIndex = 7;
            this.SelectFolder.Text = "Select";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            this.SelectFolder.MouseHover += new System.EventHandler(this.SelectFolder_MouseHover);
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("Almarai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilePath.Location = new System.Drawing.Point(123, 127);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(436, 23);
            this.FilePath.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status,
            this.Dataprogress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 293);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(643, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // Dataprogress
            // 
            this.Dataprogress.Name = "Dataprogress";
            this.Dataprogress.Size = new System.Drawing.Size(0, 17);
            // 
            // Vid
            // 
            this.Vid.Controls.Add(this.SoundOnly);
            this.Vid.Controls.Add(this.label4);
            this.Vid.Controls.Add(this.AudioQuality);
            this.Vid.Controls.Add(this.progressBar1);
            this.Vid.Controls.Add(this.Start);
            this.Vid.Controls.Add(this.VidTitle);
            this.Vid.Controls.Add(this.label5);
            this.Vid.Controls.Add(this.Quality);
            this.Vid.Controls.Add(this.label3);
            this.Vid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Vid.Enabled = false;
            this.Vid.Location = new System.Drawing.Point(0, 170);
            this.Vid.Name = "Vid";
            this.Vid.Size = new System.Drawing.Size(643, 123);
            this.Vid.TabIndex = 10;
            this.Vid.Paint += new System.Windows.Forms.PaintEventHandler(this.Vid_Paint);
            // 
            // SoundOnly
            // 
            this.SoundOnly.AutoSize = true;
            this.SoundOnly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SoundOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoundOnly.Location = new System.Drawing.Point(430, 16);
            this.SoundOnly.Name = "SoundOnly";
            this.SoundOnly.Size = new System.Drawing.Size(85, 22);
            this.SoundOnly.TabIndex = 15;
            this.SoundOnly.Text = "Sound only";
            this.SoundOnly.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Almarai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(219, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Audio Quality :";
            // 
            // AudioQuality
            // 
            this.AudioQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AudioQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.AudioQuality.FormatString = "N0";
            this.AudioQuality.FormattingEnabled = true;
            this.AudioQuality.Location = new System.Drawing.Point(332, 12);
            this.AudioQuality.Name = "AudioQuality";
            this.AudioQuality.Size = new System.Drawing.Size(62, 26);
            this.AudioQuality.TabIndex = 13;
            this.AudioQuality.SelectedIndexChanged += new System.EventHandler(this.AudioQuality_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(548, 26);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(566, 80);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 40);
            this.Start.TabIndex = 11;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            this.Start.MouseHover += new System.EventHandler(this.Start_MouseHover);
            // 
            // VidTitle
            // 
            this.VidTitle.AutoSize = true;
            this.VidTitle.Font = new System.Drawing.Font("Almarai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VidTitle.Location = new System.Drawing.Point(123, 50);
            this.VidTitle.Name = "VidTitle";
            this.VidTitle.Size = new System.Drawing.Size(0, 24);
            this.VidTitle.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Almarai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(42, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Video title : ";
            // 
            // Quality
            // 
            this.Quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Quality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Quality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.Quality.FormatString = "N0";
            this.Quality.FormattingEnabled = true;
            this.Quality.Location = new System.Drawing.Point(124, 12);
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(62, 26);
            this.Quality.TabIndex = 7;
            this.Quality.SelectedIndexChanged += new System.EventHandler(this.Quality_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Almarai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Video Quality :";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Downloader_BackProcess
            // 
            this.Downloader_BackProcess.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(643, 315);
            this.Controls.Add(this.Vid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.videoLink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toppanelshadow);
            this.Controls.Add(this.Topbtn);
            this.Font = new System.Drawing.Font("Almarai", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Topbtn.ResumeLayout(false);
            this.Topbtn.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Vid.ResumeLayout(false);
            this.Vid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Topbtn;
        private System.Windows.Forms.Panel toppanelshadow;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Button Mini;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox videoLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel Vid;
        private System.Windows.Forms.ComboBox Quality;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label VidTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel Dataprogress;
        private System.Windows.Forms.ComboBox AudioQuality;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker Downloader_BackProcess;
        private System.Windows.Forms.CheckBox SoundOnly;
    }
}

