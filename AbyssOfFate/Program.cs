using System;
using System.Collections.Generic;
using System.Text;
using AbyssOfFate.Output;
using AbyssOfFate.Commands;
using AbyssOfFate.Save;

namespace AbyssOfFate {
    public class Program {
        public Lang lang;
        public CommandInterpreter ci;
        public InputReader ir;
        public OutputHelper oh;
        public SerialHelper sh;
        public Save.Save save;
        public static string defaultLang = "enUS";
        public static string version = "0.1b24";
        public static bool debug = true;
        static void Main(string[] args) {
            Program prgm = new Program();
            if (debug)
                Console.WriteLine(Lang.GetLang("initLang", Program.defaultLang, prgm.lang));
            prgm.lang = new Lang();
            Console.Title = Lang.GetLang("gameTitle", Program.defaultLang, prgm.lang);
            if (debug)
                Console.WriteLine(Lang.GetLang("initCommandIntpr", Program.defaultLang, prgm.lang));
            prgm.ci = new CommandInterpreter(prgm);
            if (debug)
                Console.WriteLine(Lang.GetLang("initReader", Program.defaultLang, prgm.lang));
            prgm.ir = new InputReader(prgm.ci);
            if (debug)
                Console.WriteLine(Lang.GetLang("initOutputHelper", Program.defaultLang, prgm.lang));
            prgm.oh = new OutputHelper(prgm);
            if (debug)
                Console.WriteLine(Lang.GetLang("initSerialHelper", Program.defaultLang, prgm.lang));
            prgm.sh = new SerialHelper(prgm);
            if (SerialHelper.SaveExist("save.dat")) {
                Console.WriteLine(Lang.GetLang("saveRead", Program.defaultLang, prgm.lang));
                prgm.save = prgm.sh.Deserialize(Save.Save.defaultName);
            }
            else {
                Console.WriteLine(Lang.GetLang("saveNew", Program.defaultLang, prgm.lang));
                prgm.save = new Save.Save();
            }
            Lang.PrintLogo();
            prgm.ir.StartReadLoop();
        }
    }
}
