using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollegeConsole
{
    [Serializable]
    public class Student : Person
    {
        #region fields
        private List<Section> sections = new List<Section>();
        #endregion

        #region propeties
        public List<Section> Sections
        {
            get { return sections; }
            set { sections = value; }
        }
        #endregion

        #region constructors
        public Student(string name, DateTime dOB): base(name, dOB)
        {
        }
        public Student()
        {
        }
        #endregion

        #region methods
        public string PrintTranscript()
        {
            string result = "";
            foreach (Section sec in sections)
            {
                foreach (Enrolment enrl in sec.Enrolments)
                {
                    if (enrl.Student.Equals(this))
                        result += $"{sec.Course.CourseCode} {enrl.FinalGrade}\n";
                }
            }
            return result;
        }
        #endregion
    }
}
