using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Capa_de_Presentacion
{


    public partial class test : Form
  
    {
        private FolderBrowserDialog source_FolderBrowsing = new FolderBrowserDialog();
        private FolderBrowserDialog target_FolderBrowsing = new FolderBrowserDialog();
        
        int first_selected_extiontion = 0;
        int NumOfSelectedFiles = 0;
        int code_time_started = -1;
        string Report_path;
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void lblAbout(object sender, EventArgs e)
        {

        }
    }
}
