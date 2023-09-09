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

        
        public static string PathToString(Pathfinder pathfinder, char error = 'E', char visited = 'O', char wall = 'W', char def = '.')
        {
            string s = "";

            for (int y = 0; y < pathfinder.height; y++)
            {
                for (int x = 0; x < pathfinder.width; x++)
                {
                    char c = def;

                    if (pathfinder.IsVisited(x, y))
                    {
                        if (!pathfinder.IsValid(x, y))
                        {
                            c = error;
                        }
                        else
                        {
                            c = visited;
                        }
                    }
                    else if (pathfinder.IsWall(x, y))
                    {
                        c = wall;
                    }
                    s+= c;  
                }
                s+= "\n";
            }
            return s;
      
        }
        
      
        public static void PrintPath(Pathfinder pathfinder,char error='E',char visited='O',char wall='W',char def='.'){
            
            Console.Write(PathToString(pathfinder,error,visited,wall,def));
        }
    }
}