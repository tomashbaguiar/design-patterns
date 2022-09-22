using DesignPatterns.GammaCategorization.StructuralPatterns.Flyweight;
using JetBrains.dotMemoryUnit;
using Xunit.Abstractions;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Flyweight;

public class UserTest
{
    public UserTest(ITestOutputHelper testOutputHelper)
    {
        DotMemoryUnitTestOutput.SetOutputMethod(testOutputHelper.WriteLine);
    }

    [Fact]
    public void Test_WithoutFlyweight()
    {
        var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
        var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());
        var unused = (from firstName in firstNames 
            from lastName in lastNames 
            select new User($"{firstName} {lastName}"))
            .ToList();

        ForceGc();

        dotMemory.Check(memory =>
        {
            Assert.InRange(memory.SizeInBytes, 8400000, 8500000);
        });
    }
    
    [Fact]
    public void Test_WithFlyweight()
    {
        var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString());
        var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString());
        var unused = (from firstName in firstNames 
                from lastName in lastNames 
                select new FlyweightUser($"{firstName} {lastName}"))
            .ToList();

        ForceGc();

        dotMemory.Check(memory =>
        {
            Assert.InRange(memory.SizeInBytes, 8600000, 8700000); // Should be less then without
        });
    }

    private static void ForceGc()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }

    private static string RandomString()
    {
        var rand = new Random();
        return new string(
            Enumerable.Range(0, 10)
                .Select(i => (char)('a' + rand.Next(26)))
                .ToArray()
            );
    }
}