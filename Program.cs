using System;


namespace Lessons1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string age;
            string surname;
            string color;
            Console.WriteLine("Enter your age");
            age = Console.ReadLine();
            Console.WriteLine("Enter your first and last name?");
            surname = Console.ReadLine();
            Console.WriteLine("Enter your favorite color");
            color = Console.ReadLine();
            Console.WriteLine("You are " + age + ", it's time to change something in life! "
                + "You have a very beautiful name " + surname + ", but that's no reason to hire you."
                + " But if your favorite color " + color + ", we'll think about it. " +
                "Thank you, we will call you back. Do not see you again.");
   
        }
    }
}
