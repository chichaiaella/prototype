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
            lvwStudent.View = View.Details;

            lvwStudent.Columns.Add("FirstName", 90);
            lvwStudent.Columns.Add("LastName", 90);
            lvwStudent.Columns.Add("MiddleName", 40);
            lvwStudent.Columns.Add("Program", 70);
            lvwStudent.Columns.Add("Copro", 55);
            lvwStudent.Columns.Add("Animul", 55);
            lvwStudent.Columns.Add("Distru", 55);
            lvwStudent.Columns.Add("Mathmod", 55);
            lvwStudent.Columns.Add("Purcomm", 55);
            lvwStudent.Columns.Add("Art App", 55);
            lvwStudent.Columns.Add("NSTP 2", 55);
            lvwStudent.Columns.Add("PAFIT 2", 55);
            lvwStudent.Columns.Add("Average", 55);
            lvwStudent.Columns.Add("Remarks", 80);
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
            else
            {
                var average = (Convert.ToSingle(txtCopro.Text) + Convert.ToSingle(txtAnimul.Text) + Convert.ToSingle(txtDistru.Text) +
                    Convert.ToSingle(txtMath.Text) + Convert.ToSingle(txtPurcom.Text) + Convert.ToSingle(txtArtapp.Text) +
                    Convert.ToSingle(txtNstp.Text) + Convert.ToSingle(txtPafit.Text)) / 8;
                if (average == 1)
                {
                    remarks = "Outstanding";
                }
                else if (average <= 1.50)
                {
                    remarks = "Very Good";
                }
                else if (average <= 2.25)
                {
                    remarks = "Good";
                }
                else if (average <= 2.75)
                {
                    remarks = "Fair";
                }
                else if (average == 3)
                {
                    remarks = "Passed";
                }
                else
                {
                    remarks = "Failure";
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
                newitem.SubItems.Add(averageString);
                newitem.SubItems.Add(remarks);
                lvwStudent.Items.Add(newitem);

            
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
                if (lvwStudent.SelectedItems.Count > 0)
                {
                    var average = (Convert.ToSingle(txtCopro.Text) + Convert.ToSingle(txtAnimul.Text) + Convert.ToSingle(txtDistru.Text) +
                    Convert.ToSingle(txtMath.Text) + Convert.ToSingle(txtPurcom.Text) + Convert.ToSingle(txtArtapp.Text) +
                    Convert.ToSingle(txtNstp.Text) + Convert.ToSingle(txtPafit.Text)) / 8;
                    if (average == 1)
                    {
                        remarks = "Outstanding";
                    }
                    else if (average <= 1.50)
                    {
                        remarks = "Very Good";
                    }
                    else if (average <= 2.25)
                    {
                        remarks = "Good";
                    }
                    else if (average <= 2.75)
                    {
                        remarks = "Fair";
                    }
                    else if (average == 3)
                    {
                        remarks = "Passed";
                    }
                    else
                    {
                        remarks = "Failure";
                    }
                    var averageString = Convert.ToString(average);
                    lvwStudent.SelectedItems[0].SubItems[0].Text = txtFirstname.Text;
                    lvwStudent.SelectedItems[0].SubItems[1].Text = txtLastName.Text;
                    lvwStudent.SelectedItems[0].SubItems[2].Text = txtMiddleName.Text;
                    lvwStudent.SelectedItems[0].SubItems[3].Text = txtProgram.Text;
                    lvwStudent.SelectedItems[0].SubItems[4].Text = txtCopro.Text;
                    lvwStudent.SelectedItems[0].SubItems[5].Text = txtAnimul.Text;
                    lvwStudent.SelectedItems[0].SubItems[6].Text = txtDistru.Text;
                    lvwStudent.SelectedItems[0].SubItems[7].Text = txtMath.Text;
                    lvwStudent.SelectedItems[0].SubItems[8].Text = txtPurcom.Text;
                    lvwStudent.SelectedItems[0].SubItems[9].Text = txtArtapp.Text;
                    lvwStudent.SelectedItems[0].SubItems[10].Text = txtNstp.Text;
                    lvwStudent.SelectedItems[0].SubItems[11].Text = txtPafit.Text;
                    lvwStudent.SelectedItems[0].SubItems[12].Text = averageString;
                    lvwStudent.SelectedItems[0].SubItems[13].Text = remarks;

                }
            }
        }

        private void listStudent_Click(object sender, EventArgs e)
        {
            if (lvwStudent.SelectedItems.Count > 0)
            {
                txtFirstname.Text = lvwStudent.SelectedItems[0].SubItems[0].Text;
                txtLastName.Text = lvwStudent.SelectedItems[0].SubItems[1].Text;
                txtMiddleName.Text = lvwStudent.SelectedItems[0].SubItems[2].Text;
                txtProgram.Text = lvwStudent.SelectedItems[0].SubItems[3].Text;
                txtCopro.Text = lvwStudent.SelectedItems[0].SubItems[4].Text;
                txtAnimul.Text = lvwStudent.SelectedItems[0].SubItems[5].Text;
                txtDistru.Text = lvwStudent.SelectedItems[0].SubItems[6].Text;
                txtMath.Text = lvwStudent.SelectedItems[0].SubItems[7].Text;
                txtPurcom.Text = lvwStudent.SelectedItems[0].SubItems[8].Text;
                txtArtapp.Text = lvwStudent.SelectedItems[0].SubItems[9].Text;
                txtNstp.Text = lvwStudent.SelectedItems[0].SubItems[10].Text;
                txtPafit.Text = lvwStudent.SelectedItems[0].SubItems[11].Text;
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
            if (lvwStudent.SelectedItems.Count > 0)
            {
                
                lvwStudent.Items.Remove(lvwStudent.SelectedItems[0]);
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
            lvwStudent.Items.Clear();
        }
    }
}