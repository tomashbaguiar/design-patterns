using DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.Caching;

namespace DesignPatterns.Tests.GammaCategorization.StructuralPatterns.Adapter;

public class AdapterTest
{
    private static readonly List<VectorObject> VectorObjects = new()
    {
        new VectorRectangle(1, 1, 10, 10),
        new VectorRectangle(3, 3, 6, 6),
    };
    
    [Fact]
    public void Test()
    {
        Draw();
    }

    private static void Draw()
    {
        foreach (var vector in VectorObjects)
        {
            foreach (var line in vector)
            {
                var adapter = new LineToPointAdapter(line);
                foreach (var point in adapter)
                {
                    DrawPoint(point);
                }
            }
        }
    }

    public static void DrawPoint(Point p)
    {
        Console.Write(".");
    }
}