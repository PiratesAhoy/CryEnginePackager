using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Hearts_of_Oak_Packager
{
    public partial class EditSetting : Form
    {
        

        public EditSetting()
        {
            InitializeComponent();

        }

        private string _setting;
        private string _FileName;
        //private List<string> _items = new List<string>();
        BindingList<string> _list = new BindingList<string>();
        
        public string setting
        {
            get
            {
                return _setting;
            }

            set
            {
                _setting = value;
                _FileName = _setting + ".txt";
            }
        }

        void _list_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void EditSetting_Load(object sender, EventArgs e)
        {
            this.Text = "Edit " + _setting + " File";
           

            //load the file
            if (File.Exists(_FileName)) {
                AddRange(File.ReadAllLines(_FileName));
            }

            _list.ListChanged += _list_ListChanged;  
            //parse into the listbox
            lbxSettings.DataSource = _list;
            lbxSettings.Refresh();
            
        }

        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var i in collection) _list.Add(i);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _list.Add(txbAdd.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(_FileName, _list);
            btnSave.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbxSettings.SelectedItems.Count > 0)
            {
                btnRemove.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _list.Remove(lbxSettings.SelectedItem.ToString());
        }

        private void EditSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled)
            {
                string mbxText = "Do you want to save changes to settings file?";
                string mbxTitle = "Save " + _FileName + " settings";
                MessageBoxButtons mbxButton = MessageBoxButtons.YesNoCancel;
                MessageBoxIcon mbxIcon = MessageBoxIcon.Warning;
                DialogResult result = MessageBox.Show(mbxText, mbxTitle, mbxButton, mbxIcon);

                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        btnSave.PerformClick();
                        this.Close();
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
        }
    }
}
