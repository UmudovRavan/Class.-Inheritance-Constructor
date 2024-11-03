namespace OOPClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.Name = "Ravan";
            std1.Surname = "Umudov";
            std1.Age = 19;
            std1.Grant = 145;
            Console.WriteLine(std1.Grant);

            Student std2 = new Student();

            std2.Name = "Anar";
            std2.Surname = "Abilov";
            std2.Age = 29;
            std2.Grant = 42;

            Console.WriteLine(std2.Name);

            Teacher teacher = new Teacher();

            teacher.Name = "Kamal";
            teacher.Surname = "Ibadov";
            teacher.Age = 30;
            teacher.Salary = 5090;
            Console.WriteLine(teacher.Salary);
            
            Human human = new Human();

            human.Surname = "Zaur";
            Console.WriteLine("Human's surname");
            Console.WriteLine(human.Surname);

        }
    }
    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
    }
    public class Teacher : Human
    {
        public double Salary;
    }

    public class Student : Human
    {
        public double Grant;
    }

}
