using Autofac;
using DesignPatterns.GammaCategorization.StructuralPatterns.Bridge;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Bridge;

public class BridgeTest
{
    [Fact]
    public void Test()
    {
        // var renderer = new RasterRenderer();
        var renderer = new VectorRenderer();
        var circle = new Circle(renderer, 5);
        
        circle.Draw();
        circle.Resize(2);
        circle.Draw();
    }
    
    [Fact]
    public void Test2()
    {
        var containerBuilder = new ContainerBuilder();
        containerBuilder.RegisterType<RasterRenderer>()
            .As<IRenderer>()
            .SingleInstance();
        containerBuilder.Register((c, p) =>
            new Circle(c.Resolve<IRenderer>(), p.Positional<float>(0))
        );
        using var container = containerBuilder.Build();
        var circle = container.Resolve<Circle>(
            new PositionalParameter(0, 5.0f)
            );
        
        circle.Draw();
        circle.Resize(2);
        circle.Draw();
    }
}