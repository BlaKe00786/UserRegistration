using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName,lastName,emailID,mobileNum,password;
            var regexName = "^[A-Z][a-z]{2,18}$";
            var regexEmailID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            var regexMobile = "^[1-9]{1}[0-9]{1,2}[ ]{1}[6-9]{1}[0-9]{9}$";
            var regexPassword = "(?=.*?[._+-@#&*$])(?=.*[A-Z])(?=.*[0-9])([0-9a-zA-z]{7,})";
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            checkIfValid(regexName,firstName);
            Console.WriteLine("Enter Last Name : ");
            lastName = Console.ReadLine();
            checkIfValid(regexName, lastName);
            Console.WriteLine("Enter Email ID : ");
            emailID = Console.ReadLine();
            checkIfValid(regexEmailID, emailID);
            Console.WriteLine("Enter Mobile Number : ");
            mobileNum = Console.ReadLine();
            checkIfValid(regexMobile, mobileNum);
            Console.WriteLine("Enter Password : ");
            password = Console.ReadLine();
            checkIfValid(regexPassword, password);
        }
        public static void checkIfValid(string regex, string input)
        {
            var matchInput = Regex.Match(input, regex);
            if (matchInput.Success)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}