using BankAccount.Models;

// BankAccount 
// Use design pattern that suits building menu
// Use polimorf to master objective oriented programing



List<Account> accountList = new List<Account>();
List<AccountKids> accountKidsList = new List<AccountKids>();

Console.Clear();
Console.WriteLine("Welcome to the Bank");
Console.WriteLine("Menu");
Console.WriteLine("A - Balance check");
Console.WriteLine("B - Deposit");
Console.WriteLine("C - Withdraw");
Console.WriteLine("D - Add bank account");
Console.WriteLine("E - Show accounts");
Console.WriteLine("X - Exit");
Console.WriteLine("");
Console.Write(">>> ");
string _menuOption = Console.ReadLine();

switch(_menuOption) {
    case "A":
        // code here
        break;
    case "B":
        // code here
        break;
    case "C":
        // code here
        break;
    case "D":
        // code here
        break;
    case "X":
        // code here
        break;
}


void AddAccount() {
    Console.WriteLine("Choose account:");
    Console.WriteLine("S - Standard");
    Console.WriteLine("K - kids account");
    Console.WriteLine("");
    Console.Write(">>> ");
    string _accountOption = Console.ReadLine();

    switch(_accountOption){
        case "S":
            accountList.Add(AddAccountStandard());
            break;
        case "K":
            accountKidsList.Add(AddAccountKids());
            break;
    }
}

    // Refactoring - tp static class
    Account AddAccountStandard(){
    Account account = new Account();
    Console.WriteLine("Add account number ");
    Console.Write(">>> ");
    account.AccountNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Add owner name ");
    Console.Write(">>> ");
    account.OwnerName = Console.ReadLine();
    Console.WriteLine("Add owner last name ");
    Console.Write(">>> ");
    account.OwnerLastName = Console.ReadLine();
    Console.WriteLine("starting balance");
    Console.Write(">>> ");
    account.Balance = Convert.ToDouble(Console.ReadLine());
    return account;
    }

    // Refactoring - tp static class
    AccountKids AddAccountKids(){
    AccountKids account = new AccountKids();
    Console.WriteLine("Add account number ");
    Console.Write(">>> ");
    account.AccountNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Add owner name ");
    Console.Write(">>> ");
    account.OwnerName = Console.ReadLine();
    Console.WriteLine("Add owner last name ");
    Console.Write(">>> ");
    account.OwnerLastName = Console.ReadLine();
    Console.WriteLine("starting balance");
    Console.Write(">>> ");
    account.Balance = Convert.ToDouble(Console.ReadLine());
    return account;
    }




