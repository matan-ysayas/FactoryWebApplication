using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryWebApplication.Models
{
    public class Employee
    {
       public string firstName;
      public  string lastName;
      public  int yearOfBirth;
      public  string phone;

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        public string Phone { get { return phone; } set { phone = value; } }


       public Employee() { }

        public Employee(string firstName, string lastName, int yearOfBirth, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.phone = phone;
        }
        
         
        
    }
}