using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using AbyssOfFate.Maps;

namespace AbyssOfFate.Save {
    public class SerialHelper {
        Program prgm;
        public SerialHelper(Program prgm) {
            this.prgm = prgm;
        }

        public void Serialize(Save save, string fileName) {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try {
                formatter.Serialize(fs, save);
            }
            catch (SerializationException e) {
                prgm.oh.WriteError(Lang.GetLang("errorSaveSave", prgm.save.language, prgm.lang) + e.Message);
            }
            finally {
                fs.Close();
            }
        }

        public static void SerializeMap(Map save, string fileName) {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try {
                formatter.Serialize(fs, save);
            }
            catch (SerializationException e) {
                
            }
            finally {
                fs.Close();
            }
        }

        public Save Deserialize(string fileName) {
            Save save = new Save();
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try {
                BinaryFormatter formatter = new BinaryFormatter();
                save = (Save)formatter.Deserialize(fs);
            }
            catch (SerializationException e) {
                prgm.oh.WriteError(Lang.GetLang("errorReadSave", prgm.save.language, prgm.lang) + e);
            }
            finally {
                fs.Close();
            }
            return save;
        }

        public static Map DeserializeMap(string fileName) {
            Map save;
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try {
                BinaryFormatter formatter = new BinaryFormatter();
                save = (Map)formatter.Deserialize(fs);
            }
            catch (SerializationException e) {
                throw;
            }
            finally {
                fs.Close();
            }
            return save;
        }

        public static bool SaveExist(string fileName) {
            return File.Exists(fileName);
        }
    }
}
