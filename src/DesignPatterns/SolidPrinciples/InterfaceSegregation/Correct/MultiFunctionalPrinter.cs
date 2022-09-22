namespace DesignPatterns.SolidPrinciples.InterfaceSegregation.Correct;

public class MultiFunctionalPrinter : IMultifunctionDevice
{
    private readonly IPrinter _printer;
    private readonly IScanner _scanner;
    private readonly ICopier _copier;
    
    public MultiFunctionalPrinter(IPrinter printer, IScanner scanner, ICopier copier)
    {
        _printer = printer;
        _scanner = scanner;
        _copier = copier;
    }

    public void Print(Document document)
    {
        _printer.Print(document);
    }

    public void Scan(Document document)
    {
        _scanner.Scan(document);
    }

    public void Fax(Document document)
    {
        _copier.Fax(document);
    }
}