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
    public partial class AddCourseForm : Form
    {
        // fields
        Course aCourse;

        // constructors
        public AddCourseForm(Course aCourse)
        {
            this.aCourse = aCourse;
            InitializeComponent();
        }

        // event handlers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            aCourse.CourseCode = txtCourseCode.Text;
            aCourse.Name = txtCourseName.Text;
            aCourse.Description = txtCourseDescription.Text;
            aCourse.NoOfEvaluations = (int)numNoOfEvaluations.Value;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCourseCode_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (
                string.IsNullOrWhiteSpace(txtCourseCode.Text)
                || string.IsNullOrWhiteSpace(txtCourseName.Text)) ? false : true;
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (
                string.IsNullOrWhiteSpace(txtCourseCode.Text)
                || string.IsNullOrWhiteSpace(txtCourseName.Text)) ? false : true;
        }
    }
}
