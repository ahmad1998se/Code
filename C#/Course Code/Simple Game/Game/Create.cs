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
    public partial class Create : Form
    {
        public int N_Of_profiles = 0;
        public Create()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Create_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportingToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            History s = new History();
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

        private void button1_Click(object sender, EventArgs e)
        {
            // N_Of_profiles++;

            StreamWriter file = new StreamWriter("D:\\PlayerData/" + this.C_Name.Text + ".txt");
            if (radioButton4.Checked == true)
                file.Write(this.C_Name.Text + "#" + this.C_Age.SelectedItem + "#" + this.C_Gender.SelectedItem + "#" + "C:\\Users/Ahmad/Desktop/NEW NEW/image (1).png");
            if (radioButton3.Checked == true)
                file.Write(this.C_Name.Text + "#" + this.C_Age.SelectedItem + "#" + this.C_Gender.SelectedItem + "#" + "C:\\Users/Ahmad/Desktop/NEW NEW/image (2).png");
            if (radioButton5.Checked == true)
                file.Write(this.C_Name.Text + "#" + this.C_Age.SelectedItem + "#" + this.C_Gender.SelectedItem + "#" + "C:\\Users/Ahmad/Desktop/NEW NEW/image (3).png");
            if (radioButton6.Checked == true)
                file.Write(this.C_Name.Text + "#" + this.C_Age.SelectedItem + "#" + this.C_Gender.SelectedItem + "#" + "C:\\Users/Ahmad/Desktop/NEW NEW/image (4).png");
            file.Close();

        }
        public string username()
        {
            return C_Name.Text;

        }
        private void C_Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
