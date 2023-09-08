using System;
using System.Collections.Generic;

namespace Pathfinding {
    public class Wall {
        public readonly int x,y;
        public readonly int distance;


        public Wall(int x,int y,int distance=0){
            this.x=x;
            this.y=y;
            this.distance=distance;
        }

        public int DistanceTo(int x,int y)
        {
            float xDiff=this.x-x;
            float yDiff=this.y-y;   
            return (int) Math.Sqrt(xDiff*xDiff+yDiff*yDiff);
        }
  

    }
}