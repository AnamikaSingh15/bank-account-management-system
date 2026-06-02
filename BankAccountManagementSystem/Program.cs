using System;

class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        account.AccountHolder = "Anamika";

        account.Deposit(5000);

        account.Display();
    }
}