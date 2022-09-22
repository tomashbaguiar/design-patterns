namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.PerThreadSingleton;

public sealed class PerThreadSingleton
{
    private static ThreadLocal<PerThreadSingleton> _threadInstance = new(() => new PerThreadSingleton());
    public int Id;

    public PerThreadSingleton()
    {
        Id = Thread.CurrentThread.ManagedThreadId;
    }

    public static PerThreadSingleton Instance => _threadInstance.Value;
}