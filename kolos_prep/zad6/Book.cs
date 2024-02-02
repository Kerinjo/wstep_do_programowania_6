using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Book
    {
        string title;
        Person author;
        
        DateTime published_date;
        int age;

        public Book(string title, Person author, DateTime published_date)
        {
            this.title = title;
            this.author = author;
            this.published_date = published_date;

            age =  DateTime.Now.Year - published_date.Year;
        }

        public void Describe()
        {
            Console.WriteLine
               ($"This is \"{title}\".\n" +
                $"A book authored by {author.firstName} {author.lastName}." +
                $"It's {age} years old.");
            Console.WriteLine("Publishing date: {0}", published_date);
        }
    }
}
