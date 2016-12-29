namespace audioval
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listFiles = new System.Windows.Forms.ListBox();
            this.lbFilename = new System.Windows.Forms.Label();
            this.btAddFiles = new System.Windows.Forms.Button();
            this.txFilename = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbToolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.barToolStrip = new System.Windows.Forms.ToolStripProgressBar();
            this.groupFileInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAudioLength = new System.Windows.Forms.Label();
            this.lbTotalLength = new System.Windows.Forms.Label();
            this.lbTotalFiles = new System.Windows.Forms.Label();
            this.btGo = new System.Windows.Forms.Button();
            this.lbInterval = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCooldown = new System.Windows.Forms.Label();
            this.lbWarmup = new System.Windows.Forms.Label();
            this.cbCooldown = new System.Windows.Forms.ComboBox();
            this.cbWarmup = new System.Windows.Forms.ComboBox();
            this.btRemoveFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btFileDown = new System.Windows.Forms.Button();
            this.btFileUp = new System.Windows.Forms.Button();
            this.cbRest = new System.Windows.Forms.ComboBox();
            this.lbRest = new System.Windows.Forms.Label();
            this.cbRun = new System.Windows.Forms.ComboBox();
            this.lbRun = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupFileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFiles
            // 
            this.listFiles.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listFiles.ForeColor = System.Drawing.Color.White;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(12, 16);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(524, 264);
            this.listFiles.TabIndex = 0;
            this.listFiles.SelectedValueChanged += new System.EventHandler(this.listFiles_SelectedValueChanged);
            this.listFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listFiles_KeyDown);
            // 
            // lbFilename
            // 
            this.lbFilename.AutoSize = true;
            this.lbFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilename.ForeColor = System.Drawing.Color.White;
            this.lbFilename.Location = new System.Drawing.Point(12, 320);
            this.lbFilename.Name = "lbFilename";
            this.lbFilename.Size = new System.Drawing.Size(64, 16);
            this.lbFilename.TabIndex = 1;
            this.lbFilename.Text = "Filename";
            // 
            // btAddFiles
            // 
            this.btAddFiles.Location = new System.Drawing.Point(416, 284);
            this.btAddFiles.Name = "btAddFiles";
            this.btAddFiles.Size = new System.Drawing.Size(120, 23);
            this.btAddFiles.TabIndex = 5;
            this.btAddFiles.Text = "Add Files";
            this.btAddFiles.UseVisualStyleBackColor = true;
            this.btAddFiles.Click += new System.EventHandler(this.btAddFiles_Click);
            // 
            // txFilename
            // 
            this.txFilename.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txFilename.ForeColor = System.Drawing.Color.White;
            this.txFilename.Location = new System.Drawing.Point(96, 316);
            this.txFilename.Name = "txFilename";
            this.txFilename.Size = new System.Drawing.Size(220, 20);
            this.txFilename.TabIndex = 6;
            this.txFilename.TextChanged += new System.EventHandler(this.txFilename_TextChanged);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(336, 432);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 8;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbToolStrip,
            this.barToolStrip});
            this.statusStrip1.Location = new System.Drawing.Point(0, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(548, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbToolStrip
            // 
            this.lbToolStrip.BackColor = System.Drawing.SystemColors.Control;
            this.lbToolStrip.Name = "lbToolStrip";
            this.lbToolStrip.Size = new System.Drawing.Size(45, 17);
            this.lbToolStrip.Text = "Ready  ";
            // 
            // barToolStrip
            // 
            this.barToolStrip.Name = "barToolStrip";
            this.barToolStrip.Size = new System.Drawing.Size(450, 16);
            this.barToolStrip.Step = 100;
            // 
            // groupFileInfo
            // 
            this.groupFileInfo.Controls.Add(this.label1);
            this.groupFileInfo.Controls.Add(this.label5);
            this.groupFileInfo.Controls.Add(this.label6);
            this.groupFileInfo.Controls.Add(this.label7);
            this.groupFileInfo.Controls.Add(this.lbAudioLength);
            this.groupFileInfo.Controls.Add(this.lbTotalLength);
            this.groupFileInfo.Controls.Add(this.lbTotalFiles);
            this.groupFileInfo.Location = new System.Drawing.Point(272, 44);
            this.groupFileInfo.Name = "groupFileInfo";
            this.groupFileInfo.Size = new System.Drawing.Size(208, 16);
            this.groupFileInfo.TabIndex = 10;
            this.groupFileInfo.TabStop = false;
            this.groupFileInfo.Text = "File Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOT YET IMPLEMENTED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "NOT YET IMPLEMENTED";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "NOT YET IMPLEMENTED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Intervals:";
            // 
            // lbAudioLength
            // 
            this.lbAudioLength.AutoSize = true;
            this.lbAudioLength.Location = new System.Drawing.Point(16, 76);
            this.lbAudioLength.Name = "lbAudioLength";
            this.lbAudioLength.Size = new System.Drawing.Size(70, 13);
            this.lbAudioLength.TabIndex = 12;
            this.lbAudioLength.Text = "Audio Length";
            // 
            // lbTotalLength
            // 
            this.lbTotalLength.AutoSize = true;
            this.lbTotalLength.Location = new System.Drawing.Point(16, 52);
            this.lbTotalLength.Name = "lbTotalLength";
            this.lbTotalLength.Size = new System.Drawing.Size(70, 13);
            this.lbTotalLength.TabIndex = 13;
            this.lbTotalLength.Text = "Total Length:";
            // 
            // lbTotalFiles
            // 
            this.lbTotalFiles.AutoSize = true;
            this.lbTotalFiles.Location = new System.Drawing.Point(16, 28);
            this.lbTotalFiles.Name = "lbTotalFiles";
            this.lbTotalFiles.Size = new System.Drawing.Size(58, 13);
            this.lbTotalFiles.TabIndex = 14;
            this.lbTotalFiles.Text = "Total Files:";
            // 
            // btGo
            // 
            this.btGo.Location = new System.Drawing.Point(416, 432);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(123, 23);
            this.btGo.TabIndex = 18;
            this.btGo.Text = "Create Interval Track";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // lbInterval
            // 
            this.lbInterval.AutoSize = true;
            this.lbInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInterval.ForeColor = System.Drawing.Color.White;
            this.lbInterval.Location = new System.Drawing.Point(12, 348);
            this.lbInterval.Name = "lbInterval";
            this.lbInterval.Size = new System.Drawing.Size(51, 16);
            this.lbInterval.TabIndex = 20;
            this.lbInterval.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Optional";
            // 
            // lbCooldown
            // 
            this.lbCooldown.AutoSize = true;
            this.lbCooldown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCooldown.ForeColor = System.Drawing.Color.White;
            this.lbCooldown.Location = new System.Drawing.Point(12, 404);
            this.lbCooldown.Name = "lbCooldown";
            this.lbCooldown.Size = new System.Drawing.Size(73, 16);
            this.lbCooldown.TabIndex = 22;
            this.lbCooldown.Text = "Cool Down";
            // 
            // lbWarmup
            // 
            this.lbWarmup.AutoSize = true;
            this.lbWarmup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarmup.ForeColor = System.Drawing.Color.White;
            this.lbWarmup.Location = new System.Drawing.Point(12, 376);
            this.lbWarmup.Name = "lbWarmup";
            this.lbWarmup.Size = new System.Drawing.Size(65, 16);
            this.lbWarmup.TabIndex = 23;
            this.lbWarmup.Text = "Warm Up";
            // 
            // cbCooldown
            // 
            this.cbCooldown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbCooldown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCooldown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCooldown.ForeColor = System.Drawing.Color.White;
            this.cbCooldown.Items.AddRange(new object[] {
            "0 min"});
            this.cbCooldown.Location = new System.Drawing.Point(96, 400);
            this.cbCooldown.Name = "cbCooldown";
            this.cbCooldown.Size = new System.Drawing.Size(220, 21);
            this.cbCooldown.TabIndex = 24;
            // 
            // cbWarmup
            // 
            this.cbWarmup.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbWarmup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWarmup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbWarmup.ForeColor = System.Drawing.Color.White;
            this.cbWarmup.Items.AddRange(new object[] {
            "0 min"});
            this.cbWarmup.Location = new System.Drawing.Point(96, 372);
            this.cbWarmup.Name = "cbWarmup";
            this.cbWarmup.Size = new System.Drawing.Size(220, 21);
            this.cbWarmup.TabIndex = 25;
            // 
            // btRemoveFile
            // 
            this.btRemoveFile.Enabled = false;
            this.btRemoveFile.Location = new System.Drawing.Point(336, 284);
            this.btRemoveFile.Name = "btRemoveFile";
            this.btRemoveFile.Size = new System.Drawing.Size(75, 23);
            this.btRemoveFile.TabIndex = 26;
            this.btRemoveFile.Text = "Remove File";
            this.btRemoveFile.UseVisualStyleBackColor = true;
            this.btRemoveFile.Click += new System.EventHandler(this.btRemoveFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(320, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Add 3 Tracks or more";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Add 5 Tracks or more";
            // 
            // btFileDown
            // 
            this.btFileDown.Location = new System.Drawing.Point(92, 284);
            this.btFileDown.Name = "btFileDown";
            this.btFileDown.Size = new System.Drawing.Size(75, 23);
            this.btFileDown.TabIndex = 30;
            this.btFileDown.Text = "File Down";
            this.btFileDown.UseVisualStyleBackColor = true;
            this.btFileDown.Click += new System.EventHandler(this.btFileDown_Click);
            // 
            // btFileUp
            // 
            this.btFileUp.Location = new System.Drawing.Point(12, 284);
            this.btFileUp.Name = "btFileUp";
            this.btFileUp.Size = new System.Drawing.Size(75, 23);
            this.btFileUp.TabIndex = 31;
            this.btFileUp.Text = "File Up";
            this.btFileUp.UseVisualStyleBackColor = true;
            this.btFileUp.Click += new System.EventHandler(this.btFileUp_Click);
            // 
            // cbRest
            // 
            this.cbRest.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbRest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRest.ForeColor = System.Drawing.Color.White;
            this.cbRest.FormattingEnabled = true;
            this.cbRest.Items.AddRange(new object[] {
            "05 sec",
            "10 sec",
            "15 sec",
            "20 sec",
            "25 sec",
            "30 sec",
            "35 sec",
            "40 sec",
            "45 sec",
            "50 sec",
            "55 sec",
            "60 sec",
            "65 sec",
            "70 sec",
            "75 sec",
            "80 sec",
            "85 sec",
            "90 sec"});
            this.cbRest.Location = new System.Drawing.Point(248, 344);
            this.cbRest.Name = "cbRest";
            this.cbRest.Size = new System.Drawing.Size(65, 21);
            this.cbRest.TabIndex = 35;
            // 
            // lbRest
            // 
            this.lbRest.AutoSize = true;
            this.lbRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest.ForeColor = System.Drawing.Color.White;
            this.lbRest.Location = new System.Drawing.Point(208, 348);
            this.lbRest.Name = "lbRest";
            this.lbRest.Size = new System.Drawing.Size(36, 16);
            this.lbRest.TabIndex = 33;
            this.lbRest.Text = "Rest";
            // 
            // cbRun
            // 
            this.cbRun.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbRun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRun.ForeColor = System.Drawing.Color.White;
            this.cbRun.FormattingEnabled = true;
            this.cbRun.Items.AddRange(new object[] {
            "05 sec",
            "10 sec",
            "15 sec",
            "20 sec",
            "25 sec",
            "30 sec",
            "35 sec",
            "40 sec",
            "45 sec",
            "50 sec",
            "55 sec",
            "60 sec",
            "65 sec",
            "70 sec",
            "75 sec",
            "80 sec",
            "85 sec",
            "90 sec"});
            this.cbRun.Location = new System.Drawing.Point(132, 344);
            this.cbRun.Name = "cbRun";
            this.cbRun.Size = new System.Drawing.Size(65, 21);
            this.cbRun.TabIndex = 34;
            // 
            // lbRun
            // 
            this.lbRun.AutoSize = true;
            this.lbRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRun.ForeColor = System.Drawing.Color.White;
            this.lbRun.Location = new System.Drawing.Point(96, 348);
            this.lbRun.Name = "lbRun";
            this.lbRun.Size = new System.Drawing.Size(32, 16);
            this.lbRun.TabIndex = 32;
            this.lbRun.Text = "Run";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "alt interval";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(548, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbRest);
            this.Controls.Add(this.cbRun);
            this.Controls.Add(this.lbRest);
            this.Controls.Add(this.lbRun);
            this.Controls.Add(this.btFileUp);
            this.Controls.Add(this.btFileDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btRemoveFile);
            this.Controls.Add(this.cbWarmup);
            this.Controls.Add(this.cbCooldown);
            this.Controls.Add(this.lbWarmup);
            this.Controls.Add(this.lbCooldown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInterval);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.txFilename);
            this.Controls.Add(this.btAddFiles);
            this.Controls.Add(this.lbFilename);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.groupFileInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "audioVALL";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupFileInfo.ResumeLayout(false);
            this.groupFileInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Label lbFilename;
        private System.Windows.Forms.Button btAddFiles;
        private System.Windows.Forms.TextBox txFilename;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbToolStrip;
        private System.Windows.Forms.GroupBox groupFileInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAudioLength;
        private System.Windows.Forms.Label lbTotalLength;
        private System.Windows.Forms.Label lbTotalFiles;
        private System.Windows.Forms.Button btGo;
        public System.Windows.Forms.ToolStripProgressBar barToolStrip;
        private System.Windows.Forms.Label lbInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCooldown;
        private System.Windows.Forms.Label lbWarmup;
        private System.Windows.Forms.ComboBox cbCooldown;
        private System.Windows.Forms.ComboBox cbWarmup;
        private System.Windows.Forms.Button btRemoveFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btFileDown;
        private System.Windows.Forms.Button btFileUp;
        private System.Windows.Forms.ComboBox cbRest;
        private System.Windows.Forms.Label lbRest;
        private System.Windows.Forms.ComboBox cbRun;
        private System.Windows.Forms.Label lbRun;
        private System.Windows.Forms.Button button1;
    }
}

