using System;

namespace Lab_2._7
{
   
    enum Position
    {
        Manager, TopManager, Director
    }
    class Employee
    {
        private string name;
        private string surname;
        private Position position;
        private int exp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        public Employee() { }

        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void CalculateSalary()
        {
            switch (position)
            {
                case Position.Manager:
                    Console.WriteLine($"{exp}-year Manager's salary:\n10 000 * {exp} * 0.85 = {10000 * 0.85 * exp} (Tax 15% = {10000 * exp / 2 * 0.15}");
                    break;
                case Position.TopManager:
                    Console.WriteLine($"{exp}-year Top Manager's salary:\n20 000 * {exp} * 0.85 = {20000 * exp * 0.85} (Tax 15% = {20000 * exp / 2 * 0.15}");
                    break;
                case Position.Director:
                    Console.WriteLine($"{exp}-year Director's salary:\n30 000 * {exp} * 0.85 = {30000 * exp * 0.85} (Tax 15% = {30000 * exp / 2 * 0.15}");
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan", "Ivanov");
            employee.Position = Position.Manager;
            employee.Exp = 18;

            Console.WriteLine($"Name: {employee.Name}\nSurname: {employee.Surname}\nPosition: {employee.Position}");
            employee.CalculateSalary();

            Console.ReadLine();
        }
    }
}
