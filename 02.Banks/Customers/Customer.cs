namespace _02.Bank
{
    using System;

    public class Customer : ICustomer
    {
        private CustomerType typeOfCustomer;
        private string firstName;
        private string lastName;

        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public CustomerType TypeOfCustomer
        {
            get 
            {
                return this.typeOfCustomer;
            }

            protected set
            {
                this.typeOfCustomer = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("First name cannot be less than 3 characters");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentOutOfRangeException("Last name cannot be less than 3 characters");
                }

                this.lastName = value;
            }
        }
    }
}
