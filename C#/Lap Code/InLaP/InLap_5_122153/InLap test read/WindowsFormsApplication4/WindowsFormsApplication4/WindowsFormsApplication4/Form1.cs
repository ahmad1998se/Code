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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        string Alltext;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "TEXT FILE|*.txt|XMLFILE|*.xml";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                if (Dlg.FilterIndex == 1)
                {
                    StreamReader Infile = new StreamReader(Dlg.FileName);
                    Alltext = Infile.ReadToEnd();
                    Infile.Close();
                    textBox1.Text = Alltext;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Lines = Alltext.Split(new char[]{'\n','\r'},
                StringSplitOptions.RemoveEmptyEntries);
            textBox2.Text = Lines.Length.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Letter_Counter = 0;
            int Pun_Counter = 0;
            for (int i = 0; i < Alltext.Length; i++)
            {
                if (char.IsLetter(Alltext[i]))
                    Letter_Counter++;
                if (char.IsPunctuation(Alltext[i]))
                    Pun_Counter++;

            }
            textBox3.Text = Letter_Counter.ToString();
            textBox4.Text = Pun_Counter.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dlg = new SaveFileDialog();
            Dlg.Filter = "XMLFILE|*.xml|TEXT FILE|*.txt";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                if (Dlg.FilterIndex == 2)
                {
                    StreamWriter Outfile = new StreamWriter(Dlg.FileName);
                    Outfile.WriteLine("Number Of Lines : " + textBox2.Text);
                    Outfile.WriteLine("Number Of Letters : " + textBox3.Text);
                    Outfile.WriteLine("Number Of Pun : " + textBox4.Text);
                    Outfile.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
