namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Faceted;

public class Person
{
    public string StreetAddress;
    public string Postcode;
    public string City;
    public string CompanyName;
    public int AnnualIncome;
    public string Position;

    public override string ToString()
    {
        return $"{CompanyName}, {Position}, {AnnualIncome}, {StreetAddress}, {Postcode}, {City}";
    }
}