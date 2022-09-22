namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.FactoryMethod;

public class Point
{
    public double X { get; }
    public double Y { get; }

    private Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    
    public static Point NewCartesianPoint(double x, double y)
    {
        return new Point(x, y);
    }
    
    public static Point NewPolarPoint(double rho, double theta)
    {
        return new Point(rho, theta);
    }
}