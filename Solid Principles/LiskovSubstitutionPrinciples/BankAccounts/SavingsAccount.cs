namespace Solid_Principles.LiskovSubstitutionPrinciples;

public class SavingsAccount : BankAccount
{
    public decimal InterestRate { get; set; }

    public SavingsAccount(string accountNum, decimal balance, decimal interestRate) : base (accountNum, balance)
    {
        InterestRate = interestRate;
    }

    public override void Withdraw(decimal amount)
    {
        if(Balance > amount)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount} from Account Number {AccountNum}. New Bal: {Balance}");
        }
        else
        {
            Console.WriteLine($"Unable to withdraw {amount} from Account Number {AccountNum}. Available Bal: {Balance}");
        }
    }
}
