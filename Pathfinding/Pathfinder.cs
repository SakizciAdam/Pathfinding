using System;
using System.Collections.Generic;

namespace Pathfinding {
    public class Pathfinder {
        public int startX,startY,endX,endY;
        public readonly int width,height;

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

        private Tile[] RetracePath(Tile endTile){
            List<Tile> tiles=new List<Tile>();
            Tile current=endTile;
            
            while(true){
                
                current=current.parent;
                tiles.Add(current);
                if(current.x==startX&&current.y==startY){
                    break;
                }
            }
         
            return tiles.ToArray();
        }

        public void PrintPath(){
            PrintPath(new List<Tile>());
        }
        public void PrintPath(List<Tile> visited){
            for(int y=0;y<height;y++){
                for(int x=0;x<width;x++){
                    char c='.';

                    if(IsVisited(visited,x,y)){
                        if(!IsValid(x,y)){
                            c='E';
                        } else {
                            c='O';
                        }
                    } else if(!IsValid(x,y)){
                        c='W';
                    }

                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private bool IsVisited(List<Tile> visited,int x,int y){
            return visited.FindAll(a => a.x==x&a.y==y).Count>0;
        }

        private bool IsVisited(List<Tile> visited,Tile tile){
            return visited.FindAll(a => a.x==tile.x&&a.y==tile.y).Count>0;
        }

        public Tile[] FindPath(){
            List<Tile> visited=new List<Tile>();

            visited.Add(new Tile(startX,startY));
            for(int i=0;i<visited.Count;i++){
                Tile current=visited[i];
                foreach(Tile tile in current.GetNeighbors(this)){
                  
                    if(!IsVisited(visited,tile)){
                  
                        if(IsEnd(tile)){
                            
                            return RetracePath(tile);
                        }
                        visited.Add(tile);
                    }
                }
           
                
            }

            return null;

        }

        public bool IsValid(int x,int y){
            if(x<0||y<0||x>=this.width||y>=this.height){
                return false;
            }

            return wallLocations.Find(wall => wall.x==x&&wall.y==y)==null;
        }
    }
}