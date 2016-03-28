namespace _02.Bank
{
    using System;

    public class CompanyCustomer : Customer, ICustomer
    {
        private string companyName;

        public CompanyCustomer(string firstName, string lastName, string companyName)
            : base(firstName, lastName)
        {
            this.CompanyName = companyName;
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company name cannot be null or empty");
                }

                this.companyName = value;
            }
        }
    }
}
