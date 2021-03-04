using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            History s = new History();
            s.ShowDialog();
            this.Close();

        }

        private void newProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Create s = new Create();
            s.ShowDialog();
            this.Close();
        }

        private void currentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Current s = new Current();
            s.ShowDialog();
            this.Close();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 s = new Form1();
            s.ShowDialog();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Statistics s = new Statistics();
            s.ShowDialog();
            this.Close();
        }

        private void History_Load(object sender, EventArgs e)
        {
            List<int> List1 = new List<int>();
            for (int r = 0; r < 10; r++)
            {
                List1.Add(1);
            }
            fillHistore(List1);

        }
        public void Information()
        {
            //Grid1.Rows[1].SetValues(Player_Name, Date_Of_lastGame, Duration, N_Of_Steps, N_Of_Barriers.ToString());


        //         public int N_Of_Games { set; get; }
        //public int N_Of_profiles { set; get; }
        //public double Highest_Score { set; get; }
        //public double Lowest_Score { set; get; }
        //public double Minimum_Duration { set; get; }
        //public double Maximum_Duration { set; get; }
        //public double Total_Duration { set; get; }
        //public string Player_Name { set; get; }
        //public int/*doublestring*/ Duration { set; get; }
        //public int N_Of_Steps { set; get; }
        //public int N_Of_Barriers { set; get; }
        //public DateTime Date_Of_lastGame { set; get; }
        //public Button Create_Player = new Button();


        }



        public void fillHistore(List<int> list)
        {


            for (int i = 0; i < list.Count; i++)
            {
                Grid2.RowCount = Grid2.RowCount + 1;

                switch (list[i])
                {
                    case 1:
                        Grid2.Rows[i].SetValues(i, "up");
                        break;

                    case 2:
                        Grid2.Rows[i].SetValues(i, "Dawn");
                        break;
                    case 3:
                        Grid2.Rows[i].SetValues(i, "Right");
                        break;
                    case 4:
                        Grid2.Rows[i].SetValues(i, "Lift");
                        break;

                }



            }
        }
    }
}
