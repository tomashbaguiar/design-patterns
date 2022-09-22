namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Stepwise;

public interface ISpecifyWheelSize
{
    IBuildCar WithWheels(int size);
}