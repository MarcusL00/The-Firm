using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    internal class Manager : Employee
    {
        protected string phoneNumber;

        protected string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }


        internal Manager(string firstName, string lastName, string cpr, string phoneNumber) : base(firstName, lastName, cpr)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpr = cpr;
            PhoneNumber = phoneNumber;
        }
        public override string ToString()
        {
            return $"First name: {firstName}, Last name:{lastName}, CPR number: {cpr}, Phone number: {phoneNumber}";
        }
    }
}
