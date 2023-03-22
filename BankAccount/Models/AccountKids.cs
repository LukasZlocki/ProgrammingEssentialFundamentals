namespace BankAccount.Models
{
    public class AccountKids : Account
    {
        public override string Withdraw(double amount)
        {
            if (amount <= 50) {
            return base.Withdraw(amount);
            }
            else {
                return "Kids account. Max withdraw : 50 $";
            }
        }
    }
}