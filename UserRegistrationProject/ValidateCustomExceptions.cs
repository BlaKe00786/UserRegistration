using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationProject
{
    public class ValidateCustomExceptions : Exception
    {
        public enum ExceptionType
        {
            INVALID_ENTRY
            
        }
        private readonly ExceptionType type;
        public ValidateCustomExceptions(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
