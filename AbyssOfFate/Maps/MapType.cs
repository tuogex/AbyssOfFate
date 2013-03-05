using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssOfFate.Maps {
    public class MapType {
        public bool walkable = false;
        public bool chestExists = false;
        public int chestId = 0;
        public bool enemyExists = false;
        public int enemyId = 0;
        public string chestName = "";
        public string enterMessage = "";
        public string blockedMessage = "";
        public string chestSearchedMessage = "";
        public bool chestKey = false;
        public int chestKeyId = 0;
        public Dictionary<Direction, string> look = new Dictionary<Direction, string>();

        public MapType(bool walkable, bool chestExists, int chestId, bool enemyExists, int enemyId) {
            Init(walkable, chestExists, chestId, enemyExists, enemyId);
        }

        public MapType(bool walkable, bool chestExists, int chestId) {
            Init(walkable, chestExists, chestId, false, 0);
        }

        public MapType(bool walkable) {
            Init(walkable, false, 0, false, 0);
        }

        private void Init(bool walkable, bool chestExists, int chestId, bool enemyExists, int enemyId) {
            this.walkable = walkable;
            this.chestExists = chestExists;
            this.chestId = chestId;
            this.enemyExists = enemyExists;
            this.enemyId = enemyId;
        }
    }
}
