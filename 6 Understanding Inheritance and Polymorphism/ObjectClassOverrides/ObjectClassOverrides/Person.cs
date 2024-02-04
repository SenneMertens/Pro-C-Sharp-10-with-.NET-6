using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClassOverrides
{
    // Remember that Person extends Object.
    class Person
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SocialSecurityNumber { get; } = "";

        public Person() { }

        public Person(string firstName, string lastName, int age, string SSN)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            SocialSecurityNumber = SSN;
        }

        public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";

        public override bool Equals(object obj)
        {
            // if (!(obj is Person person))
            // {
            //     return false;
            // }
            // Note the use of the 'this' keyword.
            // if (person.FirstName == this.FirstName && person.LastName == this.LastName && person.Age == this.Age)
            // {
            //     return true;
            // }
            // return false;

            // No need to cast 'obj' to a Person anymore, as everything has a ToString() method.
            return obj?.ToString() == this.ToString();
        }

        // Return a hash code based on a point of unique string data.
        public override int GetHashCode() => this.SocialSecurityNumber.GetHashCode();

        // Return a hash code based on a Person's ToString() value.
        // public override int GetHashCode() => this.ToString().GetHashCode();
    }
}
