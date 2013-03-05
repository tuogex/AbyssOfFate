using AbyssOfFate.Maps;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssOfFate.Save {
    [Serializable]
    public class Save {
        public string name = "missingno";
        public string language = "enUS";
        public int turns = 0;
        public int inventorySize = 4;
        public Inventory inventory = new Inventory();
        public Map currentMap;
        public int x = 0;
        public int y = 0;
        //TODO: Implement rest of savable variables
        
        [NonSerialized]
        public static string defaultName = "save.dat";
        public Save() {

        }

        public void SetMap(Map map) {
            this.currentMap = map;
        }

        public void SetName(string name) {
            this.name = name;
        }

        public void SetInventorySize(int size) {
            this.inventorySize = size;
        }

        public Inventory GetInventory() {
            return this.inventory;
        }
    }
}
