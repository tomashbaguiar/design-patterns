namespace DesignPatterns.SolidPrinciples.DependencyInversion.Wrong;

public class Research
{
    public Research(Relationships relationships, Person parent)
    {
        var relations = relationships.Relations;
        var relationsOfParent = relations
            .Where(x => string.Equals(x.Item1.Name, parent.Name) && x.Item2 == Relationship.Parent)
            .ToList();

        relationsOfParent.ForEach(r => Console.WriteLine(r.Item3.Name));
    }
}