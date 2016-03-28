namespace _02.Bank
{
    using System;

    public class WithdrawOutOfAmountException : ApplicationException
    {
        public WithdrawOutOfAmountException(string msg)
            : base(msg)
        {
        }
    }
}
