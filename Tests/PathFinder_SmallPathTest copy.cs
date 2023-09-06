using Xunit;

namespace Pathfinding.Tests;

public class Pathfinder_SmallPathTest
{
    


    [Fact]
    public void Test()
    {

        Pathfinder p=new Pathfinder(4,4,0,0,2,1);

        p.AddWall(0,3);
        p.AddWall(2,0);
        p.AddWall(1,1);
        p.AddWall(2,2);
        /*
        S.W.
        .WF.
        ..W.
        W...

        */
        var path=p.FindPath();
        Assert.NotNull(path);
        Assert.True(path.Length==9,"Expected 9 got "+path.Length);
    
    }
}