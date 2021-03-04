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

namespace ENC_DEC
{
    public partial class Form1 : Form
    {

        string[] text;
        List<string> FinalText=new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }
        public void enc(string[] t)
        {
            StringBuilder result = new StringBuilder();
            foreach (string text in t)
            {
                if (text.Length>0)
                { 
                for (int i = 0; i < text.Length; i++)
                {
                        if ( i%2==0 )
                        {
                            if (char.IsUpper(text[i]))
                            {
                                char ch = (char)(((int)text[i] +
                                                3 - 65) % 26 + 65);
                                result.Append(ch);
                            }
                            else
                            {
                                char ch = (char)(((int)text[i] +
                                                3 - 97) % 26 + 97);
                                result.Append(ch);
                            }
                        }
                        else
                        {
                            if (char.IsUpper(text[i]))
                            {
                                char ch = (char) (((int)text[i] +
                                                77 - 65) % 26 + 65);
                                result.Append(ch);
                            }
                            else
                            {
                                char ch = (char)(((int)text[i] +
                                                103 - 97) % 26 + 97);
                                result.Append(ch);
                            }
                        }
                   
                    }
                    
                }

                FinalText.Add(result.ToString());
                result.Clear();
            }
         
        }
        public void dec(string[] t)
        {

            StringBuilder result = new StringBuilder();
            foreach (string text in t)
            {
                if (text.Length > 0)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (i % 2== 0)
                        {
                            if (char.IsUpper(text[i]))
                            {
                                char ch = (char)(((int)text[i] -
                                                3 - 65) % 26 + 65);
                                result.Append(ch);
                            }
                            else
                            {
                                char ch = (char)(((int)text[i] -
                                                3 - 97) % 26 + 97);
                                result.Append(ch);
                            }
                        }
                        else
                        {
                            if (char.IsUpper(text[i]))
                            {
                                char ch = (char)(((int)text[i] +
                                                53 - 65) % 26 + 65);
                                result.Append(ch);
                            }
                            else
                            {
                                char ch = (char)(((int)text[i] +
                                                79 - 97) % 26 + 97);
                                result.Append(ch);
                            }



                        }


                    }
                  
                }

                FinalText.Add(result.ToString());
                result.Clear();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            try
            {
                openFileDialog1.Filter = "TextFile |*.txt|xmkfile|*.xml";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.FilterIndex == 1)
                    {
                        StreamReader read = new StreamReader(openFileDialog1.FileName);
                   
                        string line;

                        while (!read.EndOfStream)
                        {
                            line = read.ReadLine();
                            text = line.Split(new char[] { '\t', ' ','\n' }, StringSplitOptions.RemoveEmptyEntries);
                            textBox1.Text += "\t" + line;
                            if (radioButton1.Checked == true)
                                enc(text);
                            else if (radioButton2.Checked == true)
                                dec(text);
                                                                               
                        }
                        read.Close();                                            
                    }

                }
                foreach (var item in FinalText)
                {
                    textBox2.Text += "\t" + item.ToString();
                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);

            }

            
        }

            
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";

            foreach (var item in FinalText)
            {
                textBox1.Text +="\t"+ item.ToString();
            }

            saveFileDialog1.Filter = "TEXT FILE|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(saveFileDialog1.FileName);
                foreach (String item in FinalText)
                {
                    write.WriteLine(item.ToString());

                }
                write.Close();

            }
            FinalText.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            textBox1.Text = "";
            MessageBox.Show(" The Program Is Designed For Alphabet Character");
        }

        
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        text = textBox1.Text.Split(new char[] { '\t', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //        if (radioButton1.Checked == true)
        //            enc(text);
        //        else
        //            dec(text);

        //        foreach (var item in FinalText)
        //        {
        //            textBox2.Text +=  item.ToString();
                    
        //        }
        //        FinalText.Remove(FinalText.First());
        //    }
            
        //    catch (Exception d)
        //    {
        //        MessageBox.Show(d.Message);
        //    }


        //}

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
            try
            {
                text = textBox1.Text.Split(new char[] { '\t', ' ','\n','\r' });
                if (radioButton1.Checked == true)
                    enc(text);
                else
                    dec(text);

                foreach (var item in FinalText)
                {
                    textBox2.Text += "\t" + item.ToString();

                }
                
            }

            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            FinalText.Clear();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            FinalText.Clear();
            text = null;
        }
    }
}
