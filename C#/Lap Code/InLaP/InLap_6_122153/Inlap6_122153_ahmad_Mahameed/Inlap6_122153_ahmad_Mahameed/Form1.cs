using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlap6_122153_ahmad_Mahameed
{
    public partial class Form1 : Form
    {
        Graphics G;
        Pen P = new Pen(Color.Red, 7);
        SolidBrush B = new SolidBrush(Color.Yellow);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            G = panel1.CreateGraphics();

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (e.Button == MouseButtons.Left)
            {

                if (radioButton1.Checked == true)
                {
                    //+++++
                    G.DrawLine(P, x + 40, y + 75, x + 40, y + 200);
                   G.DrawLine(P, x, y + 140, x + 80, y + 140);
                }
                else if (radioButton2.Checked == true)
                {
                    G.DrawLine(P, x, y + 140, x + 80, y + 140);
                }
                else if (radioButton3.Checked == true)
                {
                    G.DrawLine(P, x, y, x + 50, y + 100);
                    G.DrawLine(P, x + 50, y, x, y + 100);
                }
                else if (radioButton4.Checked == true)
                {
                    //dev
                    G.DrawLine(P, x, y + 140, x + 80, y + 140);
                    G.DrawLine(P, x + 40, y + 120, x + 42, y + 120);
                    G.DrawLine(P, x + 40, y + 160, x + 42, y + 160);
                }


            }
            else if (e.Button == MouseButtons.Right)
            {
                //Point[] POLYGON = new Point[]
                //   {
                //    new Point(x,y),
                //    new Point(x+40,y-40),
                //    new Point(x+80,y),
                //   new Point(x,y),


                //   };

                // G.DrawLines(P, POLYGON);               
                // G.FillPolygon(B, POLYGON);

                // G.FillRectangle(B, x + 10, y + 15, 20, 20);

                // G.FillRectangle(B, x + 50, y + 15, 20, 20);

                G.DrawLine(P, x, y, x + 50, y + 100);
                G.DrawLine(P, x + 50, y, x, y + 100);
                G.DrawLine(P, x, y, x + 0, y + 100);
                G.DrawLine(P, x + 50, y, x + 50, y + 100);
                G.DrawLine(P, x + 0, y + 50, x + 50, y + 50);
                //G.DrawLine(P,);
                //G.DrawLine(P,);
                //G.DrawLine(P,);
                //G.FillRectangle(B, x + 35, y + 60, 20, 40);

                //G.DrawEllipse(P, x, y, 80, 80);
                //G.DrawLine(P, x+40, y+80, x+40,y+200);
                //G.DrawLine(P, x , y +140, x +80, y +140);
                //G.DrawLine(P, x + 40, y + 200, x , y + 240);
                //G.DrawLine(P, x + 40, y + 200, x + 80, y + 240);


            }
        }
    }
}
