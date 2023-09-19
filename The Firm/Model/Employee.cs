using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    internal class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string cpr;

        protected string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        protected string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        protected string Cpr
        {
            get => cpr;
            set => cpr = value;
        }

        public Employee(string firstName, string lastName, string cpr)
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
