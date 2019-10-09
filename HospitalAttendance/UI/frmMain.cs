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
            ExitConfirmation();
        }
        void ExitConfirmation() 
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(1,68);
            btnDashboard.ForeColor = Color.FromArgb(29, 118, 186);
            btnAttendance.ForeColor = Color.White;
            btnSettings.ForeColor = Color.White;
            btnUsers.ForeColor = Color.White;
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(0, 115);
            btnAttendance.ForeColor = Color.FromArgb(29, 118, 186);
            btnDashboard.ForeColor = Color.White;
            btnSettings.ForeColor = Color.White;
            btnUsers.ForeColor = Color.White;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(1,162);
            btnSettings.ForeColor = Color.FromArgb(29, 118, 186);
            btnAttendance.ForeColor = Color.White;
            btnDashboard.ForeColor = Color.White;
            btnUsers.ForeColor = Color.White;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(1,210);
            btnUsers.ForeColor = Color.FromArgb(29, 118, 186);
            btnAttendance.ForeColor = Color.White;
            btnSettings.ForeColor = Color.White;
            btnDashboard.ForeColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            sidePanel.Location = new Point(1,257);
            ExitConfirmation();
        }

        private void btnAttendance_MouseHover(object sender, EventArgs e)
        {
            btnAttendance.ForeColor = Color.FromArgb(29, 118, 186);
            btnDashboard.ForeColor = Color.White;
            btnSettings.ForeColor = Color.White;
            btnUsers.ForeColor = Color.White;
        }

        private void btnAttendance_MouseLeave(object sender, EventArgs e)
        {
            btnAttendance.ForeColor = Color.White;
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.FromArgb(29, 118, 186);
            btnAttendance.ForeColor = Color.White;
            btnSettings.ForeColor = Color.White;
            btnUsers.ForeColor = Color.White;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.ForeColor = Color.White;
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            btnSettings.ForeColor = Color.FromArgb(29, 118, 186);
            btnAttendance.ForeColor = Color.White;
            btnDashboard.ForeColor = Color.White;
            btnUsers.ForeColor = Color.White;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.ForeColor = Color.White;
        }

        private void btnUsers_MouseHover(object sender, EventArgs e)
        {
            btnUsers.ForeColor = Color.FromArgb(29, 118, 186);
            btnAttendance.ForeColor = Color.White;
            btnSettings.ForeColor = Color.White;
            btnDashboard.ForeColor = Color.White;
        }

        private void btnUsers_MouseLeave(object sender, EventArgs e)
        {
            btnUsers.ForeColor = Color.White;
        }
    }
}
