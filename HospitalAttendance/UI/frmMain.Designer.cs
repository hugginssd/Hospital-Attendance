namespace HospitalAttendance.UI
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCancel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUsers = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.userDashboard1 = new HospitalAttendance.UI.userDashboard();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-7, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 688);
            this.panel1.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel15.Controls.Add(this.sidePanel);
            this.panel15.Controls.Add(this.btnExit);
            this.panel15.Controls.Add(this.panel13);
            this.panel15.Controls.Add(this.btnUsers);
            this.panel15.Controls.Add(this.btnSettings);
            this.panel15.Controls.Add(this.btnAttendance);
            this.panel15.Controls.Add(this.btnDashboard);
            this.panel15.Location = new System.Drawing.Point(7, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(204, 688);
            this.panel15.TabIndex = 5;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettings.Location = new System.Drawing.Point(-4, 200);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(205, 55);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnSettings.MouseHover += new System.EventHandler(this.btnSettings_MouseHover);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttendance.Location = new System.Drawing.Point(0, 142);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(200, 55);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "ATTENDANCE";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            this.btnAttendance.MouseLeave += new System.EventHandler(this.btnAttendance_MouseLeave);
            this.btnAttendance.MouseHover += new System.EventHandler(this.btnAttendance_MouseHover);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.Location = new System.Drawing.Point(-4, 84);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(205, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.btnDashboard_MouseLeave);
            this.btnDashboard.MouseHover += new System.EventHandler(this.btnDashboard_MouseHover);
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.Controls.Add(this.pictureBox1);
            this.panel13.Location = new System.Drawing.Point(2, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(202, 81);
            this.panel13.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(209, 59);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1105, 629);
            this.panel9.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Location = new System.Drawing.Point(209, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1105, 568);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1105, 568);
            this.panel11.TabIndex = 3;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel12.Location = new System.Drawing.Point(8, 8);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1105, 568);
            this.panel12.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 53);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1105, 53);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1105, 53);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.lblCancel);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(202, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1343, 61);
            this.panel5.TabIndex = 2;
            // 
            // lblCancel
            // 
            this.lblCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCancel.Location = new System.Drawing.Point(1318, 3);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(19, 20);
            this.lblCancel.TabIndex = 2;
            this.lblCancel.Text = "X";
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(209, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1105, 0);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1105, 0);
            this.panel7.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Location = new System.Drawing.Point(8, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1105, 0);
            this.panel8.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel14.Controls.Add(this.userDashboard1);
            this.panel14.Location = new System.Drawing.Point(204, 64);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1341, 594);
            this.panel14.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel16.Controls.Add(this.label1);
            this.panel16.Location = new System.Drawing.Point(198, 659);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1349, 29);
            this.panel16.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(403, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright @ 2019 Hospital Attendance";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HospitalAttendance.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUsers.Location = new System.Drawing.Point(-7, 258);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(210, 55);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = "USERS";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnUsers_MouseLeave);
            this.btnUsers.MouseHover += new System.EventHandler(this.btnUsers_MouseHover);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.DodgerBlue;
            this.sidePanel.Location = new System.Drawing.Point(1, 84);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(12, 55);
            this.sidePanel.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(-7, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 55);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hospital Attendance";
            // 
            // userDashboard1
            // 
            this.userDashboard1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userDashboard1.Location = new System.Drawing.Point(4, 5);
            this.userDashboard1.Name = "userDashboard1";
            this.userDashboard1.Size = new System.Drawing.Size(1327, 586);
            this.userDashboard1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1547, 688);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label1;
        private userDashboard userDashboard1;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}