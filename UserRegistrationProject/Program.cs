using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,lastName;
            var regex = @"^[A-Z][a-z]{2,18}$";
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();
            var matchFirstName = Regex.Match(firstName, regex);
            if (matchFirstName.Success)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
            var matchLastName = Regex.Match(lastName, regex);
            if (matchLastName.Success)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
        }
    }
}
