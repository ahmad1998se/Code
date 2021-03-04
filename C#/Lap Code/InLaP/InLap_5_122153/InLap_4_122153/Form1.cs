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

namespace InLap_4_122153
{
    public partial class Form1 : Form
    {
        string[] text;
        List<Complex> MyList = new List<Complex>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "TextFile |*.txt|xmkfile|*.xml";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.FilterIndex == 1)
                    {
                        StreamReader read = new StreamReader(openFileDialog1.FileName);
                        string header = read.ReadLine();
                        string line;

                        while (!read.EndOfStream)
                        {
                            line = read.ReadLine();
                            text = line.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            double a = double.Parse(text[0]);
                            double b = double.Parse(text[1]);
                            Complex obj = new Complex(a,b);
                            MyList.Add(obj);
                        }
                        read.Close();
                        MyList.Sort();
                        foreach (Complex item in MyList)
                        {
                            listBox1.Items.Add(item.ToString());
                        }

                    }

                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Complex.Flag = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Complex.Flag = false;
            MyList.Sort();
            listBox1.Items.Clear();
            foreach (Complex item in MyList)
            {
                listBox1.Items.Add(item.ToString());
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Complex.Flag = true;
            MyList.Sort();
            listBox1.Items.Clear();
            foreach (Complex item in MyList)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Complex Sum=new Complex(0,0);
            foreach (Complex item in MyList)
            {
                Sum = Sum.Add(item);
            }

            textBox1.Text = Sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Complex Sum = new Complex(1,1);
            foreach (Complex item in MyList)
            {
                Sum = Sum.MUL(item);
            }

            textBox2.Text = Sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            saveFileDialog1.Filter = "TEXT FILE|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                foreach (Complex item in MyList)
                {
                    write.WriteLine(item.ToString()); 

                }
                write.Close();

            }



        }
    }
}
