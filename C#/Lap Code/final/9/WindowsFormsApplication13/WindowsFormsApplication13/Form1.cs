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
using System.Xml.Serialization;

namespace WindowsFormsApplication13
{
    
    public partial class Form1 : Form
    {
        shape obj;
        string []text;
        string line;
        List<shape> menu = new List<shape>();
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
                    Mylist[i].Select(G);
                    Index = i;
                    flag = true;
                }
            }

        }
        shape Myshape;

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "XMLFILE|*.xml|TEXTFILE|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FilterIndex == 1)
                {
                    StreamReader infile = new StreamReader(dlg.FileName);
                    XmlSerializer DES = new XmlSerializer(typeof(List<shape>));
                    Mylist.AddRange( (List<shape>)DES.Deserialize(infile));
                }
                //dataGridView1.DataSource = menu;}
                else if (dlg.FilterIndex == 2)
                {
                    StreamReader read = new StreamReader(dlg.FileName);
                    string header = read.ReadLine();
                    string line;

                    while (!read.EndOfStream)
                    {
                        line = read.ReadLine();
                        text = line.Split(new char[] { '\t','(',',',')' }, StringSplitOptions.RemoveEmptyEntries);
                        int x1 = int.Parse(text[0]);
                        int y1 = int.Parse(text[1]);
                        int x2 = int.Parse(text[2]);
                        int y2 = int.Parse(text[3]);
                        if (text[5] == "rect")
                        {
                            obj = new shape(x1, y1, x2, y2,shType.rect); }

                        else if (text[5] == "ellipse")
                        {
                             obj = new shape(x1, y1, x2, y2, shType.ellipse);
                        }
                        Mylist.Add(obj);
                    }



                    read.Close();
                    }
                   
           
                    

                }
            REDRAW();

            }
        

        private void button2_Click(object sender, EventArgs e)
        {

           
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XMLFILE|*.xml|TEXTFILE|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FilterIndex == 1)
                {
                    StreamWriter outfile = new StreamWriter(dlg.FileName);
                    XmlSerializer SER = new XmlSerializer(typeof(List<shape>));
                    SER.Serialize(outfile, Mylist);
                   // SER.Serialize(outfile, menu);
                    outfile.Close();
                }
                else if (dlg.FilterIndex == 2)
                {
                   
                  
                        StreamWriter write = new StreamWriter(dlg.FileName);
                        write.WriteLine("TopLeft			LowerRight	shapetype");
                        foreach (shape item in Mylist)
                        {
                            write.WriteLine(item.ToString());

                        }
                    //foreach (shape item in menu)
                    //{
                    //    write.WriteLine(item.ToString());

                    //}
                    write.Close();

                    


                }


            }
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
                    Myshape = new shape(x1, y1, x2, y2, shType.ellipse);
                Myshape.DRAW(G, P);
                Mylist.Add(Myshape);
            }

        }
        public void REDRAW()
        {
            G.Clear(Color.White);
            foreach (shape Item in Mylist)
                Item.DRAW(G, P);
            //foreach (shape Item in menu)
            //    Item.DRAW(G, P);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            REDRAW();

        }
    }
}
