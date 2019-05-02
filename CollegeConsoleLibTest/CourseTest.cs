using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeConsole;

namespace CollegeConsoleLibTest
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void Course_CourseCode_GetsAndSets()
        {
            // Arrange
            string expected = "COMP100";
            Course course = new Course();
            // Act
            course.CourseCode = "COMP100";
            // Assert
            string actual = course.CourseCode;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Course_Name_GetsAndSets()
        {
            // Arrange
            string expected = "Programming 1";
            Course course = new Course();
            // Act
            course.Name = "Programming 1";
            // Assert
            string actual = course.Name;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Course_Description_GetsAndSets()
        {
            // Arrange
            string expected = "prog1 desc";
            Course course = new Course();
            // Act
            course.Description = "prog1 desc";
            // Assert
            string actual = course.Description;
            Assert.AreEqual(expected, actual);
        }

        //*Modified Apr 11, 2018: affected by modification of collection/inappropriate test
        //[TestMethod]
        //public void Course_Sections_Gets()
        //{
        //    // Arrage
        //    Section[] expected = new Section[20];
        //    Course course = new Course();
        //    // Act
        //    course.Sections = expected;
        //    // Assert
        //    Section[] actual = course.Sections;
        //    Assert.AreSame(expected, actual);
        //}
        [TestMethod]
        public void Course_Sections_Gets()
        {
            // Arrage
            string expected = "F01";
            Course course = new Course("COMP100", "Programming 1");
            Section sec = new Section()
            {
                SectionId = expected,
                Name = "Section 1",
            };
            course.AddSection(sec);
            // Act
            Section[] actual = course.Sections;
            // Assert
            Assert.AreEqual(expected, actual[0].SectionId);
        }

        [TestMethod]
        public void Course_NumberOfSections_Gets()
        {
            // Arrange
            int expected = 1;
            Course course = new Course("COMP100", "Programming 1");
            Section sec = new Section()
            {
                SectionId = "F01",
                Name = "Section 1",
            };
            course.AddSection(sec);
            // Act
            int actual = course.NumberOfSections;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Course_NoOfEvaluations_Gets()
        {
            // Arrange
            int expected = 3;
            Course course = new Course()
            {
                NoOfEvaluations = 3
            };
            // Act
            int actual = course.NoOfEvaluations;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Course_NoOfEvaluations_Sets()
        {
            // Arrange
            int expected = 3;
            Course course = new Course();
            // Act
            course.NoOfEvaluations = 3;
            // Assert
            int actual = course.NoOfEvaluations;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Course_NoOfEvaluations_AfterSectionAssigned_CannotBeSet()
        {
            // Arrange
            Course course = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section()
            {
                SectionId = "F01",
                Name = "Section 1",
            };
            course.AddSection(sec);
            // Act
            course.NoOfEvaluations = 99;
            // Assert
        }

        //*Modified on Apr 12, 2018: Inappropriate Test
        //[TestMethod]
        //public void Course_Init_WithParameters_CreatesCourse()
        //{
        //    // Arrange
        //    Course crse = null;
        //    string courseCode = "COMP100";
        //    string name = "Programming 1";
        //    string description = "prog1 desc";
        //    Section[] sections = new Section[20];
        //    int noOfEvaluations = 2;
        //    // Act
        //    crse = new Course()
        //    {
        //        CourseCode = courseCode,
        //        Name = name,
        //        Description = description,
        //        Sections = sections,
        //        NoOfEvaluations = noOfEvaluations
        //    };
        //    // Assert
        //    bool valuesAssigned = true;
        //    valuesAssigned &= (crse.CourseCode == courseCode);
        //    valuesAssigned &= (crse.Name == name);
        //    valuesAssigned &= (crse.Description == description);
        //    valuesAssigned &= (crse.Sections == sections);
        //    valuesAssigned &= (crse.NumberOfSections == 0);
        //    valuesAssigned &= (crse.NoOfEvaluations == noOfEvaluations);
        //    Assert.IsTrue(valuesAssigned);
        //}
        [TestMethod]
        public void Course_Init_WithParameters_CreatesCourse()
        {
            // Arrange
            Course crse = null;
            string courseCode = "COMP100";
            string name = "Programming 1";
            // Act
            crse = new Course(courseCode, name);
            // Assert
            bool valuesAssigned = true;
            valuesAssigned &= (crse.CourseCode == courseCode);
            valuesAssigned &= (crse.Name == name);
            Assert.IsTrue(valuesAssigned);
        }

        [TestMethod]
        public void Course_AddSection_AddsExistingSection()
        {
            // Arrange
            Course course = new Course("COMP100", "Programming 1");
            Section sec = new Section()
            {
                SectionId = "F01",
                Name = "Section 1",
            };
            // Act
            course.AddSection(sec);
            // Assert
            Assert.AreSame(course.Sections[0], sec.Course.Sections[0]);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Course_AddSection_WithoutSectionId_ThrowsException()
        {
            // Arrange
            Course course = new Course("COMP100", "Programming 1");
            Section invalidSec = new Section()
            {
                Name = "Section 1",
            };
            // Act
            course.AddSection(invalidSec);
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Course_AddSection_WithoutSectionName_ThrowsException()
        {
            // Arrange
            Course course = new Course("COMP100", "Programming 1");
            Section invalidSec = new Section()
            {
                SectionId = "F01",
            };
            // Act
            course.AddSection(invalidSec);
            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Course_AddSection_WithAlreadyAssignedSection_ThrowsException()
        {
            // Arrange
            Course crse1 = new Course("COMP100", "Programming 1");
            Course crse2 = new Course("COMP123", "Programming 2");
            Section assignedSec = new Section(crse2, 30, SemesterPeriod.FALL)
            {
                SectionId = "F01",
                Name = "Section 1",
            };
            // Act
            crse1.AddSection(assignedSec);
            // Assert
        }

        [TestMethod]
        public void Course_AddSection_AddsNewSection()
        {
            // Arrange
            Course course = new Course("COMP100", "Programming 1");
            // Act
            course.AddSection(SemesterPeriod.FALL, "F01", "Section 1");
            // Assert
            Assert.AreSame(course, course.Sections[0].Course);
        }

    }
}