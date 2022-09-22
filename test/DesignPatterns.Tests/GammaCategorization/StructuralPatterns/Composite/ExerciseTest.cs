using DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Exercise;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Composite;

public class ExerciseTest
{
    [Fact]
    public void Test()
    {
        var single = new SingleValue
        {
            Value = 3
        };
        var many = new ManyValues
        {
            4, 5
        };
        var containers = new List<IValueContainer>
        {
            single, many,
        };

        var sum = containers.Sum();
        
        Assert.Equal(12, sum);
    }
}