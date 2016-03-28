namespace _02.Bank
{
    using System;

    public class MortageAccount : Account, IAccount
    {
        private const int InterestMonthsCompanies = 12;
        private const int InterestMonthsIndividuals = 6;

        public MortageAccount(Customer customer, decimal balance, decimal interestRate)
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
                if (months <= InterestMonthsIndividuals)
                {
                    return 0;
                }

                return base.CalculateInterest(months - InterestMonthsIndividuals);
            }
            else if (this.Customer.TypeOfCustomer.Equals(CustomerType.Company))
            {
                if (months <= InterestMonthsCompanies)
                {
                    return (this.MonthlyInterestRate * months) / 2;
                }

                return base.CalculateInterest(months - InterestMonthsCompanies);
            }

            return base.CalculateInterest(months);
        }
    }
}
