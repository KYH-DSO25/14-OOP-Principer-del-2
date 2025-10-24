using _02_Bank.Enum;
using _02_Bank.Interfaces;

namespace _02_Bank.AccountTypes;
internal class DepositAccount : Account, IDeposit<DepositAccount>, IDraw<DepositAccount>
{
    public DepositAccount(CustomerType customerType, decimal balance, decimal interestRate)
        : base(customerType, balance, interestRate)
    {        
    }

    public DepositAccount Deposit(decimal money)
    {
        Balance += money;
        return this;
    }

    public DepositAccount WithDraw(decimal money)
    {
        if (Balance < money)
        {
            throw new ArgumentException("Insufficient amount in the account!");
        }
        Balance -= money;
        return this;
    }

    public override decimal CalculateInterestAmount(decimal numberOfMonths)
    {
        if (Balance < 10_000)
            return 0;

        return base.CalculateInterestAmount(numberOfMonths);
    }
}
