namespace DesignPatterns.GammaCategorization.CreationalPatterns.Prototype.Wrong.DeepCopyInterface;

public interface IPrototype<out T>
{
    T DeepCopy();
}