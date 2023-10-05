namespace Solid_Principles.LiskovSubstitutionPrinciples;

public class BankAccount
{
    public string AccountNum { get; set; }
    public decimal Balance { get; set; }

    public BankAccount(string accountNum, decimal balance)
    {
        AccountNum = accountNum;
        Balance = balance;
    }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Successfully deposited {amount} to Account Number {AccountNum}. New balance is: {Balance}");
    }

    public virtual void Withdraw(decimal amount)
    {
        if(Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawal of amount {amount} is successful. Balance is now {Balance}.");
        }
        else
        {
            Console.WriteLine($"Sorry. Your account ({AccountNum}) does not have enough balance to perform this transaction. Current Bal: {Balance}.");
        }
    }
}
