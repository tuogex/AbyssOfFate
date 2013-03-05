using System;
using System.Collections.Generic;
using System.Text;

namespace AbyssOfFate {
    public class Lang {
        public Dictionary<string, string> enUS = new Dictionary<string, string>();

        public Lang() {
            //Initializing enUS
            enUS.Add("initMain", "Initializing Main Instance...");
            enUS.Add("initLang", "Initializing Languages...");
            enUS.Add("initCommandIntpr", "Initializing Command Interpreter...");
            enUS.Add("initReader", "Initializing Input Reader...");
            enUS.Add("initOutputHelper", "Initializing Output Helper...");
            enUS.Add("initSerialHelper", "Initializing Serialization Helper...");

            enUS.Add("saveNew", "Creating new save...");
            enUS.Add("saveSave", "Saving current save...");
            enUS.Add("saveRead", "Reading current save...");

            enUS.Add("errorUnrecCommand", "Unrecognized Command: ");
            enUS.Add("errorSaveSave", "Error saving save: ");
            enUS.Add("errorReadSave", "Error reading save: ");

            enUS.Add("gameTitle", "Abyss of Fate");
            //TODO: Implement rest of langs
        }

        public static string GetLang(string key, string langStr, Lang lang) {
            if (lang == null) {
                return key;
            }
            switch (langStr) {
                case "enUS":
                    if (lang.enUS.ContainsKey(key))
                        return lang.enUS[key];
                    else
                        return key;
                //TODO: Implement more translations
                default:
                    return key;
            }
        }

        public static void PrintLogo() {
            Console.WriteLine("              _____                               ________)        ");
            Console.WriteLine("             (, /  |   /)                   /)   (, /              ");
            Console.WriteLine("               /---|  (/_     _   _     ___//      /___, _  _/_  _ ");
            Console.WriteLine("            ) /    |_/_) (_/_/_)_/_)_  (_)/(_   ) /     (_(_(___(/_");
            Console.WriteLine("           (_/          .-/              /)    (_/                 ");
            Console.WriteLine("                       (_/              (/                         ");
            Console.WriteLine("                                Anthony Ma 2013");
        }
    }
}
