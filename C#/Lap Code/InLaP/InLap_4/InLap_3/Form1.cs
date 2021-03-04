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

namespace InLap_3
{
    public partial class Form1 : Form
    {
        string Alltext;
        string[] Lines;
        string[] np;
        
         
        List<Complex> obj = new List<Complex>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog Dlg = new OpenFileDialog();
            Dlg.Filter = "TEXT FILE|*.txt";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Infile = new StreamReader(Dlg.FileName);
                Alltext = Infile.ReadToEnd();
                Infile.Close();
                textBox1.Text = Dlg.FileName;
                Lines = Alltext.Split(new char[] {',', ' ', ',', '\n', '\r' },
               StringSplitOptions.RemoveEmptyEntries);

            }
            foreach (var item in Lines)
            {

                double one ,  two;

                string[] par = item.Split(new char[] { '+', '-' }) ;

                if (par[0].Contains("-"))
                {
                    one = double.Parse( par[0] )*-1;

                }
                else
                {
                    one = double.Parse(par[0]);
                }
                if (par[1].Contains("-"))
                {
                    two = double.Parse(par[0]) * -1;

                }
                else
                {
                    two = double.Parse(par[0]);
                }



            }






        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog Dlg = new SaveFileDialog();
            Dlg.Filter = "TEXT FILE|*.txt";
            if (Dlg.ShowDialog() == DialogResult.OK)
            {
                
                
                    StreamWriter Outfile = new StreamWriter(Dlg.FileName);
                    Outfile.WriteLine("Number Of Lines : " + textBox2.Text);
                    Outfile.WriteLine("Number Of Letters : " + textBox3.Text);
                    Outfile.WriteLine("Number Of Pun : " + textBox4.Text);
                    Outfile.Close();
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
