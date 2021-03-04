using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLap_3
{
    class Complex
    {

        public Complex Add(Complex num2)
        {
            double c = num2.a;
            double d = num2.b;
            Complex Result = new Complex(a + c, b + d);
            return Result;
        }
        public Complex Sub(Complex num2)
        {
            double c = num2.a;
            double d = num2.b;
            Complex Result = new Complex(a - c, b - d);
            return Result;
        }
        public Complex MUL(Complex num2)
        {
            double c = num2.a;
            double d = num2.b;
            Complex result = new Complex((a * c - b * d), (b * c + a * d));
            return result;

        }
        public Complex DIV(Complex num2)
        {
            double c = num2.a;
            double d = num2.b;
            Complex result = new Complex((a * c + b * d) / (c * c + d * d),
                (b * c - a * d) / (c * c + d * d));
            return result;
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
        public Complex(double real, double imaginary)
        {
            a = real;
            b = imaginary;
        }

    }

    //public override string ToString()
    //{
    //    return A + B + "i";
    //}



}

