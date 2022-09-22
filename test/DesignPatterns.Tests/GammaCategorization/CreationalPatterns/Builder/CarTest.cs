using DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Stepwise;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Builder;

public class CarTest
{
    [Fact]
    public void Test()
    {
        const CarType carType = CarType.Crossover;
        const int diameter = 18;
        
        var car = CarBuilder.Create()
            .OfType(carType)
            .WithWheels(diameter)
            .Build();
        
        Assert.Equal(car.Type, carType);
        Assert.Equal(car.WheelSize, diameter);
    }
}