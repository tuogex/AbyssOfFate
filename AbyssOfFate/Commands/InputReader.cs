using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssOfFate.Commands {
    public class InputReader {
        CommandInterpreter ci;
        public InputReader(CommandInterpreter ci) {
            this.ci = ci;
        }

        public void StartReadLoop() {
            while (true) {
                Console.Write("> ");
                string input = Console.ReadLine();
                ci.InterpretCommand(input);
            }
        }
    }
}
