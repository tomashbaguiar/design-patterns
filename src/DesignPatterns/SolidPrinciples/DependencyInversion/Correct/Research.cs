namespace DesignPatterns.SolidPrinciples.DependencyInversion.Correct;

public class Research
{
    public Research(IRelationshipBrowser relationshipBrowser, string name)
    {
        var relations = relationshipBrowser.FindAllChildrenOf(name);
        relations.ForEach(r => Console.WriteLine(r.Item3.Name));
    }
}