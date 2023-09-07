using System;
using System.Collections.Generic;

namespace Pathfinding {
    public class Pathfinder {
        public int startX,startY,endX,endY;
        public readonly int width,height;

        private List<Tile> visited=new List<Tile>();

        public Pathfinder(int width,int height,int startX=0,int startY=0,int endX=1,int endY=1){
            this.width=width;
            this.height=height;
            this.startX=startX;
            this.startY=startY;
            this.endX=endX;
            this.endY=endY;
        }

        public List<Tile> wallLocations=new List<Tile>();
       
        public void AddWall(int x,int y){
            wallLocations.Add(new Tile(x,y));

        }

        public bool IsEnd(Tile tile){
            return tile.x==endX&&tile.y==endY;
        }

        public void Clear(){
            visited.Clear();
        }

        private Tile[] RetracePath(Tile endTile){
            List<Tile> tiles=new List<Tile>();
            Tile current=endTile;
            tiles.Add(current);
            while(true){
                if(current.parent==null){
                    throw new NullReferenceException();
                }
                current=current.parent;
                tiles.Add(current);
                if(current.x==startX&&current.y==startY){
                    break;
                }
            }
            tiles.Reverse();
            return tiles.ToArray();
        }

        public bool IsVisited(int x,int y){
            return visited.FindAll(a => a.x==x&a.y==y).Count>0;
        }

        public bool IsVisited(Tile tile){
            return IsVisited(tile.x,tile.y);
        }

        public bool IsValid(int x,int y){
            if(x<0||y<0||x>=width||y>=height){
                return false;
            }

            return wallLocations.Find(wall => wall.x==x&&wall.y==y)==null;
        }

        
        public Tile[]? FindPath(){
            

            visited.Add(new Tile(startX,startY));
            for(int i=0;i<visited.Count;i++){
                Tile current=visited[i];
                
                foreach(Tile tile in current.GetNeighbors(this,visited)){
                    
                    if(IsEnd(tile)){
                            
                        return RetracePath(tile);
                    }
                    visited.Add(tile);
                }
           
                
            }

            return null;

        }

        
    }
}