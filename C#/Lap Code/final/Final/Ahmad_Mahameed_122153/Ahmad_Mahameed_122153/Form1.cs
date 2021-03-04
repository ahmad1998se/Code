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

namespace Ahmad_Mahameed_122153
{
    public partial class Form1 : Form
    {
         DataClasses1DataContext mydb = new DataClasses1DataContext();
        List<Employee> Mylist = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "XMLFILE|*.xml";
            if(open.ShowDialog()==DialogResult.OK)
            {
                StreamReader file = new StreamReader(open.FileName);
                XmlSerializer D = new XmlSerializer(typeof(List<Employee>));
                Mylist.AddRange((List<Employee>)D.Deserialize(file));
                foreach (var item in Mylist)
                {
                    mydb.Employees.InsertOnSubmit(item);
                    mydb.SubmitChanges();

                    
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var R = from item in mydb.Employees
                        from item2 in mydb.Dependents
                        where item.SSN == item2.Dependent_SSN
                        select item2;
            }
            catch (Exception ee)
            { MessageBox.Show("Test"); }
                                      
                    
            dataGridView1.DataSource = R.ToArray();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADD_Dep f = new ADD_Dep();
            f.ShowDialog();
            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ss = Int32.Parse(textBox1.Text);

            var a = from item in mydb.Employees
                    where item.SSN == ss
                    select item;
            Employee ad = a.First();
            mydb.Employees.DeleteOnSubmit(ad);

            var dd = from item in mydb.Dependents
                    where item.ESSN == ss
                    select item;

            foreach (var item in dd)
            {
                mydb.Dependents.DeleteOnSubmit(item);
            }
            mydb.SubmitChanges();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
