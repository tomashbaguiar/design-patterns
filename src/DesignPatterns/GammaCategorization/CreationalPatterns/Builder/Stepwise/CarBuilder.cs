namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Stepwise;

public class CarBuilder
{
    private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
    {
        private Car _car = new();
        
        public ISpecifyWheelSize OfType(CarType type)
        {
            _car.Type = type;
            return this;
        }

        public IBuildCar WithWheels(int size)
        {
            switch (_car.Type)
            {
                case CarType.Crossover when size is < 17 or > 20:
                case CarType.Sedan when size is < 15 or > 17:
                    throw new ArgumentException($"Wrong size of wheel for {_car.Type}");  
                default:
                    _car.WheelSize = size;
                    return this;
            }
        }

        public Car Build()
        {
            return _car;
        }
    }
    
    public static ISpecifyCarType Create()
    {
        return new Impl();
    }
}