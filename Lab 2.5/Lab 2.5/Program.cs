using System;

namespace Lab_2._5
{
   
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private DateTime registerDate;

        public User(string login, string name, string surname, int age)
        {
            this.login = login;
            this.firstName = name;
            this.lastName = surname;
            this.age = age;
            registerDate = DateTime.Now;
        }
        public override string ToString()
        {
            return ($"\n USER DATA \nLogin: {login}\nName: {firstName}\nLast name: {lastName}\nAge: {age}\nRegistration date: {registerDate.ToString()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your login:");
            string login = Console.ReadLine();

            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = Int32.Parse(Console.ReadLine());

            User user = new User(login, firstName, lastName, age);
            Console.WriteLine(user.ToString());

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
