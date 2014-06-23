namespace Hearts_of_Oak_Packager
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
            this.components = new System.ComponentModel.Container();
            this.fbdCERoot = new System.Windows.Forms.FolderBrowserDialog();
            this.txbCERoot = new System.Windows.Forms.TextBox();
            this.btnCERootBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsbSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.includeFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreExtensionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreGameFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gameFolderPackSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGamePath = new System.Windows.Forms.Button();
            this.txbGamePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCompressGame = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.bwpMove = new System.ComponentModel.BackgroundWorker();
            this.btnBuild = new System.Windows.Forms.Button();
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrMtc = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cbxCompressionLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.settingscfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fbdCERoot
            // 
            this.fbdCERoot.ShowNewFolderButton = false;
            // 
            // txbCERoot
            // 
            this.txbCERoot.Location = new System.Drawing.Point(15, 66);
            this.txbCERoot.Name = "txbCERoot";
            this.txbCERoot.Size = new System.Drawing.Size(338, 20);
            this.txbCERoot.TabIndex = 0;
            this.txbCERoot.Text = "F:\\Projects\\Steam\\SteamApps\\common\\CRYENGINE";
            // 
            // btnCERootBrowse
            // 
            this.btnCERootBrowse.Location = new System.Drawing.Point(359, 64);
            this.btnCERootBrowse.Name = "btnCERootBrowse";
            this.btnCERootBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnCERootBrowse.TabIndex = 1;
            this.btnCERootBrowse.Text = "Browse...";
            this.btnCERootBrowse.UseVisualStyleBackColor = true;
            this.btnCERootBrowse.Click += new System.EventHandler(this.btnCERootBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hearts Of Oak CryEngine Root";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSettings,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsbSettings
            // 
            this.tsbSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.tsbSettings.Name = "tsbSettings";
            this.tsbSettings.Size = new System.Drawing.Size(37, 20);
            this.tsbSettings.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.includeFoldersToolStripMenuItem,
            this.ignoreExtensionsToolStripMenuItem,
            this.ignoreFoldersToolStripMenuItem,
            this.ignoreFilesToolStripMenuItem,
            this.ignoreGameFoldersToolStripMenuItem,
            this.toolStripSeparator2,
            this.gameFolderPackSettingToolStripMenuItem,
            this.settingscfgToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // includeFoldersToolStripMenuItem
            // 
            this.includeFoldersToolStripMenuItem.Name = "includeFoldersToolStripMenuItem";
            this.includeFoldersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.includeFoldersToolStripMenuItem.Text = "Include Folders";
            this.includeFoldersToolStripMenuItem.Click += new System.EventHandler(this.includeFoldersToolStripMenuItem_Click);
            // 
            // ignoreExtensionsToolStripMenuItem
            // 
            this.ignoreExtensionsToolStripMenuItem.Name = "ignoreExtensionsToolStripMenuItem";
            this.ignoreExtensionsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ignoreExtensionsToolStripMenuItem.Text = "Ignore Extensions";
            this.ignoreExtensionsToolStripMenuItem.Click += new System.EventHandler(this.ignoreExtensionsToolStripMenuItem_Click);
            // 
            // ignoreFoldersToolStripMenuItem
            // 
            this.ignoreFoldersToolStripMenuItem.Name = "ignoreFoldersToolStripMenuItem";
            this.ignoreFoldersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ignoreFoldersToolStripMenuItem.Text = "Ignore Folders";
            this.ignoreFoldersToolStripMenuItem.Click += new System.EventHandler(this.ignoreFoldersToolStripMenuItem_Click);
            // 
            // ignoreFilesToolStripMenuItem
            // 
            this.ignoreFilesToolStripMenuItem.Name = "ignoreFilesToolStripMenuItem";
            this.ignoreFilesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ignoreFilesToolStripMenuItem.Text = "Ignore Files";
            this.ignoreFilesToolStripMenuItem.Click += new System.EventHandler(this.ignoreFilesToolStripMenuItem_Click);
            // 
            // ignoreGameFoldersToolStripMenuItem
            // 
            this.ignoreGameFoldersToolStripMenuItem.Name = "ignoreGameFoldersToolStripMenuItem";
            this.ignoreGameFoldersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.ignoreGameFoldersToolStripMenuItem.Text = "Ignore Game Folders";
            this.ignoreGameFoldersToolStripMenuItem.Click += new System.EventHandler(this.ignoreGameFoldersToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // gameFolderPackSettingToolStripMenuItem
            // 
            this.gameFolderPackSettingToolStripMenuItem.Name = "gameFolderPackSettingToolStripMenuItem";
            this.gameFolderPackSettingToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.gameFolderPackSettingToolStripMenuItem.Text = "Game Folder Pack Setting ";
            // 
            // btnGamePath
            // 
            this.btnGamePath.Location = new System.Drawing.Point(359, 116);
            this.btnGamePath.Name = "btnGamePath";
            this.btnGamePath.Size = new System.Drawing.Size(75, 23);
            this.btnGamePath.TabIndex = 5;
            this.btnGamePath.Text = "Browse...";
            this.btnGamePath.UseVisualStyleBackColor = true;
            this.btnGamePath.Click += new System.EventHandler(this.btnGamePath_Click);
            // 
            // txbGamePath
            // 
            this.txbGamePath.Location = new System.Drawing.Point(15, 118);
            this.txbGamePath.Name = "txbGamePath";
            this.txbGamePath.Size = new System.Drawing.Size(338, 20);
            this.txbGamePath.TabIndex = 4;
            this.txbGamePath.Text = "F:\\Projects\\Steam\\SteamApps\\common\\CRYENGINE\\Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hearts Of Oak Game Path";
            // 
            // cbxCompressGame
            // 
            this.cbxCompressGame.AutoSize = true;
            this.cbxCompressGame.Checked = true;
            this.cbxCompressGame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxCompressGame.Location = new System.Drawing.Point(36, 144);
            this.cbxCompressGame.Name = "cbxCompressGame";
            this.cbxCompressGame.Size = new System.Drawing.Size(128, 17);
            this.cbxCompressGame.TabIndex = 7;
            this.cbxCompressGame.Text = "Compress Game Path";
            this.cbxCompressGame.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output Location";
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(359, 185);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 9;
            this.btnOutput.Text = "Browse...";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.Location = new System.Drawing.Point(15, 187);
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(338, 20);
            this.txbOutput.TabIndex = 8;
            this.txbOutput.Text = "F:\\Projects\\CRYENGINE\\OutputTest";
            // 
            // bwpMove
            // 
            this.bwpMove.WorkerReportsProgress = true;
            this.bwpMove.WorkerSupportsCancellation = true;
            this.bwpMove.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwpMove_DoWork);
            this.bwpMove.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwpMove_ProgressChanged);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(15, 213);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 11;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.AutoSize = true;
            this.lblFileStatus.Location = new System.Drawing.Point(15, 240);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(60, 13);
            this.lblFileStatus.TabIndex = 12;
            this.lblFileStatus.Text = "Current File";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 256);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(432, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 13;
            // 
            // tmrMtc
            // 
            this.tmrMtc.Enabled = true;
            this.tmrMtc.Tick += new System.EventHandler(this.tmrMtc_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(96, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 311);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 225);
            this.listBox1.TabIndex = 15;
            // 
            // cbxCompressionLevel
            // 
            this.cbxCompressionLevel.FormattingEnabled = true;
            this.cbxCompressionLevel.Items.AddRange(new object[] {
            "0",
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cbxCompressionLevel.Location = new System.Drawing.Point(308, 142);
            this.cbxCompressionLevel.Name = "cbxCompressionLevel";
            this.cbxCompressionLevel.Size = new System.Drawing.Size(45, 21);
            this.cbxCompressionLevel.TabIndex = 16;
            this.cbxCompressionLevel.SelectedIndexChanged += new System.EventHandler(this.cbxCompressionLevel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Compression";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Log";
            // 
            // settingscfgToolStripMenuItem
            // 
            this.settingscfgToolStripMenuItem.Name = "settingscfgToolStripMenuItem";
            this.settingscfgToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.settingscfgToolStripMenuItem.Text = "Settings.cfg";
            this.settingscfgToolStripMenuItem.Click += new System.EventHandler(this.settingscfgToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 545);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCompressionLevel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblFileStatus);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.cbxCompressGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGamePath);
            this.Controls.Add(this.txbGamePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCERootBrowse);
            this.Controls.Add(this.txbCERoot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Hearts Of Oak Packager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdCERoot;
        private System.Windows.Forms.TextBox txbCERoot;
        private System.Windows.Forms.Button btnCERootBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsbSettings;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnGamePath;
        private System.Windows.Forms.TextBox txbGamePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxCompressGame;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txbOutput;
        private System.ComponentModel.BackgroundWorker bwpMove;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmrMtc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cbxCompressionLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem includeFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreExtensionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreGameFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gameFolderPackSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingscfgToolStripMenuItem;
    }
}

