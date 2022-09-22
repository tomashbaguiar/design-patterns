namespace DesignPatterns.GammaCategorization.StructuralPatterns.Bridge;

public abstract class Shape
{
    protected IRenderer _renderer;

    protected Shape(IRenderer renderer)
    {
        _renderer = renderer;
    }

    public abstract void Draw();
    public abstract void Resize(float factor);
}