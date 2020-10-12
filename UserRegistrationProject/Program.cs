using System;
using System.Text.RegularExpressions;
namespace UserRegistrationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Validate validate = new Validate();
            string firstName,lastName,emailID,mobileNum,password;
            var regexName = "^[A-Z][a-z]{2,18}$";
            var regexEmailID = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
            var regexMobile = "^[1-9]{1}[0-9]{1,2}[ ]{1}[6-9]{1}[0-9]{9}$";
            var regexPassword = "(?=.*?[._+-@#&*$])(?=.*[A-Z])(?=.*[0-9])([0-9a-zA-z]{7,})";
            Console.WriteLine("Enter First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(regexName,firstName));
            Console.WriteLine("Enter Last Name : ");
            lastName = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(regexName, lastName));
            Console.WriteLine("Enter Email ID : ");
            emailID = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(regexEmailID, emailID));
            Console.WriteLine("Enter Mobile Number : ");
            mobileNum = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(regexMobile, mobileNum));
            Console.WriteLine("Enter Password : ");
            password = Console.ReadLine();
            Console.WriteLine(validate.checkIfValid(regexPassword, password));
        }
    }
}