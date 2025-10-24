namespace _02_Bank.Interfaces;
public interface IDraw<T>
{
    T WithDraw(decimal money);
}
