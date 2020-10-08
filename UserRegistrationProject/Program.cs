using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,lastName,emailID;
            var regexName = @"^[A-Z][a-z]{2,18}$";
            var regexEmailID = @"^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter Email ID: ");
            emailID = Console.ReadLine();
            var matchFirstName = Regex.Match(firstName, regexName);
            var matchLastName = Regex.Match(lastName, regexName);
            var matchEmailID = Regex.Match(emailID, regexEmailID);
            if (matchFirstName.Success)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name");
            }
            if (matchLastName.Success)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name");
            }
            if (matchEmailID.Success)
            {
                Console.WriteLine("Valid EMaill ID");
            }
            else
            {
                Console.WriteLine("Invalid EMaill ID");
            }
        }
    }
}
