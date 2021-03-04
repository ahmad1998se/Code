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
    public partial class SizeForm : Form
    {
        public static float w;
        public static float h;
        public static float x;
        public static float y;
        public SizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                w = float.Parse(textBox1.Text);
                h = float.Parse(textBox1.Text);
                x = float.Parse(textBox3.Text);
                y = float.Parse(textBox4.Text);
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SizeForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "10";
            textBox2.Text = "20";
            textBox3.Text = "10";
            textBox4.Text = "20";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
