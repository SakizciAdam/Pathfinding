using Pathfinding.Utils;
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
        
        var d2=PathfindingUtils.ConvertTo2DArray(path);
        var expected=new int[][]{new int[]{0,0},new int[]{0,1},new int[]{0,2},new int[]{1,2},new int[]{1,3},new int[]{2,3},new int[]{3,3},new int[]{3,2},new int[]{3,1},new int[]{2,1}};
        Assert.Equal(expected,d2);
    }
}