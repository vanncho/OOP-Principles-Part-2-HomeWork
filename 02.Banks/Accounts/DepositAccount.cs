namespace _02.Bank
{
    using System;

    public class DepositAccount : Account
    {
        private const decimal InterestMinBallance = 0;
        private const decimal InterestMaxBallance = 1000;

        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void Deposit(decimal sum)
        {
            this.Balance += sum;
        }

        public override void Withdraw(decimal sum)
        {
            if (sum > this.Balance)
            {
                throw new WithdrawOutOfAmountException("Not enough account money");
            }

            this.Balance -= sum;
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance > InterestMinBallance && this.Balance < InterestMaxBallance)
            {
                return 0;
            }

            return base.CalculateInterest(months);
        }
    }
}
