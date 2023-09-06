using Xunit;

namespace Pathfinding.Tests;

public class Pathfinder_ImpossiblePathTest
{
    


    [Fact]
    public void Test()
    {

        Pathfinder p=new Pathfinder(10,10,0,0,9,9);

        p.AddWall(9,8);
        p.AddWall(8,9);
        Assert.Null(p.FindPath());
    }
}