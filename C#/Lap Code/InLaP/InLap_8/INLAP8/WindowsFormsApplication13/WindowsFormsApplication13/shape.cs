using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication13
{
    public enum shType { rect, ellipse, Polygon };
    class shape
    {
        public void Move(int dx, int dy)
        {
            topleft.X += dx;
            topleft.Y += dy;
            lowerright.X += dx;
            lowerright.Y += dy;
        }
        public void Select(Graphics G)
        {
            SolidBrush B = new SolidBrush(Color.Yellow);
            if (shapeType == shType.rect)
                G.FillRectangle(B, topleft.X, topleft.Y, width, height);
            if (shapeType == shType.ellipse)
                G.FillEllipse(B, topleft.X, topleft.Y, width, height);
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
            if (shapeType == shType.rect)
                G.DrawRectangle(P, topleft.X, topleft.Y, width, height);
            else if (shapeType == shType.ellipse)
                G.DrawEllipse(P, topleft.X, topleft.Y, width, height);
        }
        public shape(int x1, int y1, int x2, int y2,shType T)
        {
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
    }
}
