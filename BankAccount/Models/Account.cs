namespace BankAccount.Models
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public string OwnerLastName {get; set;}
        public double Balance { get; set; }


        public virtual string Withdraw(double amount) {
            if (Balance - amount >= 0) {
                Balance = Balance - amount;
                return "Succes. Your new account balance : " + Balance.ToString();
            }
            else {
                return "No sufficient funds.";
            }
        }

        public void Deposit(double amount) {
            // code logic here
        }

        public string CheckBalance() {
            return "Your account balance :" + Balance.ToString();
        }
    }
}