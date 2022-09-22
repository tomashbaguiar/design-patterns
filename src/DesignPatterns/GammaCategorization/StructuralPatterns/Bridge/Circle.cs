namespace DesignPatterns.GammaCategorization.StructuralPatterns.Bridge;

public class Circle : Shape
{
    private float _radius;

    public Circle(IRenderer renderer, float radius) : base(renderer)
    {
        _radius = radius;
    }

    public Circle(IRenderer renderer) : base(renderer)
    {
    }

    public override void Draw()
    {
        throw new NotImplementedException();
    }

    public override void Resize(float factor)
    {
        _radius *= factor;
    }
}