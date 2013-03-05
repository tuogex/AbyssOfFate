using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssOfFate.Output {
    public class OutputHelper {
        Program prgm;
        public OutputHelper(Program prgm) {
            this.prgm = prgm;
        }

        public void WriteError(string errorStr, bool writeLine) {
            ConsoleColor oldForeColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            if (writeLine) {
                Console.WriteLine(errorStr);
            }
            else {
                Console.Write(errorStr);
            }
            Console.ForegroundColor = oldForeColor;
        }

        public void WriteError(string errorStr) {
            WriteError(errorStr, true);
        }
    }
}
