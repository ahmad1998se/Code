using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
    }
}
