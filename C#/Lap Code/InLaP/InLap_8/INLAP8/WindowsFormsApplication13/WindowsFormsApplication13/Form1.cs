using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
        public partial class Form1 : Form
        {
        Pen P = new Pen(Color.Red, 3);
        Graphics G,G2;
        Bitmap Bimage,Bimage2;
        List<shape> Mylist = new List<shape>();
        int x1, y1, x2, y2;
        int Index;
        bool flag = false;
        public Form1()
        {
            InitializeComponent();
            G = this.CreateGraphics();
            Bimage = new Bitmap(this.Width,this.Height);
            Bimage2 = new Bitmap(this.Width, this.Height);
            G2 = Graphics.FromImage(Bimage);
            G2.Clear(Color.White);
        }
        private void Form1_Load(object sender, EventArgs e)
        {                  }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            for (int i = 0; i < Mylist.Count; i++)
            {
                if (Mylist[i].IsInside(e.X, e.Y))
                {
                    Mylist[i].Select(G);
                    Index = i;
                    flag = true;
                }
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPEGIMAGE|*.jpeg|PNGIMAGE|*.png|GIFIMAGE|*.gif";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                    Bimage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                else if (saveFileDialog1.FilterIndex == 2)
                    Bimage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                else if (saveFileDialog1.FilterIndex == 3)
                    Bimage.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif);
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {       }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                Bimage = new Bitmap(openFileDialog1.FileName);
                Bimage2 = new Bitmap(Bimage);
                G2 = Graphics.FromImage(Bimage);
                G.DrawImage(Bimage, 0, 0, Bimage.Width, Bimage.Height);
            }
        }
        shape Myshape;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            int dx = x2 - x1;
            int dy = y2 - y1;
            if (flag)
            {
                Mylist[Index].Move(dx, dy);
                REDRAW();
                flag = false;
            }
            else
                {
                if (e.Button == MouseButtons.Left)
                    Myshape = new shape(x1, y1, x2, y2, shType.rect);
                else if (e.Button == MouseButtons.Right)
                    Myshape = new shape(x1, y1, x2, y2, shType.ellipse);
                Myshape.DRAW(G, P);
                Myshape.DRAW(G2, P);
                Mylist.Add(Myshape);
                 }

        }
        public void REDRAW()
        {
            G.Clear(Color.White);
            G2.Clear(Color.White);
            G.DrawImage(Bimage2,0,0,Bimage2.Width,Bimage2.Height);
            G2.DrawImage(Bimage2, 0, 0, Bimage2.Width, Bimage2.Height);
            foreach (shape Item in Mylist)
            {
                Item.DRAW(G, P);
                Item.DRAW(G2, P);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            REDRAW();
        }
    }
}
