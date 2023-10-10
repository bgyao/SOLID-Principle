using Solid_Principles.InterfaceSegregationPrinciples.ICoffeeServices;

namespace Solid_Principles.InterfaceSegregationPrinciples.CoffeeServices;

public class NescafeInstantCoffeeService : ICoffee, ICreamer, ISugar
{
    public void CoffeeBeanType(string beanType)
    {
        Console.WriteLine("Barako by default");
    }
    public void IsInstant(string instantSelector)
    {
        Console.WriteLine("Instant Coffee");
    }
    public void IsHotCold(string hotColdIndicator)
    {
        Console.WriteLine($"{hotColdIndicator} is selected");
    }

    public void Creamer(string creamer)
    {
        Console.WriteLine("With default Nescafe creamer amount");
    }

    public void SugarLevel(string sugarLevel)
    {
        Console.WriteLine("With default amount of sugar");
    }
}
