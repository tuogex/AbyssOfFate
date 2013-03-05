using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbyssOfFate.Maps;
using System.IO;
using AbyssOfFate.Save;

namespace AbyssOfFateMapBuilder {
    public partial class MapForm : Form {

        public Map map;
        public string fileName;

        public MapForm(Map mapFile, string fileName) {
            InitializeComponent();
            fileName = fileName.Replace(".afm", "");
            fileName = fileName.Replace(Application.StartupPath + "\\", "");
            map = new Map(fileName);
            this.fileName = fileName;
            this.Text = "Map - " + this.fileName;
            this.fileToolStripMenuItem.Text = this.Text;
        }

        private void MapForm_Load(object sender, EventArgs e) {
            CreateGrid();
        }

        private void CreateGrid() {
            Bitmap Bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int h = 0; h < (pictureBox1.Width / 10.0); h++) {
                for (int i = 0; i < pictureBox1.Height; i++) {
                    Bmp.SetPixel(h * 10, i, Color.FromArgb(0, 0, 0));
                }
            }
            for (int h = 0; h < (pictureBox1.Height / 10.0); h++) {
                for (int i = 0; i < pictureBox1.Width; i++) {
                    Bmp.SetPixel(i, h * 10, Color.FromArgb(0, 0, 0));
                }
            }
            pictureBox1.Image = Bmp;
        }

        private void DrawColorAtCoord(int x, int y, int r, int g, int b) {
            y--;
            x--;
            Bitmap Bmp = (Bitmap)pictureBox1.Image;
            for (int i = 0; i < Bmp.Height; i++) {
                for (int j = 0; j < Bmp.Width; j++) {
                    if (i > x * 10 && j > y * 10 && i < (x + 1) * 10 && j < (y + 1) * 10) {
                        Bmp.SetPixel(j, i, Color.FromArgb(r, g, b));
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            
        }

        private void MapForm_FormClosing(object sender, FormClosingEventArgs e) {
            //mapFile.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            SerialHelper.SerializeMap(this.map, this.fileName + ".afm");
        }

        private void xBox_TextChanged(object sender, EventArgs e) {

        }

        private void xBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void GridDrawTimer_Tick(object sender, EventArgs e) {
            //Draw cycle 1/second
            this.UpdateGrid();
        }

        private void UpdateGrid() {
            this.CreateGrid();
        }
    }
}
