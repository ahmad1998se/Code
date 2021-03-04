using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLap_4_122153
{
    class Complex:IComparable
    {

        
        private static bool flag;
        public static bool Flag { get => flag; set => flag = value; }
        public int CompareTo(object b)
        {
            if (b is Complex)
            {
                Complex c = (Complex)b;
                if(flag)
                    return a.CompareTo(c.a);
                else
                return a.CompareTo(c.b);

            }
            else
                throw new Exception("B is Not a Complex");
        }

        public override string ToString()
        {
            return a + " + " + b + "i";
        }
        public Complex Add(Complex N2)
        {
            double c = N2.a;
            double d = N2.b;
            return new Complex(a + c, b + d);

        }
        public Complex SUB(Complex N2)
        {
            double c = N2.a;
            double d = N2.b;
            return new Complex(a - c, b - d);

        }
        public Complex MUL(Complex N2)
        {
            double c = N2.a;
            double d = N2.b;
            return new Complex((a * c - b * d), (b * c + a * d));
        }
        public Complex DIV(Complex N2)
        {
            double c = N2.a;
            double d = N2.b;
            return new Complex((a * c + b * d) / (c * c + d * d), (b * c - a * d) / (c * c + d * d));

        }
        public double ABS()
        {
            return Math.Sqrt(a * a + b * b);
        }

        double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }
        double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

       

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        


    }
}
