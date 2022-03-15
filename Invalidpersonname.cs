   using System;

namespace Person
{
    public class InvalidPersonNameException : Exception
    {
       
        public InvalidPersonNameException(string InvalidNameMessage)
            : base(InvalidNameMessage)
        {

        }
    }
}
