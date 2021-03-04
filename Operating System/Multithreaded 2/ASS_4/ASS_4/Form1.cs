using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASS_4
{
    public partial class Form1 : Form
    {
        string[] text;
        //MYPath
        //"C:\Users\Ahmad\Desktop\CS375_Ass#4_122153_Y\Test_Data.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please Change The Path Of Write And Read In StreamReader and Write");
            MessageBox.Show("i dont use Semaphore because it useless in this programe but if there is point can put it at anyplace  that were write Thread.Sleep(1000)  ");
        }
        public void sum(Thread a)
        {
            int sum = 0;
            for (int i = 1; i <= 1000000; i++)
            {
                sum += i;
            }


            

        }
        public int increment(string [] arr)
        {
            int number2 = Convert.ToInt32(arr[1]);
            number2++;
            return number2;


        }
        public void read()
        {

            try
            {
               

                lock (this)
                {
                    

                    StreamReader read = new StreamReader("C:\\Users\\Ahmad\\Desktop\\CS375_Ass#4_122153_Y\\Test_Data.txt");
                        

                    string line;

                    while (!read.EndOfStream)////////////read
                    {
                        line = read.ReadLine();
                        text = line.Split(new char[] { '\t', ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);


                    }
                    read.Close();////////////////////////close

                     sum(Thread.CurrentThread);

            
                

                ////////////////////////////////////////////////////////////////////// open/write/print
                   
                        
                                // Change The Path Here
                            using (StreamWriter write = File.AppendText("C:\\Users\\Ahmad\\Desktop\\CS375_Ass#4_122153_Y\\Test_Data.txt"))
                            {

                                Thread.Sleep(1000);
                                write.Write("\n"+Thread.CurrentThread.ManagedThreadId+" " + increment(text));
                                write.Close();
                            }
                            
                        }

            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread a1 = new Thread(read);
            a1.Start();
            Thread a2 = new Thread(read);
            a2.Start();
            Thread a3 = new Thread(read);
            a3.Start();



        }

}
    }

