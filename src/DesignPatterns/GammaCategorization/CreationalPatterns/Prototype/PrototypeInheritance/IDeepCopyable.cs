namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.PrototypeInheritance;

public interface IDeepCopyable<T> where T : new()
{
    void CopyTo(T target);

    public T DeepCopy()
    {
        var t = new T();
        CopyTo(t);
        return t;
    }
}