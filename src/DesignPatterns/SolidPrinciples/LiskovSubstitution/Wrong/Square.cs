namespace DesignPatterns.SolidPrinciples.LiskovSubstitution.Wrong;

public class Square : Rectangle
{
    public new int Width
    {
        set => base.Width = base.Height = value;
    }
    
    public new int Height
    {
        set => base.Width = base.Height = value;
    }
}