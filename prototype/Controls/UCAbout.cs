using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype.UserControls
{
    public partial class UCAbout: UserControl
    {
        public UCAbout()
        {
            InitializeComponent();
        }

        private void UCAbout_Load(object sender, EventArgs e)
        {
            string about = "About This System";
            lblAbout.Text = about;
            string AboutDetails = "University Grade System\nVersion: 1.0.0\nDeveloped By:\n        Keane Ahron Hiligan - FrontEnd\n" +
                "         Nigie Tenebroso - BackEnd\nRelease Date: May 8, 2025";
            lblAboutDetails.Text = AboutDetails;

            string porpurpose = "This system is designed to help university staff easily manage student academic records. It allows input, update,\nand deletion of student details and final grades across different subjects.";
            lblPurposeDetails.Text = porpurpose;

            string featureDetails = "📄 Input student information: First name, last name, middle initial, and program.\r\n📚 Enter final grades for core university subjects.\r\n🔄 Update or delete individual records.\r\n🗑 Delete all records at once with a single click.\r\n🖥 Clean and user-friendly interface for efficient data entry and management.";
            lblFeatDetails.Text = featureDetails;


            string Nav = "1. Home: Displays the main dashboard.\n" +
                "2. Student: Allows input and management of student information and Grades.\n" +
                "3. About: Provides information about the system and its purpose.";
            lblNavDesc.Text = Nav;


            string contact = "For questions or technical support, contact:\r\n📧 Email: support@university.edu\r\n📞 Phone: (123) 456-7890";
            lblConSupDetails.Text = contact;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
