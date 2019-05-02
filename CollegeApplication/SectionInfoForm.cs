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
    public partial class SectionInfoForm : Form
    {
        Section aSection;
        
        public SectionInfoForm(Section aSection)
        {
            InitializeComponent();
            this.aSection = aSection;
            lblSectionId.Text = aSection.SectionId;
            lblSectionName.Text = aSection.Name;
            lblSemester.Text = aSection.Semester.ToString().ToLower();
            lblSemester.Text = Char.ToUpper(lblSemester.Text[0]) + lblSemester.Text.Substring(1);
            lblMaxNoOfStudents.Text = aSection.MaxNumberOfStudents.ToString();
            lblFaculty.Text = $"{ ((aSection.Faculty == null) ? "(not assigned)" : aSection.Faculty.Name) }";
            lblAssignedCourse.Text = $"{aSection.Course.CourseCode} {aSection.Course.Name}";

            // setup tooltip for faculty
            if(aSection.Faculty != null)
            {
                string message = $"Name: {aSection.Faculty.Name}\n";
                message += $"DOB: {aSection.Faculty.DOB.ToString("yyyy-MM-dd")}\n";
                message += $"Phone: {aSection.Faculty.TelephoneNumber}\n";
                message += $"Assigned Sections:\n";
                foreach (Section sec in aSection.Faculty.Sections)
                {
                    message += $"   {sec.Name}\n";
                }
                ttpTeacherInfo.SetToolTip(lblFaculty, message);
                lblFaculty.Font = new Font(lblFaculty.Font, FontStyle.Underline);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
