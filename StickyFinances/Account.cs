using System.Diagnostics;
using System.Transactions;
using StickyFinances;
namespace StickyFinances;

public class Account : User
{
    private long _balance;

    public Account()
    {
    }

    public Account(long initialBalance, String name, long id) : base(name, id)
    {
        _balance = initialBalance;
    }

    public void Deposit(long deposit)
    {
        if (!(deposit <= 0)) _balance += deposit;
    }

    public void Withdraw(int withdraw)
    {
        if (!(withdraw <= 0)) _balance -= withdraw;
    }
}