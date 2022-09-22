namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.AbstractFactory;

public class HotDrinkMachine
{
    private readonly List<Tuple<string, IHotDrinkFactory>> _factories = new();

    public HotDrinkMachine()
    {
        foreach (var type in typeof(HotDrinkMachine).Assembly.GetTypes())
        {
            if (typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
            {
                _factories.Add(Tuple.Create(
                    type.Name.Replace("Factory", string.Empty),
                    (IHotDrinkFactory) Activator.CreateInstance(type))
                );
            }
        }
    }

    public IHotDrink MakeDrink(int drinkIndex, int amount)
    {
        return _factories[drinkIndex].Item2.Prepare(amount);
    }
}