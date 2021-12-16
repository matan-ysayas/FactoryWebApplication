using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryWebApplication.Models
{
    public class Inspector
    {
       public string firstName;
       public string lastName;
       public int yearOfBirth;
       public int workExperience;


        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int YearOfBirth { get { return yearOfBirth; } set { yearOfBirth = value; } }
        
        public int WorkExperience { get { return workExperience; } set { workExperience = value; } }


       public Inspector(string firstName,string lastName,int yearOfBirth,int workExperience)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.workExperience = workExperience;

        }


    }
}