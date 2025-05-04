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
    public partial class LandingPage: Form
    {
        UserControls.UCHome ucHome = new UserControls.UCHome();
        UserControls.UCGrades ucGrades = new UserControls.UCGrades();
        UserControls.UCAbout ucAbout = new UserControls.UCAbout();
        public LandingPage()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucHome);
            ucHome.Dock = DockStyle.Fill;

        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucHome);
            ucHome.Dock = DockStyle.Fill;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucGrades);
            ucGrades.Dock = DockStyle.Fill;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(ucAbout);
            ucAbout.Dock = DockStyle.Fill;
        }

        private void LandingPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login = new Form1();
            login.Show();

            this.Hide();
        }
    }
}
