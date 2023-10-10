using Solid_Principles.InterfaceSegregationPrinciples.ICoffeeServices;

namespace Solid_Principles.InterfaceSegregationPrinciples.CoffeeServices;

public class Frappuccino : ICoffee, ISugar, ICreamer, IWhippedCream, ISyrup
{
    #region Tutorial - Explicit Declaration
    //NOTE: Remove inheritances first

    //private ICoffee _coffee;
    //private ICreamer _creamer;
    //private ISugar _sugar;
    //private IWhippedCream _whippedCream;
    //private ISyrup _syrup;

    //public Frappuccino(
    //    ICoffee coffee,
    //    ICreamer creamer,
    //    ISugar sugar,
    //    IWhippedCream whippedCream,
    //    ISyrup syrup)
    //{
    //    _coffee = coffee;
    //    _creamer = creamer;
    //    _sugar = sugar;
    //    _whippedCream = whippedCream;
    //    _syrup = syrup;
    //}

    //public void MakeFrappucinno()
    //{
    //    _coffee.CoffeeBeanType("Arabica");
    //    _coffee.IsHotCold("Cold");
    //    _coffee.IsInstant("Brewed");

    //    _creamer.Creamer("Creamer Added");

    //    _sugar.SugarLevel("With 25% Sugar");

    //    _whippedCream.WhippedCream("Whipped Cream added");

    //    _syrup.Syrup("Caramel syrup added on top");
    //}
    #endregion
    public void CoffeeBeanType(string beanType)
    {
        Console.WriteLine($"{beanType} is selected");
    }

    public void Creamer(string creamer)
    {
        Console.WriteLine("Creamer added");
    }

    public void IsHotCold(string hotColdIndicator)
    {
        Console.WriteLine($"The default temperature is cold.");
    }

    public void IsInstant(string instantSelector)
    {
        Console.WriteLine("The base used is Brewed Coffee");
    }

    public void SugarLevel(string sugarLevel)
    {
        Console.WriteLine("Sugar level selected by default");
    }

    public void Syrup(string? syrup)
    {
        if (syrup is not null)
        {
            Console.WriteLine($"{syrup} is added");
        }
        else
        {
            Console.WriteLine($"Default syrup is added");
        }
    }

    public void WhippedCream(string? whippedCream)
    {
        if(whippedCream is not null)
        {
            Console.WriteLine($"Option added: {whippedCream}");
        }
        else
        {
            Console.WriteLine("Whipped Cream is added");
        }
    }
}
