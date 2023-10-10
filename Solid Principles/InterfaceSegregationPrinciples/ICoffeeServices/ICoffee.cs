namespace Solid_Principles.InterfaceSegregationPrinciples.ICoffeeServices;

public interface ICoffee
{
    void CoffeeBeanType(string beanType);
    void IsInstant(string instantSelector);
    void IsHotCold(string hotColdIndicator);
}
