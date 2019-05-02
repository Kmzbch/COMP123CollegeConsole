using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeConsole
{
    [Serializable]
    public class Evaluation
    {
        #region fields
        private EvaluationType evalType;
        private double evalWeight;
        private double maxPoints;
        private double points;
        #endregion

        #region properties
        public EvaluationType EvalType
        {
            get { return evalType; }
            set { evalType = value; }
        }
        public double EvalWeight
        {
            get { return evalWeight; }
            set { evalWeight = value; }
        }
        public double MaxPoints
        {
            get { return maxPoints; }
            set { maxPoints = value; }
        }
        public double Points
        {
            get { return points; }
            set { points = value; }
        }
        #endregion

        #region constructors
        public Evaluation(EvaluationType evalType, int maxPoints, double evalWeight) : this()
        {
            this.evalType = evalType;
            this.maxPoints = maxPoints;
            this.evalWeight = evalWeight;
        }
        public Evaluation()
        {
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Type of Evaluation: {EvalType}," +
                $"Evaluation Weight: {EvalWeight}, " +
                $"Max Points: {MaxPoints}, " +
                $"Points: {Points}";
        }
        #endregion
    }
}