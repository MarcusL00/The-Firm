using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    internal class Sweeper : Employee
    {


        internal Sweeper(string firstName, string lastName, string cpr) : base(firstName, lastName, cpr)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpr = cpr;
        }

        public override string ToString()
        {
            return $"First name: {firstName}, Last name:{lastName}, CPR number: {cpr}";
        }
    }
}
