using Xunit;

namespace Pathfinding.Tests;

public class PathFinder_ObstacleTest
{
    


    [Fact]
    public void Test()
    {

        Pathfinder p=new Pathfinder(10,10,0,0,9,9);

        p.AddWall(9, 8,1);

        Assert.Null(p.FindPath());

    }
}