using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmad_Mahameed_122153
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangles> REC = new List<Rectangles>();

            Console.WriteLine("##########   MENU   ##########");
            Console.WriteLine("PRESS # to Exit");
            Console.WriteLine("PRESS C to Clear The Screen");
            Console.WriteLine("PRESS 1 to Add Rectangle Record ");
            Console.WriteLine("PRESS 2 to View All Rectangle Record");
            Console.WriteLine("PRESS 3 to Show Squares");
            Console.WriteLine("PRESS 4 to Show Largest Rectangle");
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("##############################");
            
            string operation= Console.ReadLine();
            
             while (operation != "#")
                {
                   

                    if (operation == "C" || operation == "c")
                    {
                        Console.Clear();
                    
                    }
                    if(operation=="1")
                    {
                        try
                        {
                            Rectangles O = new Rectangles();

                        Console.WriteLine("Enter Width");
                        O.width = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter Height");
                        O.height = Convert.ToDouble (Console.ReadLine());
                        REC.Add(O);
                        }
                        catch (Exception e)

                        { Console.WriteLine(e.Message); }

                        
                    }
                    if(operation=="2")
                    {
                        foreach (Rectangles A in REC)
                        {
                            Console.WriteLine("WIDTH   Height   Area   circumference");
                            Console.WriteLine(A.width+"       "+A.height+"      "+A.Area+"         "+A.circumference   );
                     
                        }
                    
                    }
                    if(operation=="3")
                    {
                        foreach (Rectangles A in REC)
                        {

                            if (A.IsSquare == true)
                            {
                                Console.WriteLine("WIDTH   Height   Area   circumference");
                                Console.WriteLine(A.width + "     " + A.height + "    " + A.Area + "       " + A.circumference);
                            }

                        }
                    
                    
                    }
                    if (operation == "4")
                    {
                        var r = from item in REC
                                orderby item.circumference
                                select item;
                        Rectangles X = r.Last();

                        Console.WriteLine("WIDTH   Height   Area   circumference");
                        
                            Console.WriteLine(X.width + "     " + X.height + "    " + X.Area + "       " + X.circumference);

                    
                    }

                    Console.WriteLine("##########   MENU   ##########");
                    Console.WriteLine("PRESS # to Exit");
                    Console.WriteLine("PRESS C to Clear The Screen");
                    Console.WriteLine("PRESS 1 to Add Rectangle Record ");
                    Console.WriteLine("PRESS 2 to View All Rectangle Record");
                    Console.WriteLine("PRESS 3 to Show Squares");
                    Console.WriteLine("PRESS 4 to Show Largest Rectangle");
                    Console.WriteLine("Enter Your Choice");
                    Console.WriteLine("##############################");
                    operation = Console.ReadLine();


                
                }

            
               
                
                



        }
    }
}
