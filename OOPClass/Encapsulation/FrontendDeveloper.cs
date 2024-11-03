using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class FrontendDeveloper : Developer
    {
        public FrontendDeveloper(string name , string surname, double experience) : base(name, surname, experience) 
        {

        }
        public void ShowFullData()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Experince: {Experience}");
        }
    }
}
