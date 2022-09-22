namespace DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.GenericValue;

public class Vector2i : VectorOfInt<Dimension.Two>
{
    public Vector2i()
    {
        
    }

    public Vector2i(params int[] values) : base(values)
    {
        
    }
}