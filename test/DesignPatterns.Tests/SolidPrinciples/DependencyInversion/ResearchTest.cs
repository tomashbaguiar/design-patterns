using DesignPatterns.SolidPrinciples.DependencyInversion;
using NSubstitute;
using Wrong = DesignPatterns.SolidPrinciples.DependencyInversion.Wrong;
using Correct = DesignPatterns.SolidPrinciples.DependencyInversion.Correct;

namespace DesignPatterns.Tests.SolidPrinciples.DependencyInversion;

public class ResearchTest
{
    [Fact]
    public void Test_Wrong()
    {
        var parent = new Person { Name = "person1" };
        var child1 = new Person { Name = "person2" };
        var child2 = new Person { Name = "person3" };

        var relationships = new Wrong.Relationships();
        relationships.AddParentAndChild(parent, child1);
        relationships.AddParentAndChild(parent, child2);

        var unused = new Wrong.Research(relationships, parent);
    }
    
    [Fact]
    public void Test_Correct()
    {
        const string name = "some-name";
        var returnValue = new List<(Person, Relationship, Person)>();
        var relationships = Substitute.For<Correct.IRelationshipBrowser>();
        relationships.FindAllChildrenOf(name).Returns(returnValue);

        var unused = new Correct.Research(relationships, name);

        relationships.Received(1).FindAllChildrenOf(name);
    }
}