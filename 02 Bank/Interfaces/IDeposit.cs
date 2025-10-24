namespace _02_Bank.Interfaces;
public interface IDeposit<T>
{
    T Deposit(decimal money);
}
