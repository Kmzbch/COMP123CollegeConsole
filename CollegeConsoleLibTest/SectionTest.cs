using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeConsole;

namespace CollegeConsoleLibTest
{
    [TestClass]
    public class SectionTest
    {
        [TestMethod]
        public void Section_SectionId_GetsAndSets()
        {
            // Arrange
            string expected = "F01";
            // Act
            Section sec = new Section()
            {
                SectionId = "F01"
            };
            // Assert
            string actual = sec.SectionId;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_Name_GetsAndSets()
        {
            // Arrange
            string expected = "Section 1";
            // Act
            Section sec = new Section()
            {
                Name = "Section 1"
            };
            string actual = sec.Name;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_MaxNumberOfStudents_Gets()
        {
            // Arrange
            int expected = 40;
            Section sec = new Section()
            {
                SectionId = "F01",
                Name = "Section 1"
            };
            // Act
            int actual = sec.MaxNumberOfStudents;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_MaxNumberOfStudents_WithoutEnrollment_Sets()
        {
            // Arrange
            int expected = 30;
            // Act
            Section sec = new Section()
            {
                SectionId = "F01",
                Name = "Section 1",
                MaxNumberOfStudents = 30
            };
            // Assert
            int actual = sec.MaxNumberOfStudents;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_MaxNumberOfStudents_WithEnrolment_NotSets()
        {
            // Arrange
            int notExpected = 40;
            //Person p = new Person("John", new DateTime(1999, 9, 9));
            Student p = new Student("John", new DateTime(1999, 9, 9));
            Course crse = new Course("COMP100", "Programming")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section()
            {
                SectionId = "F01",
                Name = "Section 1",
                MaxNumberOfStudents = 20
            };
            crse.AddSection(sec);
            sec.AddStudent(p);
            // Act
            sec.MaxNumberOfStudents = notExpected;
            // Assert
            int actual = sec.MaxNumberOfStudents;
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void Section_Enrollments_Gets()
        {
            // Arrange
            // Person student = new Person("John", new DateTime(1999, 9, 9));
            Student student = new Student("John", new DateTime(1999, 9, 9));
            Course crse = new Course("COMP100", "Programming 1");
            Section sec = new Section(crse, 30, SemesterPeriod.SUMMER);
            sec.AddStudent(student);
            // Act
            Enrolment[] enrolments = sec.Enrolments;

            // Assert
            bool valuesAssigned = true;
            valuesAssigned &= (enrolments[0].Student == student);
            valuesAssigned &= (enrolments[0].Section == sec);
            valuesAssigned &= (enrolments[0].FinalGrade == FinalGrade.APLUS);
            valuesAssigned &= (enrolments[0].Evaluations != null);
            Assert.IsTrue(valuesAssigned);
        }

        [TestMethod]
        public void Section_NoOfEnrollments_Gets()
        {
            // Arrange
            int expected = 1;
            Course crse = new Course("COMP100", "Programming 1");
            Section sec = new Section(crse, 30, SemesterPeriod.SUMMER);
            //sec.AddStudent(new Person("John", new DateTime(1999, 9, 9)));
            sec.AddStudent(new Student("John", new DateTime(1999, 9, 9)));
            // Act
            int actual = sec.NoOfEnrollments;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_Course_GetsAndSets()
        {
            // Arrange
            Course expected = new Course("COMP100", "Programming 1");
            // Act
            Section sec = new Section()
            {
                Course = expected
            };
            // Assert
            Course actual = sec.Course;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_Semester_GetsAndSets()
        {
            // Arrange
            SemesterPeriod expected = SemesterPeriod.SUMMER;
            // Act
            Section sec = new Section()
            {
                Semester = SemesterPeriod.SUMMER
            };
            // Assert
            SemesterPeriod actual = sec.Semester;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_Faculty_GetsAndSets()
        {
            //// Arrange
            //Person expected = new Person("John", new DateTime(1999, 9, 9));
            Teacher expected = new Teacher("John", new DateTime(1999, 9, 9));
            // Act
            Section sec = new Section()
            {
                Faculty = expected
            };
            // Assert
            Person actual = sec.Faculty;
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        public void Section_Init_WithParameters()
        {
            // Arrange
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 3
            };
            // Act
            Section sec = new Section(crse, 15, SemesterPeriod.WINTER);
            // Assert
            bool valueAssigned = true;
            valueAssigned &= (sec.SectionId == null);
            valueAssigned &= (sec.Name == null);
            valueAssigned &= (sec.MaxNumberOfStudents == 15);
            valueAssigned &= (sec.Enrolments != null);
            valueAssigned &= (sec.NoOfEnrollments == 0);
            valueAssigned &= (sec.Course == crse);
            valueAssigned &= (sec.Semester == SemesterPeriod.WINTER);
            valueAssigned &= (sec.Faculty == null);
            Assert.IsTrue(valueAssigned);
        }

        [TestMethod]
        public void Section_AddStudent_AddsStudent()
        {
            // Arrange
            Course crse = new Course("COMP100", "Programming 1");
            Section sec = new Section(crse, 30, SemesterPeriod.SUMMER);
            //Person student = new Person("John", new DateTime(1999, 9, 9));
            Student student = new Student("John", new DateTime(1999, 9, 9));
            // Act
            sec.AddStudent(student);
            // Assert
            Assert.AreSame(sec.Enrolments[0].Student, student);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Section_AddStudent_WithNotAssignedCourse_ThrowsException()
        {
            // Arrange
            Section sec = new Section()
            {
                SectionId = "F01",
                Name = "Section 1"
            };
            //Person student = new Person("John", new DateTime(1999, 9, 9));
            Student student = new Student("John", new DateTime(1999, 9, 9));
            // Act
            sec.AddStudent(student);
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Section_AddStudent_WithExceededMax_ThrowsException()
        {
            // Arrange
            Course crse = new Course("COMP100", "Programming 1");
            Section sec = new Section(crse, 1, SemesterPeriod.SUMMER);
            //Person student1 = new Person("John", new DateTime(1999, 9, 9));
            //Person student2 = new Person("Bob", new DateTime(2000, 1, 1));
            Student student1 = new Student("John", new DateTime(1999, 9, 9));
            Student student2 = new Student("Bob", new DateTime(2000, 1, 1));
            sec.AddStudent(student1);
            // Act
            sec.AddStudent(student2);
            // Assert
        }

        [TestMethod]
        public void Section_DefineEvaluation_DefinesEvaluation()
        {
            // Arrange
            string expected = "\t0.TEST[100]\nJohn\t0/0\t\t\nBob\t0/0\t\t\n";
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, 2, SemesterPeriod.SUMMER);
            //Person student1 = new Person("John", new DateTime(1999, 9, 9));
            //Person student2 = new Person("Bob", new DateTime(2000, 1, 1));
            Student student1 = new Student("John", new DateTime(1999, 9, 9));
            Student student2 = new Student("Bob", new DateTime(2000, 1, 1));
            sec.AddStudent(student1);
            sec.AddStudent(student2);
            // Act
            sec.DefineEvaluation(1, EvaluationType.TEST, 100, 0.5);
            // Assert
            string actual = sec.GetEvaluationsInfo();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_GetEvaluationInfo_ReturnMessage()
        {
            // Arrange
            string notExpected = "";
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, 1, SemesterPeriod.SUMMER);
            //Person student = new Person("John", new DateTime(1999, 9, 9));
            Student student = new Student("John", new DateTime(1999, 9, 9));
            sec.AddStudent(student);
            // Act
            sec.DefineEvaluation(1, EvaluationType.TEST, 100, 0.5);
            // Assert
            string actual = sec.GetEvaluationsInfo();
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void Section_GetEvaluationInfo_WithoutEnrolment_ReturnMessage()
        {
            // Arrange
            string expected = "No enrollments in the section";
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, SemesterPeriod.SUMMER);
            sec.DefineEvaluation(1, EvaluationType.TEST, 100, 0.5);
            // Act
            string actual = sec.GetEvaluationsInfo();
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Section_AddStudentMark_AddsMark()
        {
            // Arrange
            double expected = 50;
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, 1, SemesterPeriod.SUMMER);
            //Person student = new Person("John", new DateTime(1999, 9, 9));
            Student student = new Student("John", new DateTime(1999, 9, 9));
            sec.AddStudent(student);
            sec.DefineEvaluation(1, EvaluationType.TEST, 100, 0.5);
            // Act
            sec.AddStudentMark(1, student, 50);
            // Assert
            double actual = sec.Enrolments[0].Evaluations[0].Points;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Section_AddStudentMark_WithExceededPoints_ThrowsException()
        {
            // Arrange
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, 1, SemesterPeriod.SUMMER);
            //Person student = new Person("John", new DateTime(1999, 9, 9));
            Student student = new Student("John", new DateTime(1999, 9, 9));
            sec.AddStudent(student);
            sec.DefineEvaluation(1, EvaluationType.TEST, 100, 0.5);
            // Act
            sec.AddStudentMark(1, student, 110);
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Section_AddStudentMark_WithNotAssignedStudent_ThrowsException()
        {
            // Arrange
            Course prog = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(prog, 1, SemesterPeriod.SUMMER);
            //Person student = new Person("John", new DateTime(1999, 9, 9));
            Student student = new Student("John", new DateTime(1999, 9, 9));
            sec.AddStudent(student);
            sec.DefineEvaluation(1, EvaluationType.TEST, 100, 0.5);
            // Act
            //sec.AddStudentMark(1, new Person("Bob", new DateTime(2000, 1, 1)), 90);
            sec.AddStudentMark(1, new Student("Bob", new DateTime(2000, 1, 1)), 90);
            // Assert
        }

        // Modified on Apr 18, 2018: Inappropriate Test
        [TestMethod]
        public void Section_FinalMarkInfo_ReturnsMessage()
        {
            // Arrange
            string notExpected = "";
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, 2, SemesterPeriod.SUMMER);
            //Person student1 = new Person("John", new DateTime(1999, 9, 9));
            //Person student2 = new Person("Bob", new DateTime(2000, 1, 1));
            Student student1 = new Student("John", new DateTime(1999, 9, 9));
//            sec.AddStudent(student2);
            sec.AddStudent(student1);
            sec.DefineEvaluation(1, EvaluationType.TEST, 100, 0.5);
            sec.AddStudentMark(1, student1, 100);
//            sec.AddStudentMark(1, student2, 100);
            // Act
            string actual = sec.FinalMarksInfo();
            // Assert
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void Section_FinalMarkInfo_WithoutEnrolments_ReturnsEmptyString()
        {
            // Arrange
            string expected = "";
            Section sec = new Section();
            // Act
            string actual = sec.FinalMarksInfo();
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
