namespace DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.GenericValue;

public class Vector<T, D> where D : IInteger, new()
{
    protected T[] Data;

    public Vector()
    {
        Data = new T[new D().Value];
    }

    public Vector(params T[] values)
    {
        var requiredSize = new D().Value;
        Data = new T[requiredSize];

        var providedSize = values.Length;

        for (var i = 0; i < Math.Min(requiredSize, providedSize); i++)
            Data[i] = values[i];
    }

    public T this[int index]
    {
        get => Data[index];
        set => Data[index] = value;
    }

    public T X
    {
        get => Data[0];
        set => Data[0] = value;
    }
}