using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InLap_Ahmad_Mahameed_122153
{
    public partial class Form1 : Form
    {
        List<Rectangle> RCTLIST=new List<Rectangle>();
        public void print()
        {
            if (radioButton1.Checked)
            {

                var D = from IT in RCTLIST

                        select IT;

                foreach (Rectangle item in D)
                {
                    textBox3.Text += item.ToString();
                }

            }

            if (radioButton1.Checked)
            {
                if (radioButton5.Checked)
                {
                    if (radioButton3.Checked)
                    {
                        var R = from IT in RCTLIST
                                orderby IT.Area ascending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }
                    if (radioButton4.Checked)
                    {
                        var R = from IT in RCTLIST
                                orderby IT.Height ascending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }


                }
        }

                if (radioButton6.Checked)
                {
                    if (radioButton3.Checked)
                    {
                        var R = from IT in RCTLIST
                                orderby IT.Area descending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }
                    if (radioButton4.Checked)
                    {
                        var R = from IT in RCTLIST
                                orderby IT.Height descending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }
                }



                else if (radioButton2.Checked)
                {
                    var R = from IT in RCTLIST
                            where IT.Width == IT.Height
                            orderby IT.Area ascending
                            select IT;

                    foreach (Rectangle item in R)
                    {
                        textBox3.Text += item.ToString();
                    }
                }
                if (radioButton2.Checked)
                {
                if (radioButton5.Checked)
                {
                    if (radioButton3.Checked)
                    {
                        var R = from IT in RCTLIST
                                where IT.Width == IT.Height
                                orderby IT.Area ascending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }
                    if (radioButton4.Checked)
                    {
                        var R = from IT in RCTLIST
                                where IT.Width == IT.Height
                                orderby IT.Height ascending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }


                }

        }


                if (radioButton6.Checked)
                {
                    if (radioButton3.Checked)
                    {
                        var R = from IT in RCTLIST
                                where IT.Width == IT.Height
                                orderby IT.Area descending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }
                    if (radioButton4.Checked)
                    {
                        var R = from IT in RCTLIST
                                where IT.Width == IT.Height
                                orderby IT.Height descending
                                select IT;

                        foreach (Rectangle item in R)
                        {
                            textBox3.Text += item.ToString();
                        }
                    }
                }
            
            
            


        
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            try {
                Rectangle RCT = new Rectangle();
                RCT.Width = double.Parse(textBox1.Text);
                RCT.Height = double.Parse(textBox2.Text);
                RCTLIST.Add(RCT);
                textBox3.Clear();
                textBox3.Text = "Width\tHeight\tCircumference\tArea\r\n";
                print();
              
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
                textBox1.Clear();
                textBox2.Clear();
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ADD.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // if(groupBox1.)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            print();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            print();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            print();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            print();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            print();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            print();
        }
    }
}
