namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.FactorySRP;

public static class PointFactory
{
    public static Point NewCartesianPoint(double x, double y)
    {
        return new Point(x, y);
    }
    
    public static Point NewPolarPoint(double rho, double theta)
    {
        return new Point(rho, theta);
    }
}