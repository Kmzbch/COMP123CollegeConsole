using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CollegeConsole;

namespace CollegeConsoleLibTest
{
    [TestClass]
    public class EnrolmentTest
    {
        [TestMethod]
        public void Enrolment_Student_GetsAndSets()
        {
            // Arrange
            //Person expected = new Person("John", new DateTime(1999, 9, 9));
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 9);
            Student expected = new Student("John", new DateTime(1999, 9, 9));
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 9);
            // Act            
            enrolment.Student = expected;
            // Assert
            Person actual = enrolment.Student;
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        public void Enrolment_Section_GetsAndSets()
        {
            // Arrange
            Section expected = new Section()
            {
                SectionId = "F01",
                Name = "Section 1"
            };
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 9);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 9);
            // Act
            enrolment.Section = expected;
            // Assert
            Section actual = enrolment.Section;
            Assert.AreSame(expected, actual);
        }

        [TestMethod]
        public void Enrolment_FinalGrade_GetsAndSets()
        {
            // Arrange
            FinalGrade expected = FinalGrade.C;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 9);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 9);
            // Act
            enrolment.FinalGrade = FinalGrade.C;
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enrolment_Evaluations_Gets()
        {
            // Arrange
            //Person p = new Person("John", new DateTime(1999, 9, 9));
            Student p = new Student("John", new DateTime(1999, 9, 9));
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, 20, SemesterPeriod.SUMMER);
            sec.AddStudent(p);
            sec.DefineEvaluation(1, EvaluationType.QUIZ, 100, 0.5);
            sec.AddStudentMark(1, p, 99);
            // Act
            // *modified on Apr 11, 2018: affected by modification of Collection/Inappropriate Test
            //Evaluation[] ev = sec.Enrolments[0].Evaluations;
            Evaluation[] ev = sec.Enrolments[0].Evaluations.ToArray();

            // Assert
            bool valuesEqual = true;
            valuesEqual &= (ev[0].EvalType == EvaluationType.QUIZ);
            valuesEqual &= (ev[0].EvalWeight == 0.5);
            valuesEqual &= (ev[0].MaxPoints == 100);
            valuesEqual &= (ev[0].Points == 99);
            Assert.IsTrue(valuesEqual);
        }

        [TestMethod]
        public void Enrolment_Init_WithParameters_CreatesEnrolment()
        {
            // Arrange
            //Person p = new Person("John", new DateTime(1999, 9, 9));
            Student p = new Student("John", new DateTime(1999, 9, 9));
            Course crse = new Course("COMP100", "Programming 1")
            {
                NoOfEvaluations = 1
            };
            Section sec = new Section(crse, 20, SemesterPeriod.SUMMER);
            // Act
            Enrolment enrolment = new Enrolment(p, sec, crse.NoOfEvaluations);
            bool valuesEqual = true;
            valuesEqual &= (enrolment.Student == p);
            valuesEqual &= (enrolment.Section == sec);
            valuesEqual &= (enrolment.FinalGrade == FinalGrade.APLUS);
            valuesEqual &= (enrolment.Evaluations != null);
            // Assert
            Assert.IsTrue(valuesEqual);
        }

        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInAPLUS()
        {
            // Arrange
            FinalGrade expected = FinalGrade.APLUS;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 90
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInA()
        {
            // Arrange
            FinalGrade expected = FinalGrade.A;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 80
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInBPLUS()
        {
            // Arrange
            FinalGrade expected = FinalGrade.BPLUS;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 75
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInB()
        {
            // Arrange
            FinalGrade expected = FinalGrade.B;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 70
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInCPLUS()
        {
            // Arrange
            FinalGrade expected = FinalGrade.CPLUS;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 65
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInC()
        {
            // Arrange
            FinalGrade expected = FinalGrade.C;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 60
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInDPLUS()
        {
            // Arrange
            FinalGrade expected = FinalGrade.DPLUS;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 55
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInD()
        {
            // Arrange
            FinalGrade expected = FinalGrade.D;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 50
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_ResultsInF()
        {
            // Arrange
            FinalGrade expected = FinalGrade.F;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 100, 1)
            {
                Points = 49
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Enrolments_CalculateFinalGradeInfo_WithMaxPointsOfZero_ResultsInAPLUS()
        {
            // Arrange
            FinalGrade expected = FinalGrade.APLUS;
            //Enrolment enrolment = new Enrolment(new Person(), new Section(), 1);
            Enrolment enrolment = new Enrolment(new Student(), new Section(), 1);
            enrolment.Evaluations[0] = new Evaluation(EvaluationType.TEST, 0, 1)
            {
                Points = 49
            };
            // Act
            enrolment.CalculateFinalGrade();
            // Assert
            FinalGrade actual = enrolment.FinalGrade;
            Assert.AreEqual(expected, actual);
        }

    }
}
