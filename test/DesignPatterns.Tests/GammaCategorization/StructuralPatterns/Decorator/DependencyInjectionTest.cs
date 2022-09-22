using Autofac;
using DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DependencyInjection;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Decorator;

public class DependencyInjectionTest
{
    [Fact]
    public void Test()
    {
        const string serviceName = "Reporting";
        var containerBuilder = new ContainerBuilder();
        containerBuilder.RegisterType<ReportingService>().Named<IReportingService>(serviceName);
        containerBuilder.RegisterDecorator<IReportingService>(
            (_, service) => new ReportingServiceWithLogging(service), serviceName);
        const string expected = "Commencing log..." + "\r\n"
                                                    + "Here is your report" + "\r\n"
                                                    + "Ending log...";

        using var container = containerBuilder.Build();
        var resolve = container.Resolve<IReportingService>();
        var result = resolve.Report();
        
        Assert.Matches(expected, result);
    }
}