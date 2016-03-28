namespace _02.Bank
{
    using System;

    public class LoanAccount : Account
    {
        private const int NoInterestIndividualMonths = 3;
        private const int NoInterestCompanyMonths = 2;

        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer.TypeOfCustomer.Equals(CustomerType.Individual))
            {
                if (months <= NoInterestIndividualMonths)
                {
                    return 0;
                }

                return base.CalculateInterest(months - NoInterestIndividualMonths);
            }
            else if (this.Customer.TypeOfCustomer.Equals(CustomerType.Company))
            {
                if (months <= NoInterestCompanyMonths)
                {
                    return 0;
                }

                return base.CalculateInterest(months - NoInterestCompanyMonths);
            }

            return base.CalculateInterest(months);
        }
    }
}
