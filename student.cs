namespace Person
{
    public class Student : Person
    {
        private string InvalidEmailMessage = "The Provided email is not valid, must not contain digit";
        private string email;
        public Student(string firstName, 
            string lastName, 
            int age, 
            string email) 
            : base(firstName, lastName, age)
        {
            this.Email = email;
        }

        public string Email 
        {
            get => this.email;
            private set 
            {
                foreach (var symbol in value)
                {
                    if (char.IsDigit(symbol))
                    {
                        throw new InvalidEmailException(InvalidEmailMessage);
                    }
                }

                this.email = value;
            }
        }
    }
}
