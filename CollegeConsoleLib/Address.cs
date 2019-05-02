using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeConsole
{
    [Serializable]
    public struct Address
    {
        #region fields
        public string Street;
        public string City;
        public string State;
        #endregion

        #region constructors
        public Address(string street, string city, string state)
        {
            Street = street;
            City = city;
            State = state;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            return $"Street: {Street}, City: {City}, State: {State}";
        }
        #endregion
    }
}
