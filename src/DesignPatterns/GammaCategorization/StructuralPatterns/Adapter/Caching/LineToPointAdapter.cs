using System.Collections;

namespace DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.Caching;

public class LineToPointAdapter : IEnumerable<Point>
{
    private static int _count;
    private static Dictionary<int, List<Point>> _cache = new();

    public LineToPointAdapter(Line line)
    {
        var hash = line.GetHashCode();
        if (_cache.ContainsKey(hash)) return;

        _count++;

        var points = new List<Point>();
        
        var left = Math.Min(line.Start.X, line.End.X);
        var right = Math.Max(line.Start.X, line.End.X);
        var top = Math.Min(line.Start.Y, line.End.Y);
        var bottom = Math.Max(line.Start.Y, line.End.Y);
        var dx = right - left;
        var dy = line.End.Y - line.Start.Y;

        if (dx == 0)
        {
            for (var y = top; y <= bottom; ++y)
            {
                points.Add(new Point(left, y));
            }
        }
        else if (dy == 0)
        {
            for (var x = left; x <= right; ++x)
            { 
                points.Add(new Point(x, top));
            }
        }
        
        _cache.Add(hash, points);
    }

    public IEnumerator<Point> GetEnumerator()
    {
        return _cache.Values.SelectMany(x => x).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}