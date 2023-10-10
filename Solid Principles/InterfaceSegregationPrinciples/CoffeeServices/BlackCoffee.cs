using Solid_Principles.InterfaceSegregationPrinciples.ICoffeeServices;

namespace Solid_Principles.InterfaceSegregationPrinciples.CoffeeServices;

public class BlackCoffee : ICoffee
{
    public void CoffeeBeanType(string beanType)
    {
        Console.WriteLine($"{beanType} is selected");
    }

    public void IsHotCold(string hotColdIndicator)
    {
        Console.WriteLine($"{hotColdIndicator} is selected.");
    }

    public void IsInstant(string instantSelector)
    {
        Console.WriteLine("This is a brewed coffee.");
    }
}
