using System;
namespace UserRegistrationTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to user Registration!");
            UserValidator userValidator = new UserValidator();
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(userValidator.ValidateFirstName(firstName));
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            Console.WriteLine(userValidator.ValidateLastName(lastName));
        }
    }
}