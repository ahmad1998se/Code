using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostLap_6_122153
{
    public partial class Form1 : Form
    {
        PictureBox pic=new PictureBox();   
        bool pp = true;
        bool bb = false;
        Graphics g;
        int x;
        int y;
        bool move = false;
        Pen pen;
        SolidBrush brush;
        
        public Form1()
        {
            
            InitializeComponent();
            g = panel1.CreateGraphics();            
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen = new Pen(Color.Black, 5);
            //make pen line better
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            brush = new SolidBrush(Color.Black);
            pic.BackColor = Color.Black;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
             pp = true;
             bb = false;
            // pic = (PictureBox)sender;
           pen.Color = pic.BackColor;
           brush.Color = pic.BackColor;
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pen= new Pen(pen.Color, comboBox1.SelectedIndex);
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
            brush.Color = pic.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move && x != -1 && y != -1 && pp)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;

            }

            else if (move && x != -1 && y != -1 && bb)
            {

                g.FillEllipse(brush, e.X, e.Y, comboBox1.SelectedIndex*2, comboBox1.SelectedIndex*2);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            x = -1;
            y = -1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            
            pen.Color = colorDialog1.Color;
            brush.Color = colorDialog1.Color;
            pic.BackColor = colorDialog1.Color;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            brush.Color= Color.White; 
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pp = false;
            bb = true;
           // pic = (PictureBox)sender;
            pen.Color = pic.BackColor;
            brush.Color = pic.BackColor;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SizeForm size = new SizeForm();
            size.ShowDialog();
            
            if ( pp)
            {
                g.DrawRectangle(pen, SizeForm.x, SizeForm.y, SizeForm.w, SizeForm.h);
               

            }

            else if ( bb)
            {

                g.FillRectangle(brush, SizeForm.x, SizeForm.y, SizeForm.w, SizeForm.h);
            }


        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pp = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
