namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.AmbientContext;

public class BuildingContext : IDisposable
{
    public int WallHeight;
    private static Stack<BuildingContext> _stack = new();

    static BuildingContext()
    {
        _stack.Push(new BuildingContext(0));
    }

    public BuildingContext(int wallHeight)
    {
        WallHeight = wallHeight;
        _stack.Push(this);
    }

    public static BuildingContext Current => _stack.Peek();

    public void Dispose()
    {
        if (_stack.Count > 1)
            _stack.Pop();
    }
}