using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POST_LAP_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelephoneNumberWordGenerator data = new TelephoneNumberWordGenerator();
            try
            {
                if (data.ReadSevenDigit(Int32.Parse(textBox1.Text.ToString())) == true)
                    textBox2.Text = data.ShowListOfWords();
            }
            catch (Exception a)
            {
                textBox2.Text = a.Message;

            }
           
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
