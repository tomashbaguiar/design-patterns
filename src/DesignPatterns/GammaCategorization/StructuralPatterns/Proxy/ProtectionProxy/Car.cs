namespace DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.ProtectionProxy;

public class Car : ICar
{
    public string Drive()
    {
        return "Car is being driven";
    }
}