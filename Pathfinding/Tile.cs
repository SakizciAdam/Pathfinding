using System;
using System.Collections.Generic;

namespace Pathfinding {
    public class Tile {
        public readonly int x,y;
        public readonly Tile? parent;

        public Tile(int x,int y){
            this.x=x;
            this.y=y;
            this.parent=null;
        }
        public Tile(Tile parent,int x,int y){
            this.x=x;
            this.y=y;
            this.parent=parent;
        }

        public int[] ConvertToIntArray(){
            return new int[]{x,y};
        }

        public List<Tile> GetNeighbors(Pathfinder ph,List<Tile> visitedTiles){
            List<Tile> tiles=new List<Tile>();
   
            for(int a=-1;a<2;a++){
                for(int b=-1;b<2;b++){
                    if(Math.Abs(a)+Math.Abs(b)==1){
                        if(ph.IsValid(a+x,b+y)&&!ph.IsVisited(visitedTiles,a+x,b+y)){
                            tiles.Add(new Tile(this,a+x,b+y));
                        }
                    }
                }
            }
            return tiles;
        }
    }
}