// See https://aka.ms/new-console-template for more information
using Slot11Asignment.BankAccount;

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount();
        account.Balance = 200;

        //account.BalanceChanged += AccountBalanceChanged;

        account.Deposit(500);
        Console.WriteLine($"Balance after update: {account.Balance}");

        account.WithDraw(200);
        Console.WriteLine($"Balance after update: {account.Balance}");

    }
}