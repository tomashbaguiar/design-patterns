namespace DesignPatterns.GammaCategorization.StructuralPatterns.Composite.Exercise;

public static class ExtensionMethods
{
    public static int Sum(this List<IValueContainer> containers)
    {
        return containers.SelectMany(container => container).Sum();
    }
}