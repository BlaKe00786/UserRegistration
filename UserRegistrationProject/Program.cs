using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            var regex = @"^[A-Z][a-z]{2,18}$";
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            var match = Regex.Match(firstName, regex);
            if (match.Success)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
        }
    }
}
