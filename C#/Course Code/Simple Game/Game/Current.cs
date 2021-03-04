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

namespace Game
{
    public partial class Current : Form 
    {


        string PlayerPath="";


        public Current()
        {
            InitializeComponent();
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Current_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ahmad 8 FeMale C:\Users/Ahmad/Desktop/NEW NEW/image (4).png
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                PlayerPath = openFileDialog1.FileName;

            StreamReader openfile = new StreamReader(PlayerPath);
            string line = openfile.ReadLine();
            string[] data = line.Split('#');
            textBox1.Text = data[0];
            C_AGE.Text = data[1];
            C_GENDER.Text = data[2];
            if (data[3] == "C:\\Users/Ahmad/Desktop/NEW NEW/image (1).png")
                radioButton4.BackColor = Color.AliceBlue;
            if (data[3] == "C:\\Users/Ahmad/Desktop/NEW NEW/image (2).png")
                radioButton3.BackColor = Color.AliceBlue;
            if (data[3] == "C:\\Users/Ahmad/Desktop/NEW NEW /image (3).png")
                radioButton5.BackColor = Color.AliceBlue;
            if (data[3] == "C:\\Users/Ahmad/Desktop/NEW NEW/image (4).png")
                radioButton6.BackColor = Color.AliceBlue;





        }
    }
}
