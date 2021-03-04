using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahmad_Mahameed_122153
{
    public partial class ADD_Dep : Form
    {
        DataClasses1DataContext mydbb = new DataClasses1DataContext();
        public ADD_Dep()
        {
            InitializeComponent();
        }

        private void ADD_Dep_Load(object sender, EventArgs e)
        {
            var r = from item in mydbb.Dependents
                    select item.ESSN;
            foreach (var item in r)
            {
                comboBox1.Items.Add(item);
            }
            
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var r = from item in mydbb.Dependents
                    where item.ESSN == Int32.Parse(comboBox1.SelectedItem.ToString())
                    select item;

            Dependent a = r.First();
            a.Dependemt_Name = textBox1.Text;

            var b = from item in mydbb.Dependents
                    where item.ESSN == Int32.Parse(textBox2.Text)
                    select item;
            if (b.Count() <= 0)
            {
                a.Dependent_SSN = Int32.Parse(textBox2.Text);
            }
            else
            {
                MessageBox.Show("ERORR");

            }
            if (radioButton1.Checked)
            {
                a.Gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                a.Gender = "FeMale";

            }
            if (radioButton3.Checked)
            { a.Relation = "Son"; }
            else if (radioButton4.Checked)
            { a.Relation = "Daughter"; }
            else if (radioButton5.Checked)
            { a.Relation = "Husband"; }
            else if (radioButton6.Checked)
            { a.Relation = "Wife"; }

            mydbb.Dependents.InsertOnSubmit(a);
            mydbb.SubmitChanges();




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
