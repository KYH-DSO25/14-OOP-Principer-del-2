using System.Text;

namespace _02_Bank;
public class Bank
{
    private readonly List<Account> _accounts = new List<Account>();

    public Bank(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public Bank AddAccount (params Account[] accounts)
    {
        foreach (var account in accounts)
            _accounts.Add(account);
        return this;
    }

    public Bank RemoveAccount(Account account)
    {
        _accounts.Remove(account);
        return this;
    }

    public override string ToString()
    {
        StringBuilder info = new StringBuilder();

        info.AppendLine(string.Format("Bank: {0}\n", Name));

        foreach (var account in _accounts)
            info.Append(account.ToString());

        return info.ToString();
    }
}
