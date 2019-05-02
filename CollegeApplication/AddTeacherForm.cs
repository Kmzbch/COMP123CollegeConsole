using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeConsole;
using System.Collections;


namespace CollegeApplication
{
    public partial class AddTeacherForm : Form
    {
        Section aSection;
        public AddTeacherForm(Section aSection)
        {
            InitializeComponent();
            this.aSection = aSection;
            txtAddingSection.Text = $"{aSection.SectionId} {aSection.Name}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            aSection.Faculty.Name = txtTeacherName.Text;
            aSection.Faculty.DOB = dtpDOB.Value;
            aSection.Faculty.TelephoneNumber = Convert.ToUInt64(txtTelephoneNumber.Text);
            aSection.Faculty.Address = new Address(txtStreet.Text, txtCity.Text, txtState.Text);
            this.Close();
        }

        private void txtTeacherName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherName.Text) ||
                !ulong.TryParse(txtTelephoneNumber.Text, out ulong result)
                || txtTelephoneNumber.Text.Length != 10)
            {
                btnAdd.Enabled = false;
            } else
            {
                btnAdd.Enabled = true;
            }
        }

        private void txtTelephoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherName.Text) ||
                !ulong.TryParse(txtTelephoneNumber.Text, out ulong result)
                || txtTelephoneNumber.Text.Length != 10)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
