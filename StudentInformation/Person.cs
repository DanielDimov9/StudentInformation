using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformation
{
   public class Person
    {
         public string firstName;
         public string lastName;

        public Person (string fn,string ln)
        {
            firstName = fn;
            lastName = ln;
        }
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
        public void Display()
        {
            Console.WriteLine("First Name: {0}", firstName);
            Console.WriteLine("Last Name:{0}", lastName);
            Console.WriteLine("Full Name:{0}", GetFullName());
        }
        
    }
}
