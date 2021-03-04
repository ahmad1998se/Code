using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3_2
{
    static class Program
    {
       public static List<information> list1 = new List<information>();
        public static Stack<information> Nursing = new Stack<information>();
        public static Queue<information> Dentistry = new Queue<information>();
        public static Queue<information> Medicine = new Queue<information>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
