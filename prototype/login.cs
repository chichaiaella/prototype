using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlLogin.BackColor = Color.FromArgb(120, 0, 0, 0);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
               if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
               {
                   LandingPage landingPage = new LandingPage();
                   landingPage.Show();
                   this.Hide();
               }
               else
               {
                   MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
