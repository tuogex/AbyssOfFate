using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssOfFate.Maps {
    public class Direction {
        enum Directions {NORTH=0,EAST=1,SOUTH=2,WEST=3};
        public int dir = 0;
        public Direction(int dir) {
            this.dir = dir;
        }
    }
}
