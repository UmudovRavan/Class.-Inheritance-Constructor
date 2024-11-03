using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    public class Student : Human
    {
        public Student(string name, byte age) : base(name,age) 
        {
        }

        public Student(string name,byte age , double grant) : this(name,age) 
        {
            Grant = grant;
        }

        public double Grant;

        public void ShowFullData()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Age: {Age} Grant: {Grant}");
        }
    }
}
