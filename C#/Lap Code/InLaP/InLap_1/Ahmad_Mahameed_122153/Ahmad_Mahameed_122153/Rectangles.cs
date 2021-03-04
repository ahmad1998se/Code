using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmad_Mahameed_122153
{
  public  class Rectangles
    {
        private double Width;

        public double width
        {
            get { return Width; }
            set
            {
                if (value > 0)
                    Width = value;
                else
                    throw new Exception("The Value wrong");
            }
        }


        private double Height;

        public double height
        {
            get { return Height; }
            set
            {
                if (value > 0)
                    Height = value;
                else
                    throw new Exception("The Value wrong");
            }
        }
   

      public   double Area
        {
             get { return width * height; }
        }
     public    double circumference
        {
             get { return 2 * (width + height); }
        }
       public  bool IsSquare
        {
             get
            {
                if (width == height)
                    return true;
                else
                    return false;
            
            }

        }



        



    }
}
