namespace Solid_Principles.LiskovSubstitutionPrinciples;

public class CurrentAccount : BankAccount
{
    public decimal OverdraftLimit { get; set; }

    public CurrentAccount(string accountNum, decimal balance, decimal overdraftLimit) : base (accountNum, balance)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if(amount <= Balance + OverdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine($"Withdraw of {amount} from Account Number {AccountNum} successful. New Bal: {Balance}");
        }
        else
        {
            Console.WriteLine($"Exceeded Overdraft Limit or low balance. Account Number: {AccountNum} Current Bal: {Balance}");
        }
    }
}
