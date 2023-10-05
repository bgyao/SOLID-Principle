namespace Solid_Principles.LiskovSubstitutionPrinciples;

public class Program
{
    public static void Main()
    {
        BankAccount savingsAccount = new SavingsAccount("SA123456789", 1000m, 0.05m);
        BankAccount currentAccount = new CurrentAccount("CA987654321", 1500m, 500m);

        Console.WriteLine("Before Transactions:");
        PrintAccountDetails(savingsAccount);
        PrintAccountDetails(currentAccount);

        savingsAccount.Withdraw(500m);
        currentAccount.Withdraw(2000m);

        Console.WriteLine("After Transactions:");
        PrintAccountDetails(savingsAccount);
        PrintAccountDetails(currentAccount);
    }

    static void PrintAccountDetails(BankAccount bankAccount)
    {
        Console.WriteLine($"Account Number: {bankAccount.AccountNum} Balance {bankAccount.Balance}");
    }
}
