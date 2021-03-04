using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Game
{
   public class Profile
    {
        public Profile()
        {
            N_Of_profiles++;
        }

        public int N_Of_Games { set; get; }
        public int N_Of_profiles { get; }
        public double Highest_Score { set; get; }
        public double Lowest_Score { set; get; }
        public double Minimum_Duration { set; get; }
        public double Maximum_Duration { set; get; }
        public double Total_Duration { set; get; }
        //Statistics
        public string Player_Name { set; get; }
        public DateTime Date_Of_lastGame { set; get; }
        public int/*doublestring*/ Duration { set; get; }
        public int N_Of_Steps { set; get; }
        public int N_Of_Barriers { set; get; }
        // History
        public string Player_Age { set; get; }
        public string Player_Gender { set; get; }
        public string Toy_figure { set; get; }
        public Button Create_Player = new Button();
        //Create
       public Profile(ref GroupBox G ,ref Button Actor)
        {
           // call cc = new call();
           
            Random r = new Random();

            Create_Player.Size = new Size(40, 40);
           // Point p = new Point();
           // cc.ref_of_obj(ref cc);
           // cc.retrev(ref p);
            Create_Player.Location = new Point(10, 10);
            Create_Player.Name = "Create_Player";// Player_Name;//selectid from profil;

            Create_Player.BackColor = Color.Yellow;
            Create_Player.Visible = true;
            Create_Player.BringToFront();
            Create_Player.Dock = new DockStyle();
           // b = this.Create_Player;
            G.Controls.Add(Create_Player);
            ref_b(ref Actor);
            // player.BringToFront();

        }
        public void ref_b( ref Button b) { b = this.Create_Player; }
        public void ref_p(ref Profile p) { p = this; }




    }
}
