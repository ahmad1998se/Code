using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication18
{
   public class shape
    {
        public shape() { }
        public shape(string n, string d, double p, double c)
        {
            this.n = n;
            des = d;
            this.p = p;
            cal = c;
        }
        string n;

        public string Name
        {
            get { return n; }
            set { n = value; }
        }
        string des;

        public string Description
        {
            get { return des; }
            set { des = value; }
        }
        double p;

        public double Price
        {
            get { return p; }
            set { p = value; }
        }
        double cal;

        public double Calories
        {
            get { return cal; }
            set { cal = value; }
        }
    }
}
