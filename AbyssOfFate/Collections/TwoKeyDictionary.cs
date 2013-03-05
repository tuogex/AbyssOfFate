using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssOfFate.Collections {
    public class TwoKeyDictionary<K1, K2, T> :
        Dictionary<K1, Dictionary<K2, T>> { }
}
