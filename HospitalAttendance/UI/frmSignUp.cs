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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            PasswordValidation();

        }
        void PasswordValidation()
        { 
            if(string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmaPassword.Text)){

                MessageBox.Show("Password cannot be empty","Invalid request",MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) && string.IsNullOrWhiteSpace(txtConfirmaPassword.Text))
            {

                MessageBox.Show("Password cannot be empty", "Invalid request", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (txtPassword.TextLength != txtConfirmaPassword.TextLength)
            {

                MessageBox.Show("Password and Confirmation password must match", "Invalid request", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (txtPassword.ToString() != txtConfirmaPassword.ToString())
            {

                MessageBox.Show("Password and Confirmation password must match", "Invalid request", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }
    }
}
