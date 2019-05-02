using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollegeConsole
{
    [Serializable]
    public class Enrolment
    {
        #region fields
        private Student student;
        private Section section;
        private FinalGrade finalGrade;
        private List<Evaluation> evaluations = new List<Evaluation>();
        private readonly int numberOfEvaluations;
        #endregion

        #region properties
        public Student Student
        {
            get { return student; }
            set { student = value; }
        }
        public Section Section
        {
            get { return section; }
            set { section = value; }
        }
        public FinalGrade FinalGrade
        {
            get { return finalGrade; }
            set { finalGrade = value; }
        }
        public List<Evaluation> Evaluations
        {
            get { return evaluations; }
        }

        #endregion

        #region constructors
        public Enrolment(Student student, Section section, int numberOfEvaluations)
        {
            this.student = student;
            this.section = section;
            this.numberOfEvaluations = numberOfEvaluations;
            evaluations = Enumerable.Repeat(new Evaluation(), numberOfEvaluations).ToList();
        }
        #endregion

        #region methods
        public void CalculateFinalGrade()
        {
            double totalWeightedValue = 0;
            foreach (Evaluation ev in evaluations)
            {
                totalWeightedValue += ((ev.Points / ev.MaxPoints * 100) * ev.EvalWeight);
            }
            int percent = (evaluations[0].MaxPoints == 0) ? 100 : (int)totalWeightedValue;
            if (percent >= 90)
                FinalGrade = FinalGrade.APLUS;
            else if (percent >= 80)
                FinalGrade = FinalGrade.A;
            else if (percent >= 75)
                FinalGrade = FinalGrade.BPLUS;
            else if (percent >= 70)
                FinalGrade = FinalGrade.B;
            else if (percent >= 65)
                FinalGrade = FinalGrade.CPLUS;
            else if (percent >= 60)
                FinalGrade = FinalGrade.C;
            else if (percent >= 55)
                FinalGrade = FinalGrade.DPLUS;
            else if (percent >= 50)
                FinalGrade = FinalGrade.D;
            else
                FinalGrade = FinalGrade.F;
        }
        public override string ToString()
        {
            string result = "";
            result += $"Student: \n{(Student == null ? "" : Student.Name)}";
            result += $"Section: \n{(Section == null ? "" : Section.Name)}";
            result += $"Final Grade: {FinalGrade}\n";
            return result;
        }
        #endregion
    }

}
