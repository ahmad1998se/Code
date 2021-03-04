using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                information data = new information();

                data.SSN1 = SSNtextBox.Text;
                data.FullName1 = firsttextBox.Text + "\t";
                data.FullName1 = middletextBox.Text + "\t";
                data.FullName1 = lasttextBox.Text + "\t";
                if (gendercomboBox.SelectedIndex == 0)
                    data.Gender1 = persontype.Male;
                else
                    data.Gender1 = persontype.Female;


                if (comboBox3.SelectedIndex == 0)
                    data.Education1 = edutype.Medicine;
                else if (comboBox3.SelectedIndex == 1)
                    data.Education1 = edutype.Nursing;
                else
                    data.Education1 = edutype.Dentistry;

                data.Year_of_Experiance1 = Convert.ToInt32(experiancetextBox.Text);

                if (rankcomboBox.SelectedIndex == 0)
                    data.Rank1 = ranktype.Pass;
                else if (rankcomboBox.SelectedIndex == 1)
                    data.Rank1 = ranktype.Good;
                else if (rankcomboBox.SelectedIndex == 2)
                    data.Rank1 = ranktype.VeryGood;
                else
                    data.Rank1 = ranktype.Pass;



                data.Graduation_Year1 = Convert.ToInt32(g_comboBox.SelectedItem.ToString());

                Program.list1.Add(data);
                Program.list1.Sort();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Program.list1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1980; i <= DateTime.Now.Year; i++)
            {
                g_comboBox.Items.Add(i);

            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {


            MessageBox.Show(" Priorty Report :");
           
            var n1=  from IT in Program.list1
                     where IT.Education1 == edutype.Medicine
                            select IT;

            foreach (var item in n1)
            {
                Program.Nursing.Push(item);
            }

            MessageBox.Show("Number of Medicine applicant : " + n1.Count());
            ////////////////////////////////////////////////////////////////////////////
            ///


            var n2 = from IT in Program.list1
                     where IT.Education1 == edutype.Nursing
                     orderby IT.scores 
                     select IT;
            foreach (var item in n2)
            {
                Program.Nursing.Push(item);
            }

            MessageBox.Show("The  Dentistry applicant with highest priorty Full Name :" + n2.Last().FullName1 + " Score" + n2.Last().scores);
            /////////////////////////////////////////////////////////////////////////////////


            var n3 = from IT in Program.list1
                     where IT.Education1 == edutype.Dentistry
                     orderby IT.scores
                     select IT;
            foreach (var item in n3)
            {
                Program.Nursing.Push(item);
            }
            Program.Nursing.Pop();

            MessageBox.Show(" The Nursing applicant with second priorty Full Name :" + n3.Last().FullName1 + " Score" + n3.Last().scores);
            ////////////////////////////////////////////////////////////////////////////
            ///
            var n4 = from IT in Program.list1
                     where IT.Gender1 == persontype.Female
                     orderby IT.scores
                     select IT;
            foreach (var item in n4)
            {
                Program.Nursing.Push(item);
            }
            MessageBox.Show("The  Female Nursing applicant with highest priorty Full Name :" + n4.Last().FullName1 + " Score" + n4.Last().scores);
            /////////////////////////////////////////////////////////////////////////////////
            var n5 = from IT in Program.list1
                     
                     orderby IT.scores
                     select IT;
            foreach (var item in n4)
            {
                Program.Nursing.Push(item);
            }
            MessageBox.Show("The  male  applicant with least priorty Full Name :"+n5.Last().FullName1+" Score"+ n5.Last().scores);





        }
    }
}
