namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.ProtectionProxy;

public class CarProxy : ICar
{
    public Driver Driver;
    private Car _car = new();

    public CarProxy(Driver driver)
    {
        Driver = driver;
    }

    public string Drive()
    {
        return Driver.Age >= 16
            ? _car.Drive()
            : "Too young";
    }
}