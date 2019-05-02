using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollegeConsole;

namespace CollegeConsoleLibTest
{
    [TestClass]
    public class EvaluationTest
    {
        [TestMethod]
        public void Evaluation_EvalType_Gets_Sets()
        {
            // Arrange
            EvaluationType expected = EvaluationType.QUIZ;
            // Act
            Evaluation evaluation = new Evaluation()
            {
                EvalType = EvaluationType.QUIZ
            };
            EvaluationType actual = evaluation.EvalType;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Evaluation_EvalWeight_GetsAndSets()
        {
            // Arrange
            double expected = .5;
            // Act
            Evaluation evaluation = new Evaluation()
            {
                EvalWeight = .5
            };
            // Assert
            double actual = evaluation.EvalWeight;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Evaluation_MaxPoints_GetsAndSets()
        {
            // Arrange
            double expected = 99;
            Evaluation evaluation = new Evaluation()
            {
                MaxPoints = 99
            };
            // Act
            double actual = evaluation.MaxPoints;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Evaluation_Points_GetsAndSets()
        {
            // Arrange
            double expected = 99;
            Evaluation evaluation = new Evaluation()
            {
                Points = 99
            };
            // Act
            double actual = evaluation.Points;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Evaluation_Init_WithParameters_CreatesEvaluation()
        {
            // Arrange
            Evaluation eval;
            bool valuesAssigned = true;
            // Act
            eval = new Evaluation(EvaluationType.QUIZ, 100, .5)
            {
                Points = 99
            };
            // Assert
            valuesAssigned &= (eval.EvalType == EvaluationType.QUIZ);
            valuesAssigned &= (eval.EvalWeight == .5);
            valuesAssigned &= (eval.MaxPoints == 100);
            valuesAssigned &= (eval.Points == 99);
            Assert.IsTrue(valuesAssigned);
        }

    }
}
