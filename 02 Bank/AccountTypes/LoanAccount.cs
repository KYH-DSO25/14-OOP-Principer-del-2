using _02_Bank.Enum;
using _02_Bank.Interfaces;

namespace _02_Bank.AccountTypes;
internal class LoanAccount : Account, IDeposit<LoanAccount>
{
    public LoanAccount(CustomerType customerType, decimal balance, decimal interestRate)
        : base(customerType, balance, interestRate)
    {
        
    }

    public LoanAccount Deposit(decimal money)
    {
        Balance += money;
        return this;
    }

    public override decimal CalculateInterestAmount(decimal numberOfMonths)
    {
        if (CustomerType == CustomerType.Company)
            return base.CalculateInterestAmount(numberOfMonths - 2);

        if (CustomerType == CustomerType.Individual)
            return base.CalculateInterestAmount(numberOfMonths - 3);

        return base.CalculateInterestAmount(numberOfMonths);    // Ska inte kunna köras...
    }
}
