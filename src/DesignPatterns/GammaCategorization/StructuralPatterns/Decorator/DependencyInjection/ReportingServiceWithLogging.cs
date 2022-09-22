namespace DesignPatterns.GammaCategorization.StructuralPatterns.Decorator.DependencyInjection;

public class ReportingServiceWithLogging : IReportingService
{
    private readonly IReportingService _decorated;

    public ReportingServiceWithLogging(IReportingService decorated)
    {
        _decorated = decorated;
    }

    public string Report()
    {
        var stringBuilder = new System.Text.StringBuilder();
        stringBuilder.AppendLine("Commencing log...")
            .AppendLine(_decorated.Report())
            .AppendLine("Ending log...");
        return stringBuilder.ToString();
    }
}