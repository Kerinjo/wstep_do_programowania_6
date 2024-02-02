using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Person
    {
        public string firstName;
        public string lastName;

        private int age;
        
        public Person(string firstName, string lastName, int age) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        
        public void Describe()
        {
            Console.WriteLine($"This is {firstName} {lastName}, {age} years old.");
        }

    }
}
