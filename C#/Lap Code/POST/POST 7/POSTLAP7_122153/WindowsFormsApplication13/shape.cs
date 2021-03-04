using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication13
{
    // copy button copy = x1 
    public enum shType { rect,  Polygon };
    class shape
    {
       public int X1,Y1, X2, Y2;

        public void Move(int dx, int dy)
        {
            topleft.X += dx;
            topleft.Y += dy;
            lowerright.X += dx;
            lowerright.Y += dy;
        }
        public void Select(Graphics G)
        {
            SolidBrush B = new SolidBrush(Color.Red);
            Pen p = new Pen(Color.Blue, 5);
            
            if (shapeType == shType.rect)

            {

                G.DrawRectangle(p, topleft.X -10, topleft.Y-10 , width+20 , height+20);

                G.FillRectangle(B, lowerright.X+4 , (topleft.Y+(height/2)) , 14 , 14 );

                // G.FillRectangle(B, topleft.X+(height / 2)-7, lowerright.Y -7 , 14, 14);

                // G.FillRectangle(B, topleft.X+(width/2)-7, topleft.Y -7, 14, 14);

                G.FillRectangle(B, topleft.X + (width / 2) - 7, topleft.Y-17, 14, 14);

                G.FillRectangle(B, topleft.X-17 , (topleft.Y + (height / 2))-7, 14, 14);

                G.FillRectangle(B, topleft.X + (width / 2)-7, (topleft.Y + height)+4 , 14, 14);
            }
          
        }

        public bool IsInside(int x, int y)
        {
            if (x > topleft.X && y > topleft.Y &&
                x < lowerright.X && y < lowerright.Y)
                return true;
            return false;
        }
        shType shapeType;

        public shType ShapeType
        {
            get { return shapeType; }
            set { shapeType = value; }
        }
        public void DRAW(Graphics G, Pen P)
        {
            Point[] POLYGON = new Point[]
         {
                new Point (topleft.X,topleft.Y),
                new Point (topleft.X+(width/2),(topleft.Y+height)),
                new Point (topleft.X+width,topleft.Y),
                new Point (Lowerright.X,Lowerright.Y),
                new Point (topleft.X,lowerright.Y),
                new Point (topleft.X,topleft.Y),
         };

            G.DrawLines(P, POLYGON);

            //if (shapeType == shType.rect)
            //    G.DrawLines(P, POLYGON);
            // G.DrawPolygon(P, POLYGON);     

        }
        public shape(int x1, int y1, int x2, int y2,shType T)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
            shapeType = T;
            if (x1 < x2)
            {
                if (y1 < y2)
                {
                    topleft = new Point(x1, y1);
                    lowerright = new Point(x2, y2);
                }
                else if (y1 > y2)
                {
                    topleft = new Point(x1, y2);
                    lowerright = new Point(x2, y1);
                }
            }
            if (x1 > x2)
            {
                if (y1 < y2)
                {
                    topleft = new Point(x2, y1);
                    lowerright = new Point(x1, y2);
                }
                else if (y1 > y2)
                {
                    topleft = new Point(x2, y2);
                    lowerright = new Point(x1, y1);
                }
            }
            width = Math.Abs(x2 - x1);
            height = Math.Abs(y2 - y1);
        }
        Point topleft;

        public Point Topleft
        {
            get { return topleft; }
            set { topleft = value; }
        }
        Point lowerright;

        public Point Lowerright
        {
            get { return lowerright; }
            set { lowerright = value; }
        }
        int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public override string ToString()
        {
            return X1+"\t "+Y1+"\t "+X2+ "\t " + Y2;
        }
    }
}
