using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InLap_Ahmad_Mahameed_122153
{
    class Rectangle
    {
        private double width;
        private double height;


        public bool issquare;

        public double Area
        {
            get { return width * height; }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value > 0)
                    width = value;
                else
                    throw new Exception("Value Must be Positive");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    throw new Exception("Value Must be Positive");
            }
        }

        public double Circumference
        {
            get { return (width + height) * 2; }
        }


        public bool Issquare
        {

            get
            {
                if (width == height)
                    return true;
                else
                    return false;
            }


        }
        public override string ToString()
        {
            return width + "\t\t" + height + "\t\t" + "\t\t" + Circumference + "\t\t" + Area + Environment.NewLine;
        }

    }
}