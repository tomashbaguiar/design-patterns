using DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.ValueProxy;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Proxy;

public class ValueProxyTest
{
    [Fact]
    public void Test_Multiplication()
    {
        const float number = 10f;
        
        var result = number * 5.Percent();
        
        Assert.Equal(0.5f, result);
    }
    
    [Fact]
    public void Test_Sum()
    {
        var result = 4.Percent() + 5.Percent();
        
        Assert.Equal(9.Percent(),result);
    }

    [Fact]
    public void Test_ToString()
    {
        Assert.Matches("4%", 4.Percent().ToString());
    }
}