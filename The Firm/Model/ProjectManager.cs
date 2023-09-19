using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Firm.Model
{
    internal class ProjectManager : Manager
    {
        protected string email;

        internal ProjectManager(string firstName, string lastName, string cpr, string phoneNumber, string email) : base(firstName, lastName, cpr, phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Cpr = phoneNumber;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        protected string Email
        {
            get => email;
            set => email = value;
        }
        public override string ToString()
        {
            return $"First name: {firstName}, Last name:{lastName}, CPR number: {cpr}, Phone number: {phoneNumber}, Email: {email}";
        }


    }
}
