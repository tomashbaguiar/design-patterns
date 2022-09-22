namespace DesignPatterns.SolidPrinciples.DependencyInversion.Correct;

public interface IRelationshipBrowser
{
    List<(Person, Relationship, Person)> FindAllChildrenOf(string name);
}