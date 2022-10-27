/* Section: 48 "SOLID - L - LISKOV"
*/

// L rules is break in child account no additional athorization will be called !!
class BankAccount
{
    public virtual void WithdrawMoney(int amount)
    {
        if (amount < 10000)
        {
            Console.WriteLine("Withdrawing money from standard bank account");
        }
        else
        {
            Console.WriteLine("Amount bigger then 10000. Requires additional authorization!");
        }
    }
}

class ChildBankAccount : BankAccount
{
    public override void WithdrawMoney(int amount)
    {
        Console.WriteLine("Withdrawing money from children bank account");
    }
}

// we can pass children account here - no additional authorization > 10000
class CashMachine
{
    public void WithdrawFromAccount(BankAccount bankAccount, int amount)
    {
        bankAccount.WithdrawMoney(amount);
    }
}

