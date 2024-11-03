using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Human(string name)
        {
            Name = name;
        }
        public Human(string name,byte age) : this(name) 
        {
            Age = age;
        }
    }
}
