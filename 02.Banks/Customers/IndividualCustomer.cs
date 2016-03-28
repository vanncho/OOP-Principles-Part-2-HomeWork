namespace _02.Bank
{
    public class IndividualCustomer : Customer, ICustomer
    {
        public IndividualCustomer(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
