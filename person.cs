
   
using System;

namespace Person 
{
    public class Person
    {
        private string InvalidNameMessage = "Name must contain only letters";
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName 
        {
            get => this.firstName;

            private set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be null ot white space"); 
                }

                foreach (var letter in value)
                {
                    if (!char.IsLetter(letter))
                    {
                        throw new InvalidPersonNameException(InvalidNameMessage);
                    }
                }

                this.firstName = value;
            } 
        }
        public string LastName 
        {
            get => this.lastName;
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null ot white space");
                }

                foreach (var letter in value)
                {
                    if (!char.IsLetter(letter))
                    {
                        throw new InvalidPersonNameException(InvalidNameMessage);
                    }
                }

                this.lastName = value;
            } 
        }
        public int Age 
        {
            get => this.age;
            private set 
            {
                if (value < 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException(
                        "Age should be in Range [0...120]");
                }                

                this.age = value;
            }
        }
    }
}
