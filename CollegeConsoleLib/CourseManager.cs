using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace CollegeConsole
{
    [Serializable]
    public class CourseManager
    {
        #region fields
        private List<Course> courses = new List<Course>();
        private int numberOfCourses;
        #endregion

        #region propeties
        public List<Course> Courses
        {
            get { return courses; }
        }

        public int NumberOfCourses
        {
            get { return numberOfCourses; }
            set { numberOfCourses = value; }
        }

        public void AddCourse(Course course)
        {
            courses.Add(course);
            NumberOfCourses++;
        }
        #endregion properties

        #region methods
        public void ExportCourses(string fileName, char delimiter)
        {
            FileStream fileOut = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter sWriter = new StreamWriter(fileOut);
            string recordFormat = string.Join(delimiter.ToString(),
                new string[4] {"{0}", "{1}", "{2}", "{3}"});
            foreach (Course crse in courses)
            {
                sWriter.WriteLine(recordFormat,
                    crse.CourseCode, crse.Name, crse.Description, crse.NoOfEvaluations);
            }
            sWriter.Close();
            fileOut.Close();
        }

        public void ImportCourses(string fileName, char delimiter)
        {
            FileStream fileIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader sReader = new StreamReader(fileIn);
            int recordNumber = 0;
            int noOfCoursesImported = 0;
            while (sReader.Peek() >= 0)
            {
                string record = sReader.ReadLine();
                string[] fields = record.Split(delimiter);
                recordNumber++;
                try
                {
                    if (fields.Length != 4)
                        throw new Exception($"Invalid number of fields in record {recordNumber}");
                    if (!int.TryParse(fields[3], out int n))
                        throw new Exception($"Number of evaluations in record {recordNumber} is not in correct format");
                    foreach (Course crse in courses)
                    {
                        if (crse.CourseCode == fields[0])
                            throw new Exception($"Course code in record {recordNumber} is in use");
                    }
                    AddCourse(new Course(){
                        CourseCode = fields[0],
                        Name = fields[1],
                        Description = fields[2],
                        NoOfEvaluations = Convert.ToInt32(fields[3]),
                    });
                    noOfCoursesImported++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"{recordNumber} records processed, {noOfCoursesImported} courses added");
            sReader.Close();
            fileIn.Close();
        }

        public void SaveSchoolInfo()
        {
            FileStream fileOut = new FileStream("user.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter binFormatter = new BinaryFormatter();
            binFormatter.Serialize(fileOut, this);
            fileOut.Close();
        }

        public void LoadSchool(string fileName)
        {
            FileStream fileIn = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryFormatter binFormatter = new BinaryFormatter();
            CourseManager courseMng = (CourseManager)binFormatter.Deserialize(fileIn);
            foreach (Course crse in courseMng.courses)
            {
                AddCourse(crse);
            }
            fileIn.Close();
        }
        #endregion

    }
}
