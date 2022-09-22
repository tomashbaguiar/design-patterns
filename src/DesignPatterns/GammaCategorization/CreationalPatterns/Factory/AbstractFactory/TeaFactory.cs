namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.AbstractFactory;

internal class TeaFactory : IHotDrinkFactory
{
    public IHotDrink Prepare(int amount)
    {
        return new Tea();
    }
}