using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HospitalAttendance.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Quit",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)==DialogResult.Yes){
                Application.Exit();
            }
        }
    }
}
