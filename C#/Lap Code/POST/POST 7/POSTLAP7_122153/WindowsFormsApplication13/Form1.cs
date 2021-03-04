using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication13
{
    //  var copy button copy = x1 
    public partial class Form1 : Form
    {
        int copyx1, copyy1, copyx2, copyy2;
        Pen P = new Pen(Color.Red, 3);
        Graphics G;
        List<shape> Mylist = new List<shape>();
        int x1, y1, x2, y2;
        int Index;
        bool flag = false;

        public Form1()
        {
            InitializeComponent();
            G = this.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            for (int i = 0; i < Mylist.Count; i++)
            {
                if (Mylist[i].IsInside(e.X, e.Y))
                {
                    copyx1 = Mylist[i].X1 ;
                    copyy1 = Mylist[i].Y1 ;
                    copyx2 = Mylist[i].X2 ;
                    copyy2 = Mylist[i].Y2 ;
                    Mylist[i].Select(G);
                    Index = i;
                    flag = true;
                }
            }

        }
        shape Myshape;

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TEXT FILE|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);

                write.WriteLine("x1 \t y1 \t x2 \t y2");
                foreach (var shape in Mylist)
                {
                    write.WriteLine(shape.ToString());
                }


                write.Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Myshape = new shape(copyx1, copyy1, copyx2, copyy2, shType.rect);
            Myshape.DRAW(G, P);
            Mylist.Add(Myshape);
        }

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
                    Myshape = new shape(x1, y1, x2, y2, shType.rect);
                Myshape.DRAW(G, P);
                Mylist.Add(Myshape);
            }

        }
        public void REDRAW()
        {
            G.Clear(Color.White);
            foreach (shape Item in Mylist)
                Item.DRAW(G, P);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            REDRAW();

        }
    }
}
