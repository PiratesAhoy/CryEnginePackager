using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hearts_of_Oak_Packager
{
    public partial class EditSettingFile : Form
    {
        public EditSettingFile()
        {
            InitializeComponent();
        }

        public string strFileName;
        private List<_setting> FileSettings = new List<_setting>();
        BindingList<_setting> _datasource = new BindingList<_setting>();
        List<ListViewItem> _list = new List<ListViewItem>();
        public string _path; 

        private void EditSettingFile_Load(object sender, EventArgs e)
        {
            
            Form1.GetSettings(_path + "\\" + strFileName + ".cfg", FileSettings);
            foreach (_setting s in FileSettings)
            {
                _list.Add(new ListViewItem(new string[] { s._name, s._value }));
                lsvSettings.Items.Add(new ListViewItem(new string[] { s._name, s._value }));
            }
        }
    }
}
