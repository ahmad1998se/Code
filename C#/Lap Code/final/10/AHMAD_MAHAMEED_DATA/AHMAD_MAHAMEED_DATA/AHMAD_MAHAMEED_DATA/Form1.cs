using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHMAD_MAHAMEED_DATA
{
    public partial class Form1 : Form
    {
        MYDBDataContext db = new MYDBDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void F()
        {
            var R = from item in db.PersonalCards
                    from item2 in db.EmployeeCards
                    where item.SSN == item2.ssn
                    orderby item.Bdate
                    select new
                    {
                        item.SSN,
                        item.FullName,
                        item.Bdate,
                        item.Gender,
                        item2.Id,
                        item2.Salary,
                        item2.JobTitle

                    };
            dataGridView1.DataSource = R.ToArray();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            F();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                int ssn = Int32.Parse(textBox1.Text);
                var R = from item in db.PersonalCards
                        where item.SSN == ssn
                        select item;
                if (R.Count() > 0)
                {
                    MessageBox.Show("Already Exist");

                }
                else
                {
                    PersonalCard p = new PersonalCard();
                    p.SSN = ssn;
                    p.FullName = textBox2.Text;
                    p.MotherName = textBox3.Text;
                    p.BPlace = textBox4.Text;
                    p.Bdate = dateTimePicker1.Value;
                    p.Gender = comboBox1.SelectedItem.ToString();
                    EmployeeCard E = new EmployeeCard();
                    E.ssn = ssn;
                    E.JobTitle = textBox5.Text;
                    E.Salary = double.Parse(textBox6.Text);
                    db.PersonalCards.InsertOnSubmit(p);
                    db.EmployeeCards.InsertOnSubmit(E);
                    db.SubmitChanges();
                    F();
                
                }
            
            }
            catch(Exception d)            
            {
                MessageBox.Show(d.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           try{ int ssn = Int32.Parse(textBox1.Text);
            var R = from item in db.PersonalCards
                    where item.SSN == ssn
                    select item;
            if (R.Count() <= 0)
            {
                MessageBox.Show("Not Found");

            }
            else
            {
                PersonalCard p = R.First();
                //  p.SSN = ssn;
                p.FullName = textBox2.Text;
                p.MotherName = textBox3.Text;
                p.BPlace = textBox4.Text;
                p.Bdate = dateTimePicker1.Value;
                p.Gender = comboBox1.SelectedItem.ToString();
                var r2 = from item2 in db.EmployeeCards
                         where item2.ssn == ssn
                         select item2;
                EmployeeCard E = r2.First();
                //E.ssn = ssn;
                E.JobTitle = textBox5.Text;
                E.Salary = double.Parse(textBox6.Text);
                db.SubmitChanges();
                F();
            }
            }
            catch(Exception ss)
           { MessageBox.Show(ss.Message); }

              
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int ssn = Int32.Parse(textBox1.Text);
                var R = from item in db.PersonalCards
                        where item.SSN == ssn
                        select item;
                if (R.Count() <= 0)
                {
                    MessageBox.Show("Not Found");

                }
                else
                {
                    PersonalCard p = R.First();
                    var R2 = from item in db.EmployeeCards
                            where item.ssn == ssn
                            select item;
                    EmployeeCard E = R2.First();
                    db.EmployeeCards.DeleteOnSubmit(E);
                    db.PersonalCards.DeleteOnSubmit(p);
                    db.SubmitChanges();
                    F();
                }

            }
            catch (Exception ss)
            { MessageBox.Show(ss.Message); }
        }
    }
}
