using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbyssOfFate.Collections;

namespace AbyssOfFate.Maps {
    [Serializable]
    public class Map {
        private TwoKeyDictionary<int, int, MapType> map = new TwoKeyDictionary<int, int, MapType>();
        public string name = "leedle";
        public Map(string name) {
            this.name = name;
        }

        public MapType GetCoord(int x, int y) {
            return map[x][y];
        }
    }
}
