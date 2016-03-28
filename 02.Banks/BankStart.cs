namespace _02.Bank
{
    using System;

    public class BankStart
    {
        public static void Main(string[] args)
        {
            var ivan = new IndividualCustomer("Ivan", "Ivanov");

            var mortAcc = new MortageAccount(ivan, 1000000m, 7m);
            mortAcc.Deposit(5m);
            Console.WriteLine(mortAcc.Balance);
            mortAcc.Withdraw(10m);
            Console.WriteLine(mortAcc.Balance);
            
            var pesho = new IndividualCustomer("Pesho", "Peshov");
            var loanAcc = new LoanAccount(pesho, 500000m, 5m);
            var intAmm = loanAcc.CalculateInterest(5);
            Console.WriteLine(intAmm);
        }
    }
}
