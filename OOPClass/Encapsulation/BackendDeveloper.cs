namespace Encapsulation
{
    public partial class Program
    {
        public class BackendDeveloper : Developer
        {
            public BackendDeveloper()
            {
                
            }
            public BackendDeveloper(string name): base()
            {
                Name = name;
            }

            public BackendDeveloper(string name,string surname) : base(name)
            {
                    Surname = surname;
            }


            public BackendDeveloper(string name , string surname , double experince) : base(name , surname)
            {
                Experience = experince;
            }
            public BackendDeveloper(string name , string surname , double experince,double sqlexperience) :this(name,surname,experince)
            {
                SqlExperience = sqlexperience;
            }

            public double SqlExperience;
        }
    }
}
