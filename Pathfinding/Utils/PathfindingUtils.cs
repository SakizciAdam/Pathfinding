using System;
using System.Collections.Generic;
using System.IO;

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

        

        
      
        public static void PrintPath(Pathfinder pathfinder){
            for(int y=0;y<pathfinder.height;y++){
                for(int x=0;x<pathfinder.width;x++){
                    char c='.';

                    if(pathfinder.IsVisited(x,y)){
                        if(!pathfinder.IsValid(x,y)){
                            c='E';
                        } else {
                            c='O';
                        }
                    } else if(pathfinder.IsWall(x,y)){
                        c='W';
                    }
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}