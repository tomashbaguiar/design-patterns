using Autofac;
using DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.DependencyInjection;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Adapter;

public class DependencyInjectionTest
{
    [Fact]
    public void Test()
    {
        var builder = new ContainerBuilder();
        builder.RegisterType<SaveCommand>().As<ICommand>();
        builder.RegisterType<OpenCommand>().As<ICommand>();
        builder.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));
        builder.RegisterType<Editor>();

        using var container = builder.Build();
        var editor = container.Resolve<Editor>();
        editor.ClickAll();
    }
}