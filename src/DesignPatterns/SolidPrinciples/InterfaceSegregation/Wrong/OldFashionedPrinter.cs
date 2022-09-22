namespace DesignPatterns.SolidPrinciples.InterfaceSegregation.Wrong;

public class OldFashionedPrinter : IMachine
{
    public void Print(Document document)
    {
        //
    }

    public void Scan(Document document)
    {
        throw new NotImplementedException();
    }

    public void Fax(Document document)
    {
        throw new NotImplementedException();
    }
}