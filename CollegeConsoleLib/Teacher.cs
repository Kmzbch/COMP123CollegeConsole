using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollegeConsole
{
    [Serializable]
    public class Teacher : Person
    {
        #region fields
        private List<Section> sections = new List<Section>();
        #endregion

        #region propeties
        public List<Section> Sections
        {
            get { return sections; }
            set { sections = value; }
        }
        #endregion

        #region constructors
        public Teacher(string name, DateTime date) : base(name, date)
        {
        }
        public Teacher()
        {
        }
        #endregion

        #region methods
        public string SectionsInfo()
        {
            string result = "";
            foreach (Section sec in Sections)
                result += $"\t{sec.Name}\n";
            return result;
        }
        #endregion

    }
}
