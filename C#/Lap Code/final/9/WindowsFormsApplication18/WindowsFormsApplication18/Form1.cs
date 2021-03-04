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
using System.Xml.Serialization;

namespace WindowsFormsApplication18
{
    public partial class Form1 : Form
    {
        List<shape> menu = new List<shape>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "xmlfile|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader infile = new StreamReader(dlg.FileName);
                XmlSerializer DES=new XmlSerializer(typeof(List<shape>));
              menu=(List<shape>)  DES.Deserialize(infile);
              dataGridView1.DataSource = menu;
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var R = from Item in menu
                    where Item.Calories > 900
                    orderby Item.Price descending
                    select Item;
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XMLFILE|*.xml";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter outfile = new StreamWriter(dlg.FileName);
                XmlSerializer SER=new XmlSerializer(typeof(List<shape>));
                SER.Serialize(outfile, R.ToList());
                outfile.Close();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
