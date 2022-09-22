namespace DesignPatterns.SolidPrinciples.DependencyInversion.Wrong;

public class Relationships
{
    private List<(Person, Relationship, Person)> _relations = new();

    public void AddParentAndChild(Person parent, Person child)
    {
        _relations.Add((parent, Relationship.Parent, child));
        _relations.Add((child, Relationship.Child, parent));
    }

    public List<(Person, Relationship, Person)> Relations => _relations;
}