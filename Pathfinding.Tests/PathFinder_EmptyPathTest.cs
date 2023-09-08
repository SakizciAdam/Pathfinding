using Xunit;

namespace Pathfinding.Tests;

public class PathFinder_EmptyPathTest
{
    


    [Fact]
    public void Test()
    {

        Pathfinder p=new Pathfinder(10,10,0,0,9,9);


        Assert.NotNull(p.FindPath());
    }
}