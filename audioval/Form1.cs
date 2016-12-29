using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace audioval
{
    public partial class Form1 : Form
    {
        private OpenFileDialog open;
        private track interval;
        private List<string> files = new List<string>();
        private List<string> filesSplit;
        private List<string> filesWhistle;
        private string filename;
        private string outputDir = Application.StartupPath + @"\audio\";

        public Form1()
        {
            InitializeComponent();
            interval = new track();
            interval.output = outputDir;
            cbWarmup.SelectedIndex = 0;
            cbCooldown.SelectedIndex = 0;
            cbRun.SelectedIndex = 0;
            cbRest.SelectedIndex = 0;
            calcTimespan(files.Count);
        }

        private void calcTimespan(int files)
        {
            switch (files)
            {
                case 3:
                    cbWarmup.Enabled = true;
                    cbWarmup.Items.Add("5 minutes");
                    cbWarmup.SelectedIndex = 1;
                    break;
                case 5:
                    cbCooldown.Enabled = true;
                    cbCooldown.Items.Add("5 minutes");
                    cbCooldown.SelectedIndex = 1;
                    break;
                case 10:
                    cbWarmup.Items.Add("10 minutes");
                    cbCooldown.Items.Add("10 minutes");
                    cbWarmup.SelectedIndex = 2;
                    cbCooldown.SelectedIndex = 2;
                    break;
                case 15:
                    cbWarmup.Items.Add("15 minutes");
                    cbCooldown.Items.Add("15 minutes");
                    cbWarmup.SelectedIndex = 3;
                    cbCooldown.SelectedIndex = 3;
                    break;
                case 20:
                    cbWarmup.Items.Add("20 minutes");
                    cbCooldown.Items.Add("20 minutes");
                    cbWarmup.SelectedIndex = 4;
                    cbCooldown.SelectedIndex = 4;
                    break;
                case 25:
                    cbWarmup.Items.Add("25 minutes");
                    cbCooldown.Items.Add("25 minutes");
                    cbWarmup.SelectedIndex = 5;
                    cbCooldown.SelectedIndex = 5;
                    break;
                case 30:
                    cbWarmup.Items.Add("30 minutes");
                    cbCooldown.Items.Add("30 minutes");
                    cbWarmup.SelectedIndex = 6;
                    cbCooldown.SelectedIndex = 6;
                    break;
            }
        }

        private void drawFiles()
        {
            listFiles.Items.Clear();
            foreach (string s in files)
            {
                listFiles.Items.Add(s);
            }
        }

        private void btAddFiles_Click(object sender, EventArgs e)
        {
            try
            {
                open = new OpenFileDialog();
                open.Filter = "mp3 Audio Files|*.mp3;*.MP3";
                DialogResult dr = new System.Windows.Forms.DialogResult();
                dr = open.ShowDialog();
                if (dr == System.Windows.Forms.DialogResult.OK && open.FileName != string.Empty)
                {
                    //listFiles.Items.Add(open.SafeFileName);
                    files.Add(open.FileName);
                    calcTimespan(files.Count);
                    drawFiles();
                }
            }
            catch (Exception ex)
            {
                logic.showException("addFiles", ex);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txFilename_TextChanged(object sender, EventArgs e)
        {
            filename = txFilename.Text.ToString();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (files.Count != 0)
                {
                    barToolStrip.Style = ProgressBarStyle.Marquee;
                    lbToolStrip.Text = "Creating Track...";
                    interval.output = outputDir;

                    interval.filename = logic.mergeMp3(files, interval.output, DateTime.Now.Ticks.ToString());
                    lbToolStrip.Text = "merged files. output: " + interval.filename;

                    filesSplit = interval.splitMp3();
                    lbToolStrip.Text = "splitted merged mp3 file into mp3 files";

                    filesWhistle = logic.addWhistle(filesSplit, cbRun.SelectedIndex, cbRest.SelectedIndex, cbWarmup.SelectedIndex, cbCooldown.SelectedIndex);
                    lbToolStrip.Text = "whistle added";

                    string mergedFile = logic.mergeMp3(filesWhistle, interval.output, interval.filename + "-complete");
                    lbToolStrip.Text = "whistled wave files merged";

                    Process lame = Process.Start("lame.exe", "-V 2 --vbr-new --tt \"Interval_" + DateTime.Now.ToShortDateString() + "\" --ta \"AudioVALL\" \"" + interval.output + mergedFile + "\" \"" + interval.output + "AudioVALL - Interval_" + DateTime.Now.ToShortDateString() + ".mp3\"");
                    lame.WaitForExit();
                    lbToolStrip.Text = "encoded merged wav file to mp3 file";

                    logic.cleanUp(filesSplit);
                    lbToolStrip.Text = "cleaned up splitted mp3 files";
                    logic.cleanUp(interval.output + interval.filename);
                    lbToolStrip.Text = "cleaned up merged mp3 file";
                    logic.cleanUp(interval.output + mergedFile);
                    lbToolStrip.Text = "cleaned up merged mp3 pattern file";

                    barToolStrip.Style = ProgressBarStyle.Blocks;
                    lbToolStrip.Text = "Ready";

                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("File successfully created.\n\nOpen containing folder?", "Interval Track Created", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe", interval.output);
                    }
                }
                else
                {
                    MessageBox.Show("Please add at least one Audio File to create an Interval Track!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                logic.showException("btGo_click", ex);
            }
        }

        private void listFiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                //removeItem();
            }
        }

        private void listFiles_SelectedValueChanged(object sender, EventArgs e)
        {
            //btRemoveFile.Enabled = false;
        }

        private void removeItem()
        {
            try
            {
                files.Remove(listFiles.SelectedItem.ToString());
                listFiles.Items.Remove(listFiles.SelectedItem);
                if (listFiles.Items.Count == 0)
                {
                    btRemoveFile.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                logic.showException("removeItem", ex);
            }
        }

        private void btRemoveFile_Click(object sender, EventArgs e)
        {
            //removeItem();
        }

        private void switchPositions(int oldPosition, int newPosition)
        {
            string temp = files[newPosition];
            files[newPosition] = files[oldPosition];
            files[oldPosition] = temp;
            drawFiles();
            listFiles.SelectedItem = listFiles.Items[newPosition];
        }

        private void btFileUp_Click(object sender, EventArgs e)
        {
            if (listFiles.SelectedItem != null && listFiles.SelectedIndex != 0)
            {
                switchPositions(listFiles.SelectedIndex, listFiles.SelectedIndex - 1);
            }
        }

        private void btFileDown_Click(object sender, EventArgs e)
        {
            if (listFiles.SelectedItem != null && listFiles.SelectedIndex != listFiles.Items.Count - 1)
            {
                switchPositions(listFiles.SelectedIndex, listFiles.SelectedIndex + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
