namespace _02.Bank
{
    using System;

    public class Account : IAccount, IDeposit, IWithdraw, ICalculateInterest
    {
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.MonthlyInterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be negative");
                }

                this.balance = value;
            }
        }

        public decimal MonthlyInterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative");
                }

                this.interestRate = value;
            }
        }

        public virtual void Deposit(decimal money)
        {
            this.Balance += money;
        }

        public virtual void Withdraw(decimal money)
        {
            this.Balance -= money;
        }

        public virtual decimal CalculateInterest(int months)
        {
            return this.MonthlyInterestRate * months;
        }
    }
}
