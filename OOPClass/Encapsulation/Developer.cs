using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Developer
    {
        public string Name;
        public string Surname;
        public double Experience;

        public Developer()
        {
            
        }

        public Developer(string name) : this()
        {
            Name = name;
        }

        public Developer(string name , string surname) : this (name)
        {
            Surname = surname;
        }

        public Developer(string name , string surname, double experience) : this(name , surname)
        {
            Experience = experience;
        }

        

    }
}
