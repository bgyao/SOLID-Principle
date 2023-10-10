using Solid_Principles.InterfaceSegregationPrinciples.CoffeeServices;

namespace Solid_Principles.InterfaceSegregationPrinciples;

public class Barista
{
    static void Main(string[] args)
    {
        BlackCoffee blackCoffee = new BlackCoffee();
        NescafeInstantCoffeeService instantCoffee = new NescafeInstantCoffeeService();
        Frappuccino frappe = new Frappuccino();

        blackCoffee.CoffeeBeanType("Barako");
        blackCoffee.IsHotCold("Hot");
        blackCoffee.IsInstant("Default");

        instantCoffee.CoffeeBeanType("default");
        instantCoffee.IsInstant("Yes");
        instantCoffee.IsHotCold("Hot");
        instantCoffee.Creamer("default");
        instantCoffee.SugarLevel("default");

        frappe.CoffeeBeanType("Default");
        frappe.IsHotCold("Default");
        frappe.IsInstant("Default");
        frappe.Creamer("Default");
        frappe.WhippedCream("Extra Whipped Cream"); //could be less
        frappe.Syrup("Extra Syrup");
    }
}
