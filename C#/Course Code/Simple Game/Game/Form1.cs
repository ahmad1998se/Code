using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game
{

    public partial class Form1 : Form 
    {
        //int[] R = new int[12];
        // int Counter = 0;
        //Dictionary<string, Button> map;
        
        int FIRSTROWNUMBER = 0;
        int FIRSTCOLUMNUMBER = 0;
        int LASTROWNUMBER;
        int LASTCOLUMNUMBER;
        int move = 0;
        int Smove = 0;
        int win = 0;
        int sec = 1;
        string PlayerPath="";

        Random ro = new Random();
        PictureBox[] block = new PictureBox[7];
        Button Player = new Button();
        public Form1()
        {
            InitializeComponent();
            LASTCOLUMNUMBER = tableLayoutPanel1.ColumnCount;
            LASTROWNUMBER = tableLayoutPanel1.RowCount;
            tableLayoutPanel1.Focus();
            /* foreach (PictureBox t in block)
             {


             }*/
            block[0] = pictureBlock1;
            block[1] = pictureBlock2;
            block[2] = pictureBlock3;
            block[3] = pictureBlock4;
            block[4] = pictureBlock5;
            block[5] = pictureBlock6;
            block[6] = pictureBlock7;
            int temp = ro.Next(0, 8);

            for (int i = 0; i < 7; i++)
            {
                if (temp < (7 - i))
                {
                    tableLayoutPanel1.Controls.Add((block[i]));
                    tableLayoutPanel1.SetCellPosition(block[i], new TableLayoutPanelCellPosition(nextOodNumber(), nextOodNumber()));
                    block[i].Show();
                    block[i].Visible = true;

                }
                else
                    block[i].Visible = false;

            }

        }

        int nextOodNumber()
        {
            /*int x = ro.Next(0, 11);
            for (int i = 0; i < x; i++)
                if ((x % 2) != 0)
                return x;
            nextOodNumber();
            return 0;*/
            int x = ro.Next(0, 11);
            if ((x % 2) != 0)
                return x;
            nextOodNumber();

            return 0;
        }



        public void MoveUp()
        {
            TableLayoutPanelCellPosition g = tableLayoutPanel1.GetCellPosition(pictureBox7);

            TableLayoutPanelCellPosition newUpPoint = nextUpPoint(g);
            if (tableLayoutPanel1.GetControlFromPosition(newUpPoint.Column, newUpPoint.Row) == null)
            {
                tableLayoutPanel1.SetCellPosition(pictureBox7, nextUpPoint(g));
                Smove++;
                textBox4.Text = "" + Smove + "";
            }
            else
            {
                if (tableLayoutPanel1.GetControlFromPosition(newUpPoint.Column, newUpPoint.Row) == pictureBox6)
                { MessageBox.Show("HELLO");
                win++;
                textBox2.Text = "Win :" + win + "";
            }

            }
            move++;
            textBox3.Text = "" + move + "";
        }
        public void MoveDown()
        {
            TableLayoutPanelCellPosition g = tableLayoutPanel1.GetCellPosition(pictureBox7);

            TableLayoutPanelCellPosition newDownPoint = nextDownPoint(g);
            if (tableLayoutPanel1.GetControlFromPosition(newDownPoint.Column, newDownPoint.Row) == null)
            {
                tableLayoutPanel1.SetCellPosition(pictureBox7, nextDownPoint(g));
                Smove++;
                textBox4.Text = "" + Smove + "";
            }
            else
            {
                if (tableLayoutPanel1.GetControlFromPosition(newDownPoint.Column, newDownPoint.Row) == pictureBox6)
                { MessageBox.Show("HELLO");
                win++;
                textBox2.Text = "Win :" + win + "";
            }
            }
            move++;
            textBox3.Text = "" + move + "";
        }
        public void MoveLeft()
        {
            TableLayoutPanelCellPosition g = tableLayoutPanel1.GetCellPosition(pictureBox7);

            TableLayoutPanelCellPosition newLeftPoint = nextLeftPoint(g);
            if (tableLayoutPanel1.GetControlFromPosition(newLeftPoint.Column, newLeftPoint.Row) == null)
            {
                tableLayoutPanel1.SetCellPosition(pictureBox7, nextLeftPoint(g));
                Smove++;
                textBox4.Text = "" + Smove + "";
            }
            else
            {
                if (tableLayoutPanel1.GetControlFromPosition(newLeftPoint.Column, newLeftPoint.Row) == pictureBox6)
                { MessageBox.Show("HELLO");
                win++;
                textBox2.Text = "Win :" + win + "";
            }
            }
            move++;
            textBox3.Text = "" + move + "";
        }
        public void MoveRight()
        {
            TableLayoutPanelCellPosition g = tableLayoutPanel1.GetCellPosition(pictureBox7);

            TableLayoutPanelCellPosition newRightPoint = nextRightPoint(g);
            if (tableLayoutPanel1.GetControlFromPosition(newRightPoint.Column, newRightPoint.Row) == null)
            {
                tableLayoutPanel1.SetCellPosition(pictureBox7, nextRightPoint(g));
                Smove++;
                textBox4.Text = "" + Smove + "";
            }
            else
            {
                if (tableLayoutPanel1.GetControlFromPosition(newRightPoint.Column, newRightPoint.Row) == pictureBox6)
                { MessageBox.Show("HELLO");
                win++;
                textBox2.Text = "Win :" + win + "";
            }
            }
            move++;
            textBox3.Text = "" + move + "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MoveDown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Focus();
            // this.Focus();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics s = new Statistics();
            s.ShowDialog();
            this.Close();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            History s = new History();
            s.ShowDialog();
            this.Close();
        }

        private void currentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Current s = new Current();
            s.ShowDialog();
            this.Close();
        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create s = new Create();
            s.ShowDialog();
            this.Close();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.ShowDialog();
            this.Close();
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Trace.WriteLine("***********************************");
        }

        //////////////////////////////////////////////////////////////////////////////
        private TableLayoutPanelCellPosition nextRightPoint(TableLayoutPanelCellPosition Current)
        {

            if ((Current.Column + 1) == LASTCOLUMNUMBER)
            {
                Current.Column = FIRSTCOLUMNUMBER;
            }
            else
                Current.Column = Current.Column + 2;
            Current.Row = Current.Row;
            return Current;

        }
        private TableLayoutPanelCellPosition nextUpPoint(TableLayoutPanelCellPosition Current)
        {
            TableLayoutPanelCellPosition g2 = new TableLayoutPanelCellPosition();
            if (Current.Row == 0)
            {
                Current.Row = LASTROWNUMBER - 1;
            }
            else
                Current.Row = Current.Row - 2;
            g2.Column = Current.Column;
            return Current;

        }
        private TableLayoutPanelCellPosition nextDownPoint(TableLayoutPanelCellPosition Current)
        {
            if ((Current.Row + 1) == LASTROWNUMBER)
            {
                Current.Row = FIRSTROWNUMBER;
            }
            else
                Current.Row = Current.Row + 2;
            Current.Column = Current.Column;
            return Current;
        }

        private TableLayoutPanelCellPosition nextLeftPoint(TableLayoutPanelCellPosition Current)
        {
            if (Current.Column == FIRSTROWNUMBER)
            {
                Current.Column = LASTCOLUMNUMBER - 1;
            }
            else
                Current.Column = Current.Column - 2;
            Current.Row = Current.Row;
            return Current;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            // if (thegameStartFlag == false)
            // timer1.Start();
            TableLayoutPanelCellPosition g = tableLayoutPanel1.GetCellPosition(pictureBox7);
            switch (e.KeyCode)
            {
                case Keys.Up:
                    TableLayoutPanelCellPosition newUpPoint = nextUpPoint(g);
                    if (tableLayoutPanel1.GetControlFromPosition(newUpPoint.Column, newUpPoint.Row) == null)
                    {
                        


                        tableLayoutPanel1.SetCellPosition(pictureBox7, nextUpPoint(g))  ;
                        Smove++;
                        textBox4.Text = "" + Smove + "";
                    }
                    else
                    {
                        if (tableLayoutPanel1.GetControlFromPosition(newUpPoint.Column, newUpPoint.Row) == pictureBox6)
                        { MessageBox.Show("HELLO");
                        win++;
                        textBox2.Text = "Win :" + win + "";
                    }

                    }
                    move++;
                    textBox3.Text = "" + move + "";
                    break;
                case Keys.Down:
                    TableLayoutPanelCellPosition newDownPoint = nextDownPoint(g);
                    if (tableLayoutPanel1.GetControlFromPosition(newDownPoint.Column, newDownPoint.Row) == null)
                    {
                     
                        tableLayoutPanel1.SetCellPosition(pictureBox7, nextDownPoint(g));

                        Smove++;
                        textBox4.Text = "" + Smove + "";
                    }
                    else
                    {
                        if (tableLayoutPanel1.GetControlFromPosition(newDownPoint.Column, newDownPoint.Row) == pictureBox6)
                        {
                            MessageBox.Show("HELLO");
                        win++;
                        textBox2.Text = "Win :" + win + "";
                    }
                    }
                    move++;
                    textBox3.Text = "" + move + "";
                    break;
                case Keys.Left:
                    TableLayoutPanelCellPosition newLeftPoint = nextLeftPoint(g);
                    if (tableLayoutPanel1.GetControlFromPosition(newLeftPoint.Column, newLeftPoint.Row) == null)
                    {
                        tableLayoutPanel1.SetCellPosition(pictureBox7, nextLeftPoint(g));
                        Smove++;
                        textBox4.Text = "" + Smove + "";
                    }
                    else
                    {
                        if (tableLayoutPanel1.GetControlFromPosition(newLeftPoint.Column, newLeftPoint.Row) == pictureBox6)
                        { MessageBox.Show("HELLO");
                        win++;
                        textBox2.Text = "Win :" + win + "";
                    }

                    }
                    move++;
                    textBox3.Text = "" + move + "";
                    break;
                case Keys.Right:
                    TableLayoutPanelCellPosition newRightPoint = nextRightPoint(g);
                    if (tableLayoutPanel1.GetControlFromPosition(newRightPoint.Column, newRightPoint.Row) == null)
                    {
                        tableLayoutPanel1.SetCellPosition(pictureBox7, nextRightPoint(g));
                        Smove++;
                        textBox4.Text = "" + Smove + "";
                    }
                    else
                    {
                        if (tableLayoutPanel1.GetControlFromPosition(newRightPoint.Column, newRightPoint.Row) == pictureBox6)
                        { MessageBox.Show("HELLO");
                        win++;
                        textBox2.Text = "Win :" + win + "";
                    }
                    }
                    move++;
                    textBox3.Text = "" + move + "";
                    break;
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MoveUp();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MoveLeft();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MoveRight();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            textBox5.Text = "Time :" + sec + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string txt;
            Create c1 = new Create();
            StreamReader openfile = new StreamReader("D:\\PlayerData / "+c1.username()+".txt");
            txt = openfile.ReadLine();
            string[] im = txt.Split(' ');
            
            pictureBox7.Image = new Bitmap(@"C:\\Users/Ahmad/Desktop/NEW NEW/image (2).png");
            */
            timer1.Start();
            


        }
        
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void Select_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                PlayerPath = openFileDialog1.FileName;

            StreamReader openfile = new StreamReader(PlayerPath);
            string line = openfile.ReadLine();
            string[] data=line.Split('#');
            textBox1.Text = data[0];

        }
    }
}
