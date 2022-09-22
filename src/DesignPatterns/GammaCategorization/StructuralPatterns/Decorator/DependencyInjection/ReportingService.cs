namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DependencyInjection;

public class ReportingService : IReportingService
{
    public string Report()
    {
        return "Here is your report";
    }
}