using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbyssOfFate.Commands {
    public class CommandInterpreter {
        Program prgm;
        public CommandInterpreter(Program prgm) {
            this.prgm = prgm;
        }

        public void InterpretCommand(string rawCommand) {
            string[] parsedCommand = rawCommand.Split(' ');
            switch (parsedCommand[0]) {
                case "save":
                    Console.WriteLine(Lang.GetLang("saveSave", prgm.save.language, prgm.lang));
                    prgm.sh.Serialize(prgm.save, Save.Save.defaultName);
                    break;
                case "clear":
                    Console.Clear();
                    break;
                case "look":
                    Console.WriteLine(this.prgm.save.currentMap.GetCoord(this.prgm.save.x, this.prgm.save.y));
                    break;
                //TODO: Implement more commands
                default:
                    prgm.oh.WriteError(Lang.GetLang("errorUnrecCommand", prgm.save.language, prgm.lang) + parsedCommand[0]);
                    break;
            }
        }
    }
}
