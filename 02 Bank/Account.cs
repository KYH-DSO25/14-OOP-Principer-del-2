using _02_Bank.Enum;

using System.Text;

namespace _02_Bank;
public abstract class Account : IEquatable<Account>
{
    private decimal balance;
    private decimal interestRate;

    public Account(CustomerType customerType, decimal balance, decimal interestRate)
    {
        CustomerType = customerType;
        Balance = balance;
        InterestRate = interestRate;
    }
    public decimal Balance
    {
        get { return balance; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be less than zero!");

            balance = value;
        }
    }


    public decimal InterestRate
    {
        get { return interestRate; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException("Interest rate cannot be less than zero!");

            interestRate = value;
        }
    }

    public CustomerType CustomerType { get; protected set; }

    public virtual decimal CalculateInterestAmount (decimal numberOfMonths)
    {
        if (numberOfMonths <= 0)
            return 0;

        return Balance * InterestRate/100 * numberOfMonths;
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine("Customer type: " + CustomerType);
        info.AppendLine("Balance: " + Balance);
        info.AppendLine("Interest rate: " + InterestRate);

        return info.ToString();
    }

    public bool Equals(Account? other)
    {
        return CustomerType == other.CustomerType &&
            Balance == other.Balance &&
            InterestRate == other.InterestRate;
    }
}
