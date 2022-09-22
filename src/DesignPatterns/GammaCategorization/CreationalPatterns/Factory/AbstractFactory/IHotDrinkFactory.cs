namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.AbstractFactory;

public interface IHotDrinkFactory
{
    IHotDrink Prepare(int amount);
}