using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FFmpegToTheoraVorbisGUI
{
    public partial class Form1 : Form
    {
        OpenFileDialog VideoFiles = new OpenFileDialog();
        FolderBrowserDialog OutputFolder = new FolderBrowserDialog();
        string OutputSubFolder = "Output";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VideoFiles.InitialDirectory = Environment.CurrentDirectory;
            OutputFolder.SelectedPath = Environment.CurrentDirectory + "\\" + OutputSubFolder;
            VideoFiles.Filter = "Video Files|*.avi; *.mp4; *.mkv; *.ogg; *.ogv; |All files (*.*)|*.*";
            VideoFiles.FilterIndex = 2; //Until I can finalize a list, it will look at all files by default.
            OutputFolder.Description = "Select the folder where to save the conversions.";
            OutputTextBox.Text = OutputFolder.SelectedPath;
            VideoFiles.Multiselect = true;
            TheoraTrackBar_Scroll(sender, e);
            VorbisTrackBar_Scroll(sender, e);
            CheckedChanged(sender, e);
            LoadFilesButton.Focus();
        }

        private void TheoraTrackBar_Scroll(object sender, EventArgs e)
        {
            TheoraLabel.Text = TheoraTrackBar.Value.ToString();
        }

        private void VorbisTrackBar_Scroll(object sender, EventArgs e)
        {
            VorbisLabel.Text = VorbisTrackBar.Value.ToString();
        }

        private void LoadFilesButton_Click(object sender, EventArgs e)
        {
            bool duplicate = false;
            if (VideoFiles.ShowDialog() == DialogResult.OK)
            {
                //Add files to list
                for (int i = 0; i < VideoFiles.FileNames.Length; i++)
                {
                    //Code to detect a duplicate entry.
                    duplicate = false; //Reset variable for next file test.
                    for (int j = 0; j < FilesListBox.Items.Count && !duplicate; j++)
                    {
                        duplicate = VideoFiles.FileNames[i].ToLower() == FilesListBox.Items[j].ToString().ToLower();
                    }
                    if (!duplicate)
                    {
                        FilesListBox.Items.Add(VideoFiles.FileNames[i]);
                    }
                    else
                    {
                        MessageBox.Show("The file at " + VideoFiles.FileNames[i] + " has already been added to the list and will not be readded.", "Duplicate File Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void PlayFileButton_Click(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedIndex >= 0)
            {
                if (File.Exists(FilesListBox.Items[FilesListBox.SelectedIndex].ToString()))
                {
                    Process.Start(FilesListBox.Items[FilesListBox.SelectedIndex].ToString());
                }
                else
                {
                    FileDoesntExist();
                }
            }
            else
            {
                NoFileSelected();
            }
        }

        private void RemoveFilesButton_Click(object sender, EventArgs e)
        {
            if (FilesListBox.SelectedIndex >= 0)
            {
                FilesListBox.Items.RemoveAt(FilesListBox.SelectedIndex);
                FilesListBox.SelectedIndex = FilesListBox.Items.Count - 1;
            }
            else
            {
                NoFileSelected();
            }
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            FilesListBox.Items.Clear();
        }

        private void OutputBrowseButton_Click(object sender, EventArgs e)
        {
            OutputFolder.SelectedPath = OutputTextBox.Text;
            if (OutputFolder.ShowDialog() == DialogResult.OK)
            {
                OutputTextBox.Text = OutputFolder.SelectedPath;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            //Might eventually add the ability to define a start and end position for each file. Have to trim the clips elsewhere.
            //https://www.superuser.com/questions/377343
            this.Enabled = false;
            bool CreateDirectory = true;
            if (File.Exists("ffmpeg.exe"))
            {
                if (!Directory.Exists(OutputTextBox.Text))
                {
                    CreateDirectory = MessageBox.Show("Directory \"" + OutputTextBox.Text + "\" doesn't exist. Create it?", "Directory Doesn't Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                    if (CreateDirectory)
                    {
                        Process.Start("mkdir", "\"" + OutputTextBox.Text + "\"").WaitForExit();
                    }
                }
                for (int i = 0; i < FilesListBox.Items.Count && CreateDirectory; i++)
                {
                    FilesListBox.SelectedIndex = i;
                    if (File.Exists(FilesListBox.Items[i].ToString()))
                    {
                        Process.Start("ffmpeg", "-i \"" + FilesListBox.Items[i].ToString() + "\"" + ((TheoraUseCheckBox.Checked) ? " -codec:v libtheora -qscale:v " + TheoraTrackBar.Value.ToString() : "") + ((VorbisUseCheckBox.Checked) ? " -codec:a libvorbis -qscale:a " + VorbisTrackBar.Value.ToString() : "") + " \"" + FindNewFileName(OutputTextBox.Text + "\\" + Path.GetFileNameWithoutExtension(FilesListBox.Items[i].ToString()), "ogv", -1) + "\"").WaitForExit();
                    }
                    else
                    {
                        FileDoesntExist();
                    }
                    FilesListBox.SelectedIndex = -1;
                }
            }
            else
            {
                MessageBox.Show("Missing \"ffmpeg.exe\" in \"" + Environment.CurrentDirectory + "\" directory. Application will now open up a new browser window/tab where to download and the directory where to place \"ffmpeg.exe\". For best results, download a nightly build.", "Missing ffmpeg.exe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("http://ffmpeg.zeranoe.com/builds");
                Process.Start("sleep", "1").WaitForExit();
                Process.Start(Environment.CurrentDirectory);
            }
            this.Enabled = true;
            this.Focus();
            ConvertButton.Focus();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Text + Environment.NewLine + "By wildgoosespeeder" + Environment.NewLine + Environment.NewLine + "FFmpeg" + Environment.NewLine + "By Fabrice Bellard, FFmpeg Team" + Environment.NewLine + "https://www.ffmpeg.org" + Environment.NewLine + Environment.NewLine + "OGG, Vorbis, and Theora" + Environment.NewLine + "By Xiph.Org Foundation" + Environment.NewLine + "https://www.xiph.org", "About " + this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GitHubButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.github.com/wildgoosespeeder/FFMPEG-To-Theora-Vorbis-OGG-File-GUI");
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            ConvertButton.Enabled = TheoraUseCheckBox.Checked || VorbisUseCheckBox.Checked;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            VideoFiles.Dispose();
            OutputFolder.Dispose();
        }

        private string FindNewFileName(string test, string extension, int index)
        {
            //This function makes sure that a converted file doesn't get overwritten with the next file to convert if the file has the same name in different directories since it will be saving the conversions in one folder.
            string newpath = Path.GetDirectoryName(test) + "\\" + Path.GetFileNameWithoutExtension(test) + ((index > -1 ) ? index.ToString() : "") + "." + extension;
            //Recursion to find a duplicate file name
            if (File.Exists(newpath)) //Terminating condition. If the file doesn't exist, skip the code in the if. Else call new instance of FindNewFileName.
            {
                newpath = FindNewFileName(test, extension, ++index);
            }
            return newpath;
        }

        private void NoFileSelected()
        {
            MessageBox.Show("Plese select a file from the list first.", "No File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileDoesntExist()
        {
            MessageBox.Show("File no longer exists in \"" + FilesListBox.Items[FilesListBox.SelectedIndex].ToString() + "\".", "File no longer exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
