using DesignPatterns.GammaCategorization.CreationalPatterns.Singleton.AmbientContext;

namespace DesignPatterns.Tests.GammaCategorization.CreationalPatterns.Singleton;

public class AmbientContextTest
{
    [Fact]
    public void Test()
    {
        var house = new Building();
        const int height1 = 3000;
        const int height2 = 3500;

        using (new BuildingContext(height1))
        {
            house.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
            house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
            Assert.Equal(height1, house.Walls.Last().Height);

            using (new BuildingContext(height2))
            {
                house.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
                house.Walls.Add(new Wall(new Point(0, 0), new Point(6000, 0)));
                Assert.Equal(height2, house.Walls.Last().Height);
            }

            house.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)));
            Assert.Equal(height1, house.Walls.Last().Height);
        }
    }
}