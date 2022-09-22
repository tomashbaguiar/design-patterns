using Wrong = DesignPatterns.GammaCategorization.CreationalPatterns.Factory.Wrong;
using FactoryMethod = DesignPatterns.GammaCategorization.CreationalPatterns.Factory.FactoryMethod;
using SRP = DesignPatterns.GammaCategorization.CreationalPatterns.Factory.FactorySRP;
using DesignPatterns.GammaCategorization.CreationalPatterns.Factory.FactorySRP.InnerFactory;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Factory;

public class PointTest
{
    [Fact]
    public void PointIsInCartesianSystem_Wrong()
    {
        const double x = double.Epsilon;
        const double y = double.MaxValue;

        var point = new Wrong.Point(x, y);
        
        Assert.Equal(x, point.X);
        Assert.Equal(y, point.Y);
    }
    
    [Fact]
    public void PointIsInPolarSystem_Wrong()
    {
        const double rho = double.Epsilon;
        const double theta = double.MaxValue;
        var expectedX = rho * Math.Cos(theta);
        var expectedY = rho * Math.Sin(theta);

        var point = new Wrong.Point(rho, theta, Wrong.CoordinateSystem.Polar);
        
        Assert.Equal(expectedX, point.X);
        Assert.Equal(expectedY, point.Y);
    }
    
    [Fact]
    public void PointIsInCartesianSystem_FactoryMethod()
    {
        const double x = double.Epsilon;
        const double y = double.MaxValue;

        var point = FactoryMethod.Point.NewCartesianPoint(x, y);
        
        Assert.Equal(x, point.X);
        Assert.Equal(y, point.Y);
    }
    
    [Fact]
    public void PointIsInPolarSystem_FactoryMethod()
    {
        const double rho = double.Epsilon;
        const double theta = double.MaxValue;

        var point = FactoryMethod.Point.NewPolarPoint(rho, theta);
        
        Assert.Equal(rho, point.X);
        Assert.Equal(theta, point.Y);
    }
    
    [Fact]
    public void PointIsInCartesianSystem_Factory_WithSingleResponsibilityPrincipleApplied()
    {
        const double x = double.Epsilon;
        const double y = double.MaxValue;

        var point = SRP.PointFactory.NewCartesianPoint(x, y);
        
        Assert.Equal(x, point.X);
        Assert.Equal(y, point.Y);
    }
    
    [Fact]
    public void PointIsInPolarSystem_Factory_WithSingleResponsibilityPrincipleApplied()
    {
        const double rho = double.Epsilon;
        const double theta = double.MaxValue;

        var point = SRP.PointFactory.NewPolarPoint(rho, theta);
        
        Assert.Equal(rho, point.X);
        Assert.Equal(theta, point.Y);
    }
    
    [Fact]
    public void PointIsInCartesianSystem_InnerFactory_WithSingleResponsibilityPrincipleApplied()
    {
        const double x = double.Epsilon;
        const double y = double.MaxValue;

        var point = Point.Factory.NewCartesianPoint(x, y);
        
        Assert.Equal(x, point.X);
        Assert.Equal(y, point.Y);
    }
    
    [Fact]
    public void PointIsInPolarSystem_InnerFactory_WithSingleResponsibilityPrincipleApplied()
    {
        const double rho = double.Epsilon;
        const double theta = double.MaxValue;

        var point = Point.Factory.NewPolarPoint(rho, theta);
        
        Assert.Equal(rho, point.X);
        Assert.Equal(theta, point.Y);
    }
}