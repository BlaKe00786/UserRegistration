using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace UserRegistrationProject
{
    public class Validate
    {
        public bool checkIfValid(string regex, string input)
        {
            var matchInput = Regex.Match(input, regex);
            if (matchInput.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
