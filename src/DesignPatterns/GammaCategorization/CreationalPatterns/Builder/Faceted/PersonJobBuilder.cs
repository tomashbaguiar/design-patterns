namespace DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Faceted;

public class PersonJobBuilder 
    : PersonBuilder
{
    public PersonJobBuilder(Person person)
    {
        Person = person;
    }

    public PersonJobBuilder At(string companyName)
    {
        Person.CompanyName = companyName;
        return this;
    }

    public PersonJobBuilder As(string position)
    {
        Person.Position = position;
        return this;
    }

    public PersonJobBuilder Earning(int amount)
    {
        Person.AnnualIncome = amount;
        return this;
    }
}