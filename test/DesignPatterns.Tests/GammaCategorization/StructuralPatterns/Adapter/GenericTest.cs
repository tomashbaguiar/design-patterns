using DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.GenericValue;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Adapter;

public class GenericTest
{
    [Fact(Skip = "skip for now")]
    public void Test()
    {
        var v = new Vector2i(1, 2)
        {
            [0] = 0
        };

        var vv = new Vector2i(3, 2);

        var result = v + vv;
    }
}