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
    public partial class UCGrades : UserControl
    {
        string remarks;
        public UCGrades()
        {
            InitializeComponent();
        }

        private void UCGrades_Load(object sender, EventArgs e)
        {
            listStudent.Columns.Add("FirstName", 90);
            listStudent.Columns.Add("LastName", 90);
            listStudent.Columns.Add("MiddleName", 40);
            listStudent.Columns.Add("Program", 70);
            listStudent.Columns.Add("Copro", 55);
            listStudent.Columns.Add("Animul", 55);
            listStudent.Columns.Add("Distru", 55);
            listStudent.Columns.Add("Mathmod", 55);
            listStudent.Columns.Add("Purcomm", 55);
            listStudent.Columns.Add("Art App", 55);
            listStudent.Columns.Add("NSTP 2", 55);
            listStudent.Columns.Add("PAFIT 2", 55);
            listStudent.Columns.Add("Average", 55);
            listStudent.Columns.Add("Remarks", 80);
        }

        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstname.Text == "" || txtMiddleName.Text == "" || txtProgram.Text == "" ||
                txtCopro.Text == "" || txtAnimul.Text == "" || txtDistru.Text == "" || txtMath.Text == "" ||
                txtPurcom.Text == "" || txtArtapp.Text == "" || txtNstp.Text == "" || txtPafit.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else { 
                var average = (Convert.ToDouble(txtCopro.Text) + Convert.ToDouble(txtAnimul.Text) + Convert.ToSingle(txtDistru.Text) +
                    Convert.ToSingle(txtMath.Text) + Convert.ToSingle(txtPurcom.Text) + Convert.ToSingle(txtArtapp.Text) +
                    Convert.ToSingle(txtNstp.Text) + Convert.ToSingle(txtPafit.Text)) / 8;
                if (average <= 1)
                {
                    remarks = "Outsanding";
                }
                else if (average <= 2)
                {
                    remarks = "Highly Average";
                }
                else if (average <= 3)
                {
                    remarks = "Average";
                }
                else if (average <= 4)
                {
                    remarks = "Needs Improvement";
                }
                else if (average <= 5)
                {
                    remarks = "Failed";
                }
                else
                {
                    remarks = "Invalid Input";
                }
            ListViewItem newitem = new ListViewItem(txtFirstname.Text);
            var averageString = Convert.ToString(average);
            newitem.SubItems.Add(txtLastName.Text);
            newitem.SubItems.Add(txtMiddleName.Text);
            newitem.SubItems.Add(txtProgram.Text);
            newitem.SubItems.Add(txtCopro.Text);
            newitem.SubItems.Add(txtAnimul.Text);
            newitem.SubItems.Add(txtDistru.Text);
            newitem.SubItems.Add(txtMath.Text);
            newitem.SubItems.Add(txtPurcom.Text);
            newitem.SubItems.Add(txtArtapp.Text);
            newitem.SubItems.Add(txtNstp.Text);
            newitem.SubItems.Add(txtPafit.Text);
            newitem.SubItems.Add( averageString);
            newitem.SubItems.Add(remarks);
            listStudent.Items.Add(newitem);

            
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtFirstname.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtProgram.Clear();
            txtCopro.Clear();
            txtAnimul.Clear();
            txtDistru.Clear();
            txtMath.Clear();
            txtPurcom.Clear();
            txtArtapp.Clear();
            txtNstp.Clear();
            txtPafit.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstname.Text == "" || txtMiddleName.Text == "" || txtProgram.Text == "" ||
                txtCopro.Text == "" || txtAnimul.Text == "" || txtDistru.Text == "" || txtMath.Text == "" ||
                txtPurcom.Text == "" || txtArtapp.Text == "" || txtNstp.Text == "" || txtPafit.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                if (listStudent.SelectedItems.Count > 0)
                {
                    var average = (Convert.ToSingle(txtCopro.Text) + Convert.ToSingle(txtAnimul.Text) + Convert.ToSingle(txtDistru.Text) +
                    Convert.ToSingle(txtMath.Text) + Convert.ToSingle(txtPurcom.Text) + Convert.ToSingle(txtArtapp.Text) +
                    Convert.ToSingle(txtNstp.Text) + Convert.ToSingle(txtPafit.Text)) / 8;
                    var averageString = Convert.ToString(average);
                    listStudent.SelectedItems[0].SubItems[0].Text = txtFirstname.Text;
                    listStudent.SelectedItems[0].SubItems[1].Text = txtLastName.Text;
                    listStudent.SelectedItems[0].SubItems[2].Text = txtMiddleName.Text;
                    listStudent.SelectedItems[0].SubItems[3].Text = txtProgram.Text;
                    listStudent.SelectedItems[0].SubItems[4].Text = txtCopro.Text;
                    listStudent.SelectedItems[0].SubItems[5].Text = txtAnimul.Text;
                    listStudent.SelectedItems[0].SubItems[6].Text = txtDistru.Text;
                    listStudent.SelectedItems[0].SubItems[7].Text = txtMath.Text;
                    listStudent.SelectedItems[0].SubItems[8].Text = txtPurcom.Text;
                    listStudent.SelectedItems[0].SubItems[9].Text = txtArtapp.Text;
                    listStudent.SelectedItems[0].SubItems[10].Text = txtNstp.Text;
                    listStudent.SelectedItems[0].SubItems[11].Text = txtPafit.Text;
                    listStudent.SelectedItems[0].SubItems[12].Text = averageString;
                }
            }
        }

        private void listStudent_Click(object sender, EventArgs e)
        {
            if (listStudent.SelectedItems.Count > 0)
            {
                txtFirstname.Text = listStudent.SelectedItems[0].SubItems[0].Text;
                txtLastName.Text = listStudent.SelectedItems[0].SubItems[1].Text;
                txtMiddleName.Text = listStudent.SelectedItems[0].SubItems[2].Text;
                txtProgram.Text = listStudent.SelectedItems[0].SubItems[3].Text;
                txtCopro.Text = listStudent.SelectedItems[0].SubItems[4].Text;
                txtAnimul.Text = listStudent.SelectedItems[0].SubItems[5].Text;
                txtDistru.Text = listStudent.SelectedItems[0].SubItems[6].Text;
                txtMath.Text = listStudent.SelectedItems[0].SubItems[7].Text;
                txtPurcom.Text = listStudent.SelectedItems[0].SubItems[8].Text;
                txtArtapp.Text = listStudent.SelectedItems[0].SubItems[9].Text;
                txtNstp.Text = listStudent.SelectedItems[0].SubItems[10].Text;
                txtPafit.Text = listStudent.SelectedItems[0].SubItems[11].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtFirstname.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtProgram.Clear();
            txtCopro.Clear();
            txtAnimul.Clear();
            txtDistru.Clear();
            txtMath.Clear();
            txtPurcom.Clear();
            txtArtapp.Clear();
            txtNstp.Clear();
            txtPafit.Clear();
            if (listStudent.SelectedItems.Count > 0)
            {
                
                listStudent.Items.Remove(listStudent.SelectedItems[0]);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            txtFirstname.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtProgram.Clear();
            txtCopro.Clear();
            txtAnimul.Clear();
            txtDistru.Clear();
            txtMath.Clear();
            txtPurcom.Clear();
            txtArtapp.Clear();
            txtNstp.Clear();
            txtPafit.Clear();
            listStudent.Items.Clear();
        }
    }
}