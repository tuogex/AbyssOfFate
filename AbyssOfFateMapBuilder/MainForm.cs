using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbyssOfFate.Save;
using AbyssOfFate.Maps;

namespace AbyssOfFateMapBuilder {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            FileStream stream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Abyss Of Fate Map Files (*.afm)|*.afm";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                if ((stream = (FileStream)saveFileDialog1.OpenFile()) != null) {
                    MapForm mf = new MapForm(null, stream.Name);
                    mf.MdiParent = this;
                    mf.Show();
                    stream.Close();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Abyss Of Fate Map Files (*.afm)|*.afm";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog1.FileName;
                fileName = fileName.Replace(Application.StartupPath + "\\", "");
                Map openMap = (Map)SerialHelper.DeserializeMap(fileName);
            }
        }

        /*private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (this.ActiveMdiChild is MapForm) {
                MapForm activeMapForm = (MapForm)this.ActiveMdiChild;
                SerialHelper.Serialize(activeMapForm.map, activeMapForm.fileName + ".afm");
            }
        }*/
    }
}
