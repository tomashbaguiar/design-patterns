namespace DesignPatterns.SolidPrinciples.LiskovSubstitution.Wrong;

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle()
    { }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public override string ToString()
    {
        return $"{nameof(Width)}: {Width}, {nameof(Height)}: {Height}";
    }
}