namespace DesignPatterns.GammaCategorization.CreationalPatterns.Factory.Wrong;

public class Point
{
    public double X { get; }
    public double Y { get; }

    /// <summary>
    /// Initializes a point from EITHER cartesian or polar
    /// </summary>
    /// <param name="a">x if cartesian, rho if polar</param>
    /// <param name="b">y if cartesian, theta if polar</param>
    /// <param name="system">cartesian or polar</param>
    public Point(double a, double b, CoordinateSystem system = CoordinateSystem.Cartesian)
    {
        switch (system)
        {
            case CoordinateSystem.Cartesian:
                X = a;
                Y = b;
                break;
            case CoordinateSystem.Polar:
                X = a * Math.Cos(b);
                Y = a * Math.Sin(b);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(system), system, null);
        }
    }
}