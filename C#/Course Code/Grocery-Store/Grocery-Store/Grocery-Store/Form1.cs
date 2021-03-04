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
using System.Globalization;

namespace Grocery_Store
{
    public partial class Form1 : Form
    {
        List<Item> DataItem = new List<Item>();
        int datamissing = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            intext.Text = "D:\\se310\\items.csv";
            outtext.Text = "D:\\se310\\output.txt";



        }

        private void read_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            //ex
            intext.Text = openFileDialog1.FileName;

        }

        public Item makeobj(string[] arr)
        {
            
            Item a = new Item();
            a.ITEM_NO = arr[0];
            a.ITEM_NAME = arr[1];
            a.PRICE = arr[2];
            try
            {
                a.EXPIRATION_DATE = Convert.ToDateTime(arr[3]);
            }
            catch (System.FormatException e)
            {
                MessageBox.Show(+datamissing++ +" Line not valid");
                MessageBox.Show(e.Message);

            }
            return a;

        }

        public void display()
        {
            try
            {
                string[] Alldata = File.ReadAllLines(intext.Text);

                if (Alldata.Length > 0)
                {
                    for (int i = 0; i < Alldata.Length; i++)
                    {
                        string[] data = Alldata[i].Split(',');
                        if (data[0] != "" && data[1] != "" && data[2] != "" && data[3] != "")
                            DataItem.Add(makeobj(data));
                    }


                }
                else
                {
                    MessageBox.Show("No Data To retrive");

                }
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("There Is Error when reading File Try agian");
                MessageBox.Show(e.Message);


            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("The Defult Read File Not Exist ");
                MessageBox.Show(e.Message);


            }
            catch (IOException e)
            {

                MessageBox.Show("Close File CSV You Read It");
                MessageBox.Show(e.Message);

            }
            //////////////////////////////////////////////////////////// sort retrive
            // da z = DateTime.Now;
            // check date time


            ////////////////////////////////////////////////////
            var expired = from Item A in DataItem

                          let d = (A.EXPIRATION_DATE - DateTime.Now).TotalDays
                          //let  d = DateTime.Now.Subtract(A.EXPIRATION_DATE)
                          // where d.Days > 0
                          where d < 0
                          orderby A.EXPIRATION_DATE
                          select new { ITEM_NOO = A.ITEM_NO, ITEM_NAMEE = A.ITEM_NAME, PRICE_JOD_ = A.PRICE, Expiration_Date = A.EXPIRATION_DATE };

            expiredGrid1.DataSource = expired.ToList();

            var soon = from Item A in DataItem
                           // let d = DateTime.Now.Subtract(A.EXPIRATION_DATE)
                       let d = (A.EXPIRATION_DATE - DateTime.Now).TotalDays
                       // where d.Days < 0 && d.Days < 30
                       where d>0 && d <30
                       orderby A.EXPIRATION_DATE
                       select new { ITEM_NOO = A.ITEM_NO, ITEM_NAMEE = A.ITEM_NAME, PRICE_JOD_ = A.PRICE, Expiration_Date = A.EXPIRATION_DATE };
            soonGrid2.DataSource = soon.ToList();

            var good = from Item A in DataItem
                           // let d = DateTime.Now.Subtract(A.EXPIRATION_DATE)
                           //where d.Days < 30
                       let d = (A.EXPIRATION_DATE - DateTime.Now).TotalDays
                       where d>30
                       orderby A.EXPIRATION_DATE
                       select new { ITEM_NOO = A.ITEM_NO, ITEM_NAMEE = A.ITEM_NAME, PRICE_JOD_ = A.PRICE, Expiration_Date = A.EXPIRATION_DATE };
            goodGrid3.DataSource = good.ToList();
            ///////////////////////////////////////

            ///////////////////////////////////////
            IEnumerable<Item> writee = from Item A in DataItem
                                       orderby A.EXPIRATION_DATE
                                       select A;
            //1: Kit Kat(Expired 01 / 01 / 2019) 2.0
            try
            {
                StreamWriter file = new StreamWriter(outtext.Text);
                foreach (Item x in writee)
                {
                    file.WriteLine(x.ITEM_NO + ": " + x.ITEM_NAME + "(" + x.EXPIRATION_DATE.ToString("dd/mm/yyyy") + ")" + " " + x.PRICE);


                }
                file.Close();
            }
            catch (DirectoryNotFoundException Y)
            {
                  MessageBox.Show("The Defult Read File Not Exist ");
                MessageBox.Show(Y.Message);
            }
            finally
            {
               
            }


            //////////////////////////////////////





        }

        private void process_Click(object sender, EventArgs e)
        {
            
             /*expiredGrid1.DataSource=null;
            soonGrid2.DataSource=null;
            goodGrid3.DataSource=null;*/

            display();
           
        }
        public void Writetext(List<Item> A)
        {


        }
        private void write_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";

            openFileDialog1.ShowDialog();

            outtext.Text = openFileDialog1.FileName;

        }
    }
}
