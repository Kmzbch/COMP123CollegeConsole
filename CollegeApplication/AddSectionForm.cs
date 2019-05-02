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


namespace CollegeApplication
{
    public partial class AddSectionForm : Form
    {
        Section aSection;
        
        public AddSectionForm(Section aSection)
        {
            InitializeComponent();
            this.aSection = aSection;
            txtAddingCourse.Text = $"{aSection.Course.CourseCode} {aSection.Course.Name}";
            cmbSemester.SelectedIndex = 0;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            aSection.SectionId = txtSectionId.Text;
            aSection.Name = txtSectionName.Text;
            aSection.MaxNumberOfStudents = (int)numMaxNoOfStudents.Value;
            aSection.Semester = (SemesterPeriod)Enum.Parse(typeof(SemesterPeriod), cmbSemester.Text, true);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSectionId_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (
                string.IsNullOrWhiteSpace(txtSectionId.Text)
                || string.IsNullOrWhiteSpace(txtSectionName.Text)) ? false : true;
        }

        private void txtSectionName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (
                string.IsNullOrWhiteSpace(txtSectionId.Text)
                || string.IsNullOrWhiteSpace(txtSectionName.Text)) ? false : true;
        }
    }
}
