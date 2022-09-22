namespace DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.AmbientContext;

public class Wall
{
    public Point Start;
    public Point End;
    public int Height;

    public Wall(Point start, Point end)
    {
        Start = start;
        End = end;
        Height = BuildingContext.Current.WallHeight;
    }
}