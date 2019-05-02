using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeConsole;
using System.IO;

namespace CollegeConsoleLibTest
{
    [TestClass]
    public class CourseManagerTest
    {
        [TestMethod]
        public void CourseManager_Courses_Gets()
        {
            // Arrange
            Course expected = new Course("COMP100", "Programming 1");
            CourseManager courseMng = new CourseManager();
            // Act
            courseMng.AddCourse(expected);
            // Assert
            Course actual = courseMng.Courses[0];
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        public void CourseManager_NumberOfCourses_GetsAndSets()
        {
            // Arrange
            int expected = 1;
            CourseManager courseMng = new CourseManager();
            // Act
            courseMng.NumberOfCourses = 1;
            // Assert
            int actual = courseMng.NumberOfCourses;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CourseManager_AddCourse_AddsCourse()
        {
            // Arrange
            Course expected = new Course("COMP100", "Programming 1");
            CourseManager courseMng = new CourseManager();
            // Act
            courseMng.AddCourse(expected);
            // Assert
            Course actual = courseMng.Courses[0];
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        public void CourseManager_ExportCourses_ExportsCourse()
        {
            // Arrange
            if (File.Exists("export.tmp"))
                File.Delete("export.tmp");

            string expected = "COMP100|Programming 1|prog1 desc|3" +
                "COMP123|Programming 2|prog2 desc|4";
            CourseManager courseMng = new CourseManager();
            Course crse1 = new Course("COMP100", "Programming 1")
            {
                Description = "prog1 desc",
                NoOfEvaluations = 3
            };
            Course crse2 = new Course("COMP123", "Programming 2")
            {
                Description = "prog2 desc",
                NoOfEvaluations = 4
            };
            courseMng.AddCourse(crse1);
            courseMng.AddCourse(crse2);
            // Act
            courseMng.ExportCourses("export.tmp", '|');
            // Assert
            FileStream fileIn = new FileStream("export.tmp", FileMode.Open, FileAccess.Read);
            StreamReader stream = new StreamReader(fileIn);
            string actual = "";
            while (stream.Peek() >= 0)
                actual += stream.ReadLine();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void CourseManager_ExportCourses_WhenFileInUse_ThrowsException()
        {
            // Arrange
            if (File.Exists("dummy.tmp"))
                File.Delete("dummy.tmp");
            CourseManager courseMng = new CourseManager();
            courseMng.AddCourse(new Course("COMP100", "Programming 1"));
            FileStream fileOut = new FileStream("dummy.tmp", FileMode.Create, FileAccess.Write);
            try
            {
                // Act
                courseMng.ExportCourses("dummy.tmp", '|');
            }
            catch (IOException ex)
            {
                fileOut.Close();
                throw ex;
            }
        }

        [TestMethod]
        public void CourseManager_ImportCourses_ImportsCourses()
        {
            // Arrange
            if (File.Exists("AdditionalCourses.tmp"))
                File.Delete("AdditionalCourses.tmp");
            int expected = 4;
            FileStream fileOut = new FileStream("AdditionalCourses.tmp", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileOut);
            writer.WriteLine("COMP101,Programming,Intro to Programming,4");
            writer.WriteLine("COMP124,Intro to DB,,5");
            writer.WriteLine("COMP124,Intro to DB,,5");
            writer.WriteLine("COMP212, Programming 3, Programming 3 concepts, 6");
            writer.WriteLine("COMP225,Intro to OOAD,OO Analysis and Design,5");
            writer.WriteLine("COMP246,OOAD2,5");
            writer.WriteLine("COMP346,OOAD,OO Analysis and Design2, a6");
            writer.Close();
            fileOut.Close();
            CourseManager courseMng = new CourseManager();
            // Act
            courseMng.ImportCourses("AdditionalCourses.tmp", ',');
            // Assert
            int actual = courseMng.NumberOfCourses;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void CourseManager_ImportCourses_WhenFileNotFound_ThrowsException()
        {
            // Arrange
            if (File.Exists("dummy.tmp"))
                File.Delete("dummy.tmp");
            CourseManager courseMng = new CourseManager();
            // Act
            courseMng.ImportCourses("dummy.tmp", '|');
            // Assert
        }

        [TestMethod]
        public void CourseManager_SaveSchool_SavesSchool()
        {
            // Arrange
            if (File.Exists("user.dat"))
                File.Delete("user.dat");
            string expected = "COMP100";
            CourseManager courseMng = new CourseManager();
            courseMng.AddCourse(new Course("COMP100", "Programming 1"));
            // Act
            courseMng.SaveSchoolInfo();
            // Assert
            CourseManager newCourseMng = new CourseManager();
            newCourseMng.LoadSchool("user.dat");
            string actual = newCourseMng.Courses[0].CourseCode;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IOException))]
        public void CourseManager_SaveSchool_WhenFileInUse_ThrowsException()
        {
            // Arrange
            if (File.Exists("user.dat"))
                File.Delete("user.dat");
            CourseManager courseMng = new CourseManager();
            courseMng.AddCourse(new Course("COMP100", "Programming 1"));
            FileStream fileOut = File.Create("user.dat");
            try
            {
                // Act
                courseMng.SaveSchoolInfo();
            }
            catch (IOException ex)
            {
                fileOut.Close();
                throw ex;
            }
            // Assert
        }

        [TestMethod]
        public void CourseManager_LoadSchool_LoadsSchool()
        {
            // Arrange
            if (File.Exists("user.dat"))
                File.Delete("user.dat");
            string expected = "COMP100";
            CourseManager courseMng = new CourseManager();
            courseMng.AddCourse(new Course("COMP100", "Programming 1"));
            courseMng.SaveSchoolInfo();
            CourseManager newCourseMng = new CourseManager();
            // Act
            newCourseMng.LoadSchool("user.dat");
            // Assert
            string actual = newCourseMng.Courses[0].CourseCode;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.FileNotFoundException))]
        public void CourseManager_LoadSchool_WhenFileNotFound_ThrowsException()
        {
            // Arrange
            if (File.Exists("dummy.tmp"))
                File.Delete("dummy.tmp");
            CourseManager newCourseMng = new CourseManager();
            // Act
            newCourseMng.LoadSchool("dummy.tmp");
            // Assert
        }
    }
}
