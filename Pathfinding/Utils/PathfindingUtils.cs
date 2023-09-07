using System;
using System.Collections.Generic;

namespace Pathfinding.Utils {
    public static class PathfindingUtils {
        public static int[][] ConvertTo2DArray(Tile[]? tiles){
            if(tiles==null){
                return new int[0][];
            }
            int[][] path=new int[tiles.Length][];
            for(int i=0;i<tiles.Length;i++){
                path[i]=new int[]{tiles[i].x,tiles[i].y};
            } 
            return path;
        }
    }
}