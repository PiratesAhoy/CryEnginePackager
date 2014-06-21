using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Hearts_of_Oak_Packager
{
    public partial class Form1 : Form
    {
        int cLevel;
        public List<string> IncludeFolders = new List<string>();
        public List<string> IgnoreExtensions = new List<string>();
        public List<string> IgnoreFolders = new List<string>();
        public List<string> IgnoreFiles = new List<string>();
        public List<string> IgnoreCompress = new List<string>();
        
        public Form1()
        {
            InitializeComponent();

            cbxCompressionLevel.SelectedItem = "9";

            FillListFromFile("IncludeFolders.txt", IncludeFolders);
            FillListFromFile("IgnoreExtensions.txt", IgnoreExtensions);
            FillListFromFile("IgnoreFolders.txt", IgnoreFolders);
            FillListFromFile("IgnoreFiles.txt", IgnoreFiles);
            FillListFromFile("IgnoreCompress.txt", IgnoreCompress);

        }

        void FillListFromFile(string txtFile, List<string> _list)
        {
            if (File.Exists(txtFile))
            {
                AddRange(File.ReadAllLines(txtFile), _list);
            }
        }

        public void AddRange(IEnumerable<string> collection, List<string> _list)
        {
            foreach (var i in collection) _list.Add(i);
        }
        
        private void btnCERootBrowse_Click(object sender, EventArgs e)
        {
            fbdCERoot.ShowNewFolderButton = false;
            fbdCERoot.ShowDialog();
            txbCERoot.Text = fbdCERoot.SelectedPath.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveSettings()
        {


        }

        private void btnGamePath_Click(object sender, EventArgs e)
        {
            fbdCERoot.ShowNewFolderButton = false;
            fbdCERoot.ShowDialog();
            txbGamePath.Text = fbdCERoot.SelectedPath.ToString();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            fbdCERoot.ShowNewFolderButton = true;
            fbdCERoot.ShowDialog();
            txbOutput.Text = fbdCERoot.SelectedPath.ToString();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            if (!bwpMove.IsBusy)
            {
                bwpMove.RunWorkerAsync();
            }
        }

        
        private void bwpMove_DoWork(object sender, DoWorkEventArgs e)
        {
            //DirectoryCopy(txbCERoot.Text, txbOutput.Text, false);
            foreach (string f in Directory.GetFiles(txbCERoot.Text))
            {
                FileInfo fName = new FileInfo(@f);
                if (!IgnoreExtensions.Any(fName.Extension.Contains) && !IgnoreFiles.Any(fName.Name.Contains))
                File.Copy(f, txbOutput.Text + "\\" + fName.Name, true);
            }

            //move all of the main paths except for the game folder
            foreach (String d in Directory.GetDirectories(txbCERoot.Text))
            {
                string sPath = new DirectoryInfo(@d).Name;
                string oPath = txbOutput.Text + "\\" + sPath;
                if (IncludeFolders.Any(sPath.Contains))
                {
                    //recursively move files from this path to the output folder
                    DirectoryCopy(d, oPath, true);
                    bwpReport(sPath + " copied", true);
                }
            };

            string iPath = new DirectoryInfo(txbGamePath.Text).Name;
            string ogPath = txbOutput.Text + "\\" + iPath; 
            if (!Directory.Exists(ogPath)) {Directory.CreateDirectory(ogPath);};
            foreach (string d in Directory.GetDirectories(txbGamePath.Text))
            {
                string dPath = new DirectoryInfo(@d).Name;
                               
                if (bwpMove.CancellationPending) { return; };

                foreach (string f in Directory.GetFiles(txbGamePath.Text))
                {
                    FileInfo fName = new FileInfo(@f);
                    if (!IgnoreExtensions.Any(fName.Extension.Contains) && !IgnoreFiles.Any(fName.Name.Contains))
                        File.Copy(f, ogPath + "\\" + fName.Name, true);
                }

                if (cbxCompressGame.Checked)
                {
                    //if (!Directory.Exists(ogPath + "\\" + dPath)) { Directory.CreateDirectory(ogPath + "\\" + dPath); };
                    //DirectoryCopy(d, ogPath + "\\" + dPath + "\\" + dPath, true);

                    //bwpReport(dPath + " copied", true);

                    if (!IgnoreCompress.Any(dPath.Contains))
                    {
                        if (!Directory.Exists(ogPath + "\\" + dPath)) { Directory.CreateDirectory(ogPath + "\\" + dPath); };
                        DirectoryCopy(d, ogPath + "\\" + dPath + "\\" + dPath, true);

                        bwpReport("Compressing game pak " + dPath);
                        //if (!Directory.Exists(ogPath + "\\" + dPath + "\\" + dPath)) { Directory.CreateDirectory(ogPath + "\\" + dPath + "\\" + dPath); };
                        //Directory.Move(ogPath + "\\" + dPath, ogPath + "\\" + dPath + "\\" + dPath);

                        string excludes = "";
                        foreach (string sI in IgnoreExtensions)
                        {
                            excludes += " -x!*" + sI;
                        }

                        foreach (string sI in IgnoreFiles)
                        {
                            excludes += " -x!" + sI;
                        }

                        string pClean = ogPath + "\\" + dPath + "\\*.* ";
                        Process p = new Process();
                        p.StartInfo.Verb = "runas";
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        p.StartInfo.FileName = "7za.exe";
                        p.StartInfo.Arguments = "a -tzip -r -mx" + cLevel + " " + ogPath + "\\" + dPath + ".pak " + pClean + excludes;
                        p.Start();
                        p.WaitForExit();
                        bwpReport(dPath + " packed", true);
                    
                        try
                        {
                            Directory.Delete(ogPath + "\\" + dPath, true);
                        }
                        catch (Exception)
                        {
                            throw;
                        }

                    }
                    else
                    {
                        DirectoryCopy(d, ogPath + "\\" + dPath, true);
                        bwpReport(dPath + " copied", true);
                    }
                     

                } 
                else
                {
                    DirectoryCopy(d, ogPath + "\\" + dPath, true);
                    bwpReport(dPath + " copied", true);
                }
                
            }

            //DirectoryCopy(txbGamePath.Text, txbOutput.Text + "\\Game", true);

            //if (bwpMove.CancellationPending) { return; };

            ////pack all of the folders in the game directory
            //if (cbxCompressGame.Checked)
            //{
            //    // get the output game folder
            //    foreach (string d in Directory.GetDirectories(txbOutput.Text + "\\Game"))
            //    {
            //        string zPath = new DirectoryInfo(@d).Name;
            //        bwpReport("Compressing game pak " + zPath);
            //        Zipper z = new Zipper();
            //        z.ZipFile = @txbOutput.Text + "\\Game\\" + zPath + ".pak";
            //        z.ItemList.Add(@"*.*");
            //        z.ExcludeFollowing.Add(FileHelper.IgnoreExtensions);
            //        z.PathInZip = enPathInZip.Relative;
            //        z.Recurse = true;
            //        z.Zip();
            //    }
            //}
        }



        private void bwpReport(string msg)
        {
            bwpMove.ReportProgress(0, msg);
        }

        private void bwpReport(string msg, bool logme)
        {
            int iP = 0;
            if (logme) { iP = 1; };
            bwpMove.ReportProgress(iP, msg);
        }

        private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            if (bwpMove.CancellationPending)
            {
                return;
            }
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                bwpReport("Source directory does not exist or could not be found: "
                    + sourceDirName);
                //throw new DirectoryNotFoundException(
                //    "Source directory does not exist or could not be found: "
                //    + sourceDirName);
            }

            // If the destination directory doesn't exist, create it. 
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                if (!IgnoreExtensions.Any(file.Extension.Contains) && !IgnoreFiles.Any(file.Name.Contains))
                {
                    string temppath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(temppath, true);
                    bwpReport("Copying " + file.Name);
                }
                
            }

            // If copying subdirectories, copy them and their contents to new location. 
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    if (!IgnoreFolders.Any(subdir.Name.ToLower().Equals)) {
                        string temppath = Path.Combine(destDirName, subdir.Name);
                        DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                    }
                }
            }
        }

        private void bwpMove_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                
                listBox1.Items.Insert(0,e.UserState.ToString());
            }
            else
            {
                lblFileStatus.Text = e.UserState.ToString();
            }

        }

        private void tmrMtc_Tick(object sender, EventArgs e)
        {
            if (bwpMove.IsBusy)
            {
                btnBuild.Enabled = false;
                lblFileStatus.Visible = true;
                progressBar1.Visible = true;
                btnCancel.Enabled = true;
                if (progressBar1.Value > 99) { progressBar1.Value = 1; }
                progressBar1.Value += 1;
            }
            else
            {
                btnBuild.Enabled = true;
                btnCancel.Enabled = false;
                lblFileStatus.Visible = false;
                progressBar1.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (bwpMove.IsBusy)
            {
                bwpMove.CancelAsync();
            }
        }

        private void cbxCompressionLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cLevel = Convert.ToInt16(cbxCompressionLevel.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void includeFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSetting("IncludeFolders");
        }

        private void OpenSetting(string SettingName)
        {
            EditSetting f = new EditSetting();
            f.setting = SettingName;
            f.ShowDialog();
        }

        private void ignoreExtensionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSetting("IgnoreExtensions");
        }

        private void ignoreFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSetting("IgnoreFolders");
        }

        private void ignoreFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSetting("IgnoreFiles");
        }

        private void ignoreGameFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSetting("IgnoreCompress");
        }

    }
}
