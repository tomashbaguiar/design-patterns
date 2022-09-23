using DesignPatterns.GammaCategorization.StructuralPatterns.Proxy.ProtectionProxy;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Proxy;

public class ProtectionProxyTest
{
    [Theory]
    [InlineData(18, "Car is being driven")]
    [InlineData(15, "Too young")]
    public void Test(int age, string expected)
    {
        ICar car = new CarProxy(new Driver(age));

        var result = car.Drive();
        
        Assert.Matches(expected, result);
    }
}