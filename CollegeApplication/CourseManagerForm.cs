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
    public partial class CourseManagerForm : Form
    {
        // fields
        CourseManager aCourseManager = new CourseManager();
        Course aCourse;
        Section aSection;

        // constructors
        public CourseManagerForm()
        {
            InitializeComponent();
        }

        // event handlers
        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            // enter course information
            aCourse = new Course();
            Form addCourseForm = new AddCourseForm(aCourse);
            if (addCourseForm.ShowDialog() == DialogResult.OK)
            {
                // Add course
                aCourseManager.AddCourse(aCourse);
                // add listview item
                string[] item = { aCourse.CourseCode, aCourse.Name, aCourse.Description };
                lvwCourses.Items.Add(new ListViewItem(item));
                // update course information
                lblCourseCode.Text = aCourse.CourseCode;
                lblCourseName.Text = aCourse.Name;
                lblCourseDescription.Text = aCourse.Description;
                lblNoOfEvaluations.Text = aCourse.NoOfEvaluations.ToString();
                lblCourseCode.Visible = true;
                lblCourseName.Visible = true;
                lblCourseDescription.Visible = true;
                lblNoOfEvaluations.Visible = true;
            }
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            // enter section information
            aCourse = aCourseManager.Courses[lvwCourses.SelectedIndices[0]];
            aSection = new Section(aCourse, SemesterPeriod.FALL);
            // *should have been dealt in the constructor of Section
            List<Section> temp = aCourse.Sections.ToList();
            temp.Add(aSection);
            aCourse.Sections = temp.ToArray();
            Form addSectionForm = new AddSectionForm(aSection);
            // add section
            if (addSectionForm.ShowDialog() == DialogResult.OK)
                lbxSections.Items.Add(aSection);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            // enter teacher information
            aSection = (Section)lbxSections.SelectedItem;
            aSection.Faculty = new Teacher();
            Form addTeacherForm = new AddTeacherForm(aSection);
            // add teacher
            if (addTeacherForm.ShowDialog() == DialogResult.OK)
            {
                btnAddTeacher.Enabled = false;
                int temp = lbxSections.SelectedIndex;
                lbxSections.Items.RemoveAt(lbxSections.SelectedIndex);
                lbxSections.Items.Insert(temp, aSection);
            }
        }

        private void lvwCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCourses.SelectedItems.Count == 1)
            {
                // show selected course information
                lblCourseCode.Text = lvwCourses.SelectedItems[0].SubItems[0].Text;
                lblCourseName.Text = lvwCourses.SelectedItems[0].SubItems[1].Text;
                lblCourseDescription.Text = lvwCourses.SelectedItems[0].SubItems[2].Text;
                // switch section list added to the course
                aCourse = aCourseManager.Courses[lvwCourses.SelectedIndices[0]];
                lbxSections.Items.Clear();
                lbxSections.Items.AddRange(aCourse.Sections);                
                // enable buttons
                btnAddSection.Enabled = true;
                if (lbxSections.Items.Count == 0)
                    btnAddTeacher.Enabled =  false;
            }
        }

        private void lbxSections_Format(object sender, ListControlConvertEventArgs e)
        {
            Section aSec = (Section)e.ListItem;
            string facultyName = (aSec.Faculty == null) ? "" : aSec.Faculty.Name;
            e.Value = $"{aSec.SectionId} {aSec.Name} {facultyName}";
        }

        private void lbxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxSections.SelectedItems.Count == 1)
            {
                Section aSec = (Section)lbxSections.SelectedItem;
                btnAddTeacher.Enabled = aSec.Faculty == null ? true : false;
            }
        }

        private void lbxSections_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(lbxSections.SelectedItems.Count == 1)
            {
                Form sectionInfoForm = new SectionInfoForm((Section)lbxSections.SelectedItem);
                sectionInfoForm.ShowDialog();
            }
        }

        private void btnLoadCourses_Click(object sender, EventArgs e)
        {
            // reset 
            aCourseManager.Courses.Clear();
            // load from the file
            aCourseManager.LoadSchool("user.dat");
            lvwCourses.Items.Clear();
            foreach (Course crse in aCourseManager.Courses)
            {
                // set course view
                string[] item = { crse.CourseCode, crse.Name, crse.Description };
                lvwCourses.Items.Add(new ListViewItem(item));
                lbxSections.Items.Clear();
                // set section list
                foreach (Section sec in crse.Sections) {
                    lbxSections.Items.Add(sec);
                }
                // set course information
                lblCourseCode.Text = crse.CourseCode;
                lblCourseName.Text = crse.Name;
                lblCourseDescription.Text = crse.Description;
                lblNoOfEvaluations.Text = crse.NoOfEvaluations.ToString();
                lblCourseCode.Visible = true;
                lblCourseName.Visible = true;
                lblCourseDescription.Visible = true;
                lblNoOfEvaluations.Visible = true;
            }
        }

        private void btnSaveCourses_Click(object sender, EventArgs e)
        {
            aCourseManager.SaveSchoolInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CourseManagerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
