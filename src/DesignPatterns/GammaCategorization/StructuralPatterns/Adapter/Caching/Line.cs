namespace DesignPatterns.GammaCategorization.StructuralPatterns.Adapter.Caching;

public class Line
{
    public Point Start;
    public Point End;

    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }

    protected bool Equals(Line other)
    {
        return Start.Equals(other.Start) && End.Equals(other.End);
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Line)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Start, End);
    }
}