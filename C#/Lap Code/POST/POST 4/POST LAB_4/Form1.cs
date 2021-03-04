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

namespace POST_LAB_4
{
    public partial class Form1 : Form
    {
        List<string> dis = new List<string>();
        string alldata;
        string[] filter;
        int Doubles = 0;
        int Integers = 0;
        int Dates;
        //int Words;
        int Others;
        int Plaindroom = 0;
        double Sum = 0;
        double Max = 0;
        string Word="";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TEXT FILE|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                alldata = read.ReadToEnd();
                read.Close();
                textBox11.Text = openFileDialog1.FileName;


            }

            filter = alldata.Split(new char[] { ' ', '\t', ',', '\n', '\r', ':', ';' },
          StringSplitOptions.RemoveEmptyEntries);


            analyze(filter);
            plain(filter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TEXT FILE|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                write.WriteLine("Number Of Lines : " + textBox1.Text);
                write.WriteLine("Number of Doubles : " + textBox2.Text);
                write.WriteLine("Number of Integers : " + textBox3.Text);
                write.WriteLine("Number of Dates : " + textBox4.Text);
                write.WriteLine("Number of Plaindroom : " + textBox5.Text);
                write.WriteLine("Number of Words : " + textBox6.Text);
                write.WriteLine("Sum Of Doubles : " + textBox7.Text);
                write.WriteLine("Max of Integers : " + textBox8.Text);
                write.WriteLine("Longest Word : " + textBox9.Text);
                write.WriteLine("Number of Others : " + textBox10.Text);
                write.WriteLine("The Path of the File : " + textBox11.Text);

                write.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Doubles.ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] lines = alldata.Split(new char[] { '\n', '\r' },
           StringSplitOptions.RemoveEmptyEntries);
            textBox1.Text = lines.Length.ToString();
        }

        public void analyze(string[] data)
        {
            int test_int;
            DateTime test_date;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].IndexOf('.') != -1)
                {
                    Doubles++;
                    Sum += Convert.ToDouble(data[i]);

                }
                else if (Int32.TryParse(data[i], out test_int) == true)
                {
                    Integers++;
                    Max = Math.Max(Convert.ToInt32(data[i]), Max);
                }
                else if (DateTime.TryParse(data[i], out test_date))
                {
                    Dates++;
                }
                
                else if (data[i].Length > 1 && char.IsLetter(data[i][0]) == true)
                {
                    bool word = false;

                    for (int j = 0; j < data[i].Length; j++)
                    {
                        if (Char.IsLetter(data[i][j]) == true)
                            word = true;
                        else
                        {
                            word = false;
                            break;
                        }
                    }
                    if (word == true)
                    {
                        if (data[i].Length > Word.Length)
                            Word = data[i];
                        dis.Add(data[i]);
                       
                    }
                }
                else
                    Others++;



            }
        }
        public void plain(string[] data)
        {
            bool plain = false;
            
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length/2; j++)
                {
                    if (data[i][j] == data[i] [data[i].Length - j - 1])
                        plain = true;
                    else
                    {
                        plain = false;
                        break;
                    }
                }
                if (plain == true)
                    Plaindroom++;
            }
            

        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = Integers.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = Dates.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = Plaindroom.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> uniqueList = dis.Distinct().ToList();

            textBox6.Text = uniqueList.Count.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox7.Text = Sum.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox8.Text = Max.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox9.Text = Word;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox10.Text = Others.ToString();
        }
    }
}
