namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.AbstractFactory;

internal class CoffeeFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        return new Coffee();
    }
}