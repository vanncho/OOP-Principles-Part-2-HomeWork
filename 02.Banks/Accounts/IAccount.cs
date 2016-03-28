namespace _02.Bank
{
    public interface IAccount
    {
        Customer Customer { get; }

        decimal Balance { get; }

        decimal MonthlyInterestRate { get; }
    }
}
