using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeConsole
{
    [Serializable]
    public class Person
    {
        #region fields
        private int regNumber;
        private string name;
        private DateTime dOB;
        private Address address;
        private ulong telephoneNumber;
        static private int regNumberCounter = 0;
        #endregion

        #region properties
        public int RegNumber
        {
            get { return regNumber; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime DOB
        {
            get { return dOB; }
            set { dOB = value; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public ulong TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }
        #endregion

        #region constructors
        public Person(string name, DateTime date) : this()
        {
            this.name = name;
            dOB = date;            
        }
        public Person()
        {
            regNumberCounter++;
            regNumber = regNumberCounter;
        }
        #endregion

        #region methods
        public override string ToString()
        {
            string result = 
                 $"Reg no: {RegNumber}, " +
                 $"Name: {Name}, " +
                 $"DOB: {DOB.ToString("yyyy-MM-dd")}, " +
                 $"\nAddress: {Address.ToString()}, " +
                 $"Tel:{TelephoneNumber}";
            return result;
        }
        #endregion
    }
}