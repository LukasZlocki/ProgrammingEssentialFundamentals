namespace BankAccount.Models
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }
        public string OwnerLastName {get; set;}
        public double Balance { get; set; }


        public string Withdraw(double amount) {
            string _userMessage;
            if (Balance - amount >= 0) {
                Balance = Balance - amount;
                _userMessage = "Succes. Your new account balance : " + Balance.ToString();
            }
            else {
                _userMessage = "No sufficient funds.";
            }
            return _userMessage;
        }

        public void Deposit(double amount) {
            // code logic here
        }

        public string CheckBalance() {
            return "Your account balance :" + Balance.ToString();
        }
    }
}