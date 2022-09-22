using DesignPatterns.GammaCategorization.StructuralPatterns.Facade;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Facade;

public class FacadeTest
{
    [Fact]
    public void Test()
    {
        const int size = 5;

        var result = MagicSquareGenerator.Generate(size);
    }
}