namespace DesignPatterns.SolidPrinciples.DependencyInversion.Correct;

public class Relationships : IRelationshipBrowser
{
    private readonly List<(Person, Relationship, Person)> _relations = new();

    public void AddParentAndChild(Person parent, Person child)
    {
        _relations.Add((parent, Relationship.Parent, child));
        _relations.Add((child, Relationship.Child, parent));
    }

    public List<(Person, Relationship, Person)> FindAllChildrenOf(string name)
    {
        return _relations.FindAll(p => 
            p.Item2 == Relationship.Parent && string.Equals(p.Item1.Name, name));
    }
}