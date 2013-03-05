using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssOfFate.Save {
    [Serializable]
    public class Inventory {
        private List<int> items = new List<int>();
        public Inventory() {

        }

        public bool Contains(int id) {
            return this.items.Contains(id);
        }

        public bool Remove(int id) {
            if (this.items.Contains(id)) {
                this.items.Remove(id);
                return true;
            }
            else {
                return false;
            }
        }

        public void Add(int id) {
            this.items.Add(id);
        }
    }
}
