namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Ravan","Umudov" , 19);


            Console.WriteLine("{0} {1} {2}",human1.Name,human1.Surname,human1.Age);

            human1.ShowFullData();

            string human1Data = human1.GetFullData();
            Console.WriteLine(human1Data);

            int indexOfData = human1Data.IndexOf("Age");

            string age = human1Data.Substring(indexOfData);
            Console.WriteLine(age);

        }
    }

    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Human()
        {
            
        }
        public Human(string name) : this()
        {
            Name = name;
        }

        public Human(string name , string surname) : this(surname)
        {
            Name = name;
            Surname = surname;  
        }

        public Human(string name, string surname, byte age): this(name, surname) 
        { 
            this.Age = age; 
        }

        public void ShowFullData ()
        {
            Console.WriteLine($"Name: {Name},Surname: {Surname},Age: {Age}");
        }

        public string GetFullData()
        {
            return $"Name: {Name} Surname: {Surname},Age: {Age}";
        }

    }
}
