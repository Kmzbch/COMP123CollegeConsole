using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollegeConsole
{
    [Serializable]
    public class Course
    {
        #region fields
        private string courseCode;
        private string name;
        private string description;
        private List<Section> sections = new List<Section>();
        private int noOfEvaluations;
        #endregion

        #region properties
        public string CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public Section[] Sections
        {
            get{ return sections.ToArray(); }
            set{ sections = value.ToList(); }
        }
        public int NumberOfSections
        {
            get { return sections.Count; }
        }
        public int NoOfEvaluations
        {
            get { return noOfEvaluations; }
            set
            {
                if (sections.Count != 0)
                    throw new Exception("Section is already assigned. Number of evaluations cannot be changed any more");
                noOfEvaluations = value;
            }
        }
        #endregion

        #region constructors
        public Course(string code, string name) : this()
        {
            this.courseCode = code;
            this.name = name;
        }
        public Course()
        {
        }
        #endregion

        #region methods
        public void AddSection(SemesterPeriod semester, string id, string name)
        {
            Section section = new Section(this, 30, semester)
            {
                SectionId = id,
                Name = name,
            };
            sections.Add(section);
        }
        public void AddSection(Section section)
        {
            if (section.SectionId == null || section.Name == null)
                throw new Exception("Section is not valid");
            else
            {
                if (section.Course != null)
                    throw new Exception($"Section already assigned to {section.Course.Name} course");
                sections.Add(section);
                section.Course = this;
            }
        }
        public override string ToString()
        {
            string result =
                $"CourseCode: {CourseCode}, " +
                $"Name: {Name}, " +
                $"Description: {Description}, " +
                $"No of Evaluations: {NoOfEvaluations} " +
                $"\nNo of sections: {sections.Count}";
            foreach(Section sec in sections)
                result += $"\n\t {sec.Course.Name}:{sec.Name}";
            return result;
        }
        #endregion
    }
}
