using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIMER
{
    public partial class Form1 : Form
    {
        int count=0;
        Graphics G;
       int topleftX = 150;
        int topleftY = 150;
        int lowerrightX = 300;
        int lowerrightY = 300;
        Pen P = new Pen(Color.Yellow, 15);
        Point[] d0;
        Point[] d1;
        Point[] d2;
        Point[] d3;
        Point[] d4;
        Point[] d5;
        Point[] d6;
        Point[] d7;
        Point[] d8;
        Point[] d9;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            timer1.Enabled = false;
            timer1.Stop();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count!=10)
            {

                if (count == 0)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d0);
                   
                        
                        }
                    else if (count == 1)
                {
                   
                    G.Clear(Color.Black);
                    G.DrawLines(P, d1);
                }
                else if (count == 2)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d2);
                   
                }
                else if (count == 3)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d3);
                   
                }
                else if (count == 4)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d4);
                   
                }
                    else if (count == 5)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d5);
                   
                }
                    else if (count == 6)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d6);
                   
                }
                    else if (count == 7)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d7);
                   
                }
                    else if (count == 8)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d8);
                   
                }
                    else if (count == 9)
                {
                    G.Clear(Color.Black);
                    G.DrawLines(P, d9);
                   
                }
                 
            }

            count++;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            G = panel1.CreateGraphics();
            //jagged point 
            //draw P while tick 
            // Rect for x,y 
            d0 = new Point[]
                  {
                   new Point(topleftX,topleftY),
                    new Point(lowerrightX,topleftY),
                      new Point(lowerrightX,lowerrightY),
                     new Point(topleftX,lowerrightY),
                    new Point(topleftX,topleftY),
                 
                  };
            d1 = new Point[]
                {
                   new Point(topleftX,topleftY),
                    new Point(topleftX,lowerrightY),
                
                };
                
            d2 = new Point[]
                {
                   new Point(topleftX,topleftY),
                    new Point(lowerrightX,topleftY),
                     new Point(lowerrightX,225),
                    new Point(topleftX,225),
                    new Point(topleftX,lowerrightY),
                   new Point(lowerrightX,lowerrightY),
                };
            d3 = new Point[]
                {
                   new Point(topleftX,topleftY),
                    new Point(lowerrightX,topleftY),
                     new Point(lowerrightX,225),
                    new Point(topleftX,225),
                    new Point(lowerrightX,225),
                   new Point(lowerrightX,lowerrightY),
                   new Point(topleftX,lowerrightY),
                };
            d4 = new Point[]
                {
                   new Point(topleftX,topleftY),
                    new Point(topleftX,225),
                     new Point(lowerrightX,225),
                    new Point(lowerrightX,topleftY),
                    new Point(lowerrightX,lowerrightY),
                     
                };
            d5 = new Point[]
                {
                    new Point(lowerrightX,topleftY),
                    new Point(topleftX,topleftY),
                    new Point(topleftX,225),
                     new Point(lowerrightX,225),
                    new Point(lowerrightX,lowerrightY),
                   

                   new Point(topleftX,lowerrightY),
                };
            d6 = new Point[]
                {
                   new Point(lowerrightX,topleftY),
                    new Point(topleftX,topleftY),
                    new Point(topleftX,225),
                     new Point(lowerrightX,225),
                    new Point(lowerrightX,lowerrightY),


                   new Point(topleftX,lowerrightY),
                     new Point(topleftX,topleftY),

                };
            d7 = new Point[]
                {
                   new Point(topleftX,topleftY),
                    new Point(lowerrightX,topleftY),
                   new Point(lowerrightX,lowerrightY),

                };
            d8 = new Point[]
                {
                   new Point(topleftX,topleftY),
                    new Point(lowerrightX,topleftY),
                      new Point(lowerrightX,lowerrightY),
                     new Point(topleftX,lowerrightY),
                    new Point(topleftX,topleftY),
                    new Point(topleftX,225),
                    new Point(lowerrightX,225),
                };
            d9 = new Point[]
                {
                    new Point(topleftX,topleftY),
                     new Point(topleftX,225),

                    new Point(lowerrightX,225),

                     new Point(lowerrightX,topleftY),
                     new Point(topleftX,topleftY),
                      new Point(lowerrightX,topleftY),
                   new Point(lowerrightX,lowerrightY),
                    new Point(topleftX,lowerrightY),
                };
        }
    }
}
