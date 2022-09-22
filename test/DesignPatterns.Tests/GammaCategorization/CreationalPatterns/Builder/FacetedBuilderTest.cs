using DesignPatterns.GammaCategorization.CreationalPatterns.Builder.Faceted;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Builder;

public class FacetedBuilderTest
{
    [Fact]
    public void Test()
    {
        const string companyName = "some-name";
        const string position = "some-position";
        const int amount = int.MaxValue;
        const string streetAddress = "some-address";
        const string postcode = "some-post-code";
        const string city = "some-city";
        var expected = $"{companyName}, {position}, {amount}, {streetAddress}, {postcode}, {city}";
        
        var personBuilder = new PersonBuilder();
        Person person = personBuilder
            .Works.At(companyName)
                .As(position)
                .Earning(amount)
            .Lives.At(streetAddress)
                .WithPostCode(postcode)
                .In(city);

        Assert.Matches(expected, person.ToString() ?? throw new InvalidOperationException());
    }
}