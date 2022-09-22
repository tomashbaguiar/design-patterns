namespace DesignPatterns.SolidPrinciples.InterfaceSegregation.Wrong;

public class MultiFunctionalPrinter : IMachine
{
    public void Print(Document document)
    {
        //
    }

    public void Scan(Document document)
    {
        //
    }

    public void Fax(Document document)
    {
        //
    }
}