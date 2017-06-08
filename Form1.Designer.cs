namespace FFmpegToTheoraVorbisGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FilesListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TheoraLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TheoraTrackBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.VorbisLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VorbisTrackBar = new System.Windows.Forms.TrackBar();
            this.LoadFilesButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputBrowseButton = new System.Windows.Forms.Button();
            this.RemoveFilesButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TheoraUseCheckBox = new System.Windows.Forms.CheckBox();
            this.VorbisUseCheckBox = new System.Windows.Forms.CheckBox();
            this.PlayFileButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.GitHubButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheoraTrackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VorbisTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesListBox
            // 
            this.FilesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListBox.FormattingEnabled = true;
            this.FilesListBox.Location = new System.Drawing.Point(154, 19);
            this.FilesListBox.Name = "FilesListBox";
            this.FilesListBox.Size = new System.Drawing.Size(638, 108);
            this.FilesListBox.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TheoraUseCheckBox);
            this.groupBox1.Controls.Add(this.TheoraLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TheoraTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Theora (Video Track)";
            // 
            // TheoraLabel
            // 
            this.TheoraLabel.AutoSize = true;
            this.TheoraLabel.Location = new System.Drawing.Point(56, 61);
            this.TheoraLabel.Name = "TheoraLabel";
            this.TheoraLabel.Size = new System.Drawing.Size(45, 13);
            this.TheoraLabel.TabIndex = 2;
            this.TheoraLabel.Text = "VALUE!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quality:";
            // 
            // TheoraTrackBar
            // 
            this.TheoraTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TheoraTrackBar.LargeChange = 1;
            this.TheoraTrackBar.Location = new System.Drawing.Point(7, 20);
            this.TheoraTrackBar.Name = "TheoraTrackBar";
            this.TheoraTrackBar.Size = new System.Drawing.Size(218, 45);
            this.TheoraTrackBar.TabIndex = 7;
            this.TheoraTrackBar.Value = 7;
            this.TheoraTrackBar.Scroll += new System.EventHandler(this.TheoraTrackBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.VorbisUseCheckBox);
            this.groupBox2.Controls.Add(this.VorbisLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.VorbisTrackBar);
            this.groupBox2.Location = new System.Drawing.Point(243, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 83);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vorbis (Audio Track)";
            // 
            // VorbisLabel
            // 
            this.VorbisLabel.AutoSize = true;
            this.VorbisLabel.Location = new System.Drawing.Point(56, 61);
            this.VorbisLabel.Name = "VorbisLabel";
            this.VorbisLabel.Size = new System.Drawing.Size(45, 13);
            this.VorbisLabel.TabIndex = 2;
            this.VorbisLabel.Text = "VALUE!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quality:";
            // 
            // VorbisTrackBar
            // 
            this.VorbisTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VorbisTrackBar.LargeChange = 1;
            this.VorbisTrackBar.Location = new System.Drawing.Point(7, 20);
            this.VorbisTrackBar.Name = "VorbisTrackBar";
            this.VorbisTrackBar.Size = new System.Drawing.Size(218, 45);
            this.VorbisTrackBar.TabIndex = 9;
            this.VorbisTrackBar.Value = 5;
            this.VorbisTrackBar.Scroll += new System.EventHandler(this.VorbisTrackBar_Scroll);
            // 
            // LoadFilesButton
            // 
            this.LoadFilesButton.Location = new System.Drawing.Point(6, 19);
            this.LoadFilesButton.Name = "LoadFilesButton";
            this.LoadFilesButton.Size = new System.Drawing.Size(142, 23);
            this.LoadFilesButton.TabIndex = 0;
            this.LoadFilesButton.Text = "Add Files...";
            this.LoadFilesButton.UseVisualStyleBackColor = true;
            this.LoadFilesButton.Click += new System.EventHandler(this.LoadFilesButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(480, 19);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 11;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(212, 21);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(580, 20);
            this.OutputTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output Location";
            // 
            // OutputBrowseButton
            // 
            this.OutputBrowseButton.Location = new System.Drawing.Point(131, 19);
            this.OutputBrowseButton.Name = "OutputBrowseButton";
            this.OutputBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.OutputBrowseButton.TabIndex = 5;
            this.OutputBrowseButton.Text = "Browse";
            this.OutputBrowseButton.UseVisualStyleBackColor = true;
            this.OutputBrowseButton.Click += new System.EventHandler(this.OutputBrowseButton_Click);
            // 
            // RemoveFilesButton
            // 
            this.RemoveFilesButton.Location = new System.Drawing.Point(6, 77);
            this.RemoveFilesButton.Name = "RemoveFilesButton";
            this.RemoveFilesButton.Size = new System.Drawing.Size(142, 23);
            this.RemoveFilesButton.TabIndex = 2;
            this.RemoveFilesButton.Text = "Remove Selected File";
            this.RemoveFilesButton.UseVisualStyleBackColor = true;
            this.RemoveFilesButton.Click += new System.EventHandler(this.RemoveFilesButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(6, 106);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(142, 23);
            this.ClearListButton.TabIndex = 3;
            this.ClearListButton.Text = "Clear List";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.PlayFileButton);
            this.groupBox3.Controls.Add(this.LoadFilesButton);
            this.groupBox3.Controls.Add(this.ClearListButton);
            this.groupBox3.Controls.Add(this.FilesListBox);
            this.groupBox3.Controls.Add(this.RemoveFilesButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(798, 136);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files To Convert To OGG";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.OutputBrowseButton);
            this.groupBox4.Controls.Add(this.OutputTextBox);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(12, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(798, 55);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Output Location";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.GitHubButton);
            this.groupBox5.Controls.Add(this.AboutButton);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Controls.Add(this.ConvertButton);
            this.groupBox5.Location = new System.Drawing.Point(12, 215);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(798, 114);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quality Options";
            // 
            // TheoraUseCheckBox
            // 
            this.TheoraUseCheckBox.AutoSize = true;
            this.TheoraUseCheckBox.Checked = true;
            this.TheoraUseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TheoraUseCheckBox.Enabled = false;
            this.TheoraUseCheckBox.Location = new System.Drawing.Point(107, 60);
            this.TheoraUseCheckBox.Name = "TheoraUseCheckBox";
            this.TheoraUseCheckBox.Size = new System.Drawing.Size(123, 17);
            this.TheoraUseCheckBox.TabIndex = 8;
            this.TheoraUseCheckBox.Text = "Use (Future Feature)";
            this.TheoraUseCheckBox.UseVisualStyleBackColor = true;
            this.TheoraUseCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // VorbisUseCheckBox
            // 
            this.VorbisUseCheckBox.AutoSize = true;
            this.VorbisUseCheckBox.Checked = true;
            this.VorbisUseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VorbisUseCheckBox.Enabled = false;
            this.VorbisUseCheckBox.Location = new System.Drawing.Point(107, 60);
            this.VorbisUseCheckBox.Name = "VorbisUseCheckBox";
            this.VorbisUseCheckBox.Size = new System.Drawing.Size(123, 17);
            this.VorbisUseCheckBox.TabIndex = 10;
            this.VorbisUseCheckBox.Text = "Use (Future Feature)";
            this.VorbisUseCheckBox.UseVisualStyleBackColor = true;
            this.VorbisUseCheckBox.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // PlayFileButton
            // 
            this.PlayFileButton.Location = new System.Drawing.Point(6, 48);
            this.PlayFileButton.Name = "PlayFileButton";
            this.PlayFileButton.Size = new System.Drawing.Size(142, 23);
            this.PlayFileButton.TabIndex = 1;
            this.PlayFileButton.Text = "Play File In External Player";
            this.PlayFileButton.UseVisualStyleBackColor = true;
            this.PlayFileButton.Click += new System.EventHandler(this.PlayFileButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(480, 48);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 12;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // GitHubButton
            // 
            this.GitHubButton.Location = new System.Drawing.Point(480, 77);
            this.GitHubButton.Name = "GitHubButton";
            this.GitHubButton.Size = new System.Drawing.Size(75, 23);
            this.GitHubButton.TabIndex = 13;
            this.GitHubButton.Text = "GitHub";
            this.GitHubButton.UseVisualStyleBackColor = true;
            this.GitHubButton.Click += new System.EventHandler(this.GitHubButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 341);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FFMPEG To Theora+Vorbis OGG File GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TheoraTrackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VorbisTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FilesListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar TheoraTrackBar;
        private System.Windows.Forms.Label TheoraLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label VorbisLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar VorbisTrackBar;
        private System.Windows.Forms.Button LoadFilesButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button OutputBrowseButton;
        private System.Windows.Forms.Button RemoveFilesButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox TheoraUseCheckBox;
        private System.Windows.Forms.CheckBox VorbisUseCheckBox;
        private System.Windows.Forms.Button PlayFileButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button GitHubButton;
    }
}

