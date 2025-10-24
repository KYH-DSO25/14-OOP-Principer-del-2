using _02_Bank.Enum;
using _02_Bank.Interfaces;

namespace _02_Bank.AccountTypes;
public class MortgageAccount : Account, IDeposit<MortgageAccount>
{
    public MortgageAccount(CustomerType customerType, decimal balance, decimal interestRate) 
        : base(customerType, balance, interestRate)
    {
    }

    public MortgageAccount Deposit(decimal money)
    {
        Balance += money;
        return this;
    }

    public override decimal CalculateInterestAmount(decimal numberOfMonths)
    {
        if (CustomerType == CustomerType.Company)
            return base.CalculateInterestAmount(
                Math.Min(numberOfMonths, 12) / 2 + Math.Max(numberOfMonths - 12, 0));

        if (CustomerType == CustomerType.Individual)
            return base.CalculateInterestAmount(numberOfMonths - 6);

        return base.CalculateInterestAmount(numberOfMonths);    // Ska inte kunna köras...
    }
}
