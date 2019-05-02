using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollegeConsole
{
    [Serializable]
    public class Section
    {
        #region fields
        private string sectionId;
        private string name;
        private List<Enrolment> enrolments = new List<Enrolment>();
        private int maxNoOfEnrollments = 40;
        private Course course;
        private SemesterPeriod semester;
        private Teacher faculty;
        #endregion

        #region properties
        public string SectionId
        {
            get { return sectionId; }
            set { sectionId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int MaxNumberOfStudents
        {
            get { return maxNoOfEnrollments; }
            set {
                if (enrolments.Count == 0)
                    maxNoOfEnrollments = value;
            }
        }
        public Enrolment[] Enrolments
        {
            get { return enrolments.ToArray(); }
        }

        public int NoOfEnrollments
        {
            get { return enrolments.Count; }
        }
        public Course Course
        {
            get { return course; }
            set { course = value; }
        }
        public SemesterPeriod Semester
        {
            get { return semester; }
            set { semester = value; }
        }
        public Teacher Faculty
        {
            get { return faculty; }
            set
            {
                faculty = value;
                faculty.Sections.Add(this);
            }
        }
        #endregion

        #region constructors
        public Section(Course course, int maxNoOfEnrollments, SemesterPeriod semester) : this(course, semester)
        {
            this.maxNoOfEnrollments = maxNoOfEnrollments;
        }
        public Section(Course course, SemesterPeriod semester) : this()
        {
            this.course = course;
            this.semester = semester;
        }
        public Section()
        {
        }
        #endregion

        #region methods
        public void AddStudent(Student student)
        {
            if (course == null)
                throw new Exception("Student can only be assigned to the section that is assigned to the course");
            if (enrolments.Count >= maxNoOfEnrollments)
                throw new Exception("Student cannot be added. The section is full");
            enrolments.Add(new Enrolment(student, this, course.NoOfEvaluations));
            student.Sections.Add(this);
        }
        public void DefineEvaluation(int evalOrderNumber, EvaluationType type, int max, double weight)
        {
            foreach (Enrolment enrl in enrolments)
                enrl.Evaluations[evalOrderNumber - 1] = new Evaluation(type, max, weight);
        }
        public void AddStudentMark(int evalOrderNumber, Student student, int points)
        {
            foreach (Enrolment enrl in enrolments)
            {
                Evaluation ev = enrl.Evaluations[evalOrderNumber - 1];
                if (points > ev.MaxPoints)
                    throw new Exception("Points are more than the max number of points for the evaluation");
                if (enrl.Student.Equals(student))
                {
                    ev.Points = points;
                    return;
                }
            }
            throw new Exception($"Student {student.Name} is not in the section");
        }
        public string GetEvaluationsInfo()
        {
            string result = "";
            if (enrolments.Count == 0)
                result = "No enrollments in the section";
            else
            {
                int i = 0;
                foreach (Evaluation ev in enrolments[0].Evaluations)
                {
                    result += $"\t{i++}.{ev.EvalType}[{ev.MaxPoints}]";
                }
                result += "\n";
                foreach (Enrolment enrl in enrolments)
                {
                    result += $"{enrl.Student.Name}\t";
                    foreach (Evaluation ev in enrl.Evaluations)
                        result += $"{ev.Points}/{(ev.Points / ev.MaxPoints * 100) * ev.EvalWeight}\t\t";
                    result += "\n";
                }
            }
            return result;
        }
        public string FinalMarksInfo()
        {
            string result = "";
            foreach (Enrolment enrl in enrolments)
            {
                enrl.CalculateFinalGrade();
                result += $"{enrl.Student.Name}\t{enrl.FinalGrade}\n";
            }
            return result;
        }
        public override string ToString()
        {
            string result =
                $"Section id: {SectionId}, " +
                $"Name; {Name}, " +
                $"Max no of students: {MaxNumberOfStudents}, " +
                $"Semester: {Semester}, \n" +
                $"\tFaculty: {(Faculty == null ? "" : Faculty.Name)}\n" +
                $"Number of students: {NoOfEnrollments}";
            foreach (Enrolment enrl in enrolments)
                result += $"\n\t {enrl.Student.Name}";
            return result;
        }
        #endregion
    }

}
