namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Stepwise;

public interface ISpecifyCarType
{
    ISpecifyWheelSize OfType(CarType type);
}