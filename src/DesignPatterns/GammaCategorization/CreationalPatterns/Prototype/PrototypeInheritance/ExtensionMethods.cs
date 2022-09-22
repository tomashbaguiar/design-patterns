namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.PrototypeInheritance;

public static class ExtensionMethods
{
    public static T DeepCopy<T>(this IDeepCopyable<T> target) where T : new()
    {
        return target.DeepCopy();
    }

    public static T DeepCopy<T>(this T person) where T : Person, new()
    {
        return ((IDeepCopyable<T>)person).DeepCopy();
    } 
}