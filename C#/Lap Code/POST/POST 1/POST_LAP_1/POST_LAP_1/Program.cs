using System;

namespace POST_LAP_1
{
    class Program
    {
        static void Main(string[] args)
        {          
            string Op;
            Console.WriteLine("Welcome to our calculator ^_^");
            Console.WriteLine("Choose The Operation ");
            Console.WriteLine("Enter 1 for Summation ");
            Console.WriteLine("Enter 2 for Difference ");
            Console.WriteLine("Enter C for Clear ");
            Console.WriteLine("Enter # for Exit ");
            Op = Console.ReadLine();                
            while (Op!="#")
            {
                if (Op=="1")
                {
                    try
                    {
                        decimal first;
                        decimal second;
                        Console.WriteLine("Enter The First Number ");
                        
                        first = Convert.ToDecimal(Console.ReadLine());
                        if (first.ToString().IndexOf(".") == -1)
                        { first = Convert.ToDecimal(string.Format("{0:0.00}", first)); }
                       // Console.WriteLine(first);
                        Console.WriteLine("Enter The Second Number ");
                        second = Convert.ToDecimal(Console.ReadLine());
                        if (second.ToString().IndexOf(".") == -1)
                        { second = Convert.ToDecimal(string.Format("{0:0.00}", second)); }
                       // Console.WriteLine(second);
                        Console.WriteLine(SUM(first, second)); 

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("The Value You Enter NOT Numeric");
                    }
                   

                }
                if (Op=="2")
                {
                    try
                    {
                        decimal first;
                        decimal second;
                        Console.WriteLine("Enter The First Number ");

                        first = Convert.ToDecimal(Console.ReadLine());
                        if (first.ToString().IndexOf(".") == -1)
                        { first = Convert.ToDecimal(string.Format("{0:0.00}", first)); }
                        // Console.WriteLine(first);
                        Console.WriteLine("Enter The Second Number ");
                        second = Convert.ToDecimal(Console.ReadLine());
                        if (second.ToString().IndexOf(".") == -1)
                        { second = Convert.ToDecimal(string.Format("{0:0.00}", second)); }
                        // Console.WriteLine(second);
                        Console.WriteLine(DEF(first, second));
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("The Value You Enter NOT Numeric");
                    }
                   
                }
                if (Op == "c" || Op == "C")
                {
                    Console.Clear();
                }
                Console.WriteLine("Choose The Operation ");
                Console.WriteLine("Enter 1 for Summation ");
                Console.WriteLine("Enter 2 for Difference ");
                Console.WriteLine("Enter C for Clear ");
                Console.WriteLine("Enter # for Exit ");
                Op = Console.ReadLine();
            }
            Console.WriteLine("------------ GOOD BYE ------------ ");



        }

        public static decimal SUM(decimal a,decimal b)
        {
            Boolean cor = false;
            string res="";
            decimal number=0 , Fractions;
            string FG = Convert.ToString(a);
            FG = FG.Substring(0, FG.IndexOf("."));
            string SG = Convert.ToString(a);
            SG = SG.Substring(SG.IndexOf(".")+1);
           // Console.WriteLine(Convert.ToDouble(FG)+1 + "" + SG);
            
            ////////////////////////////////////////
            string FFG = Convert.ToString(b);
            FFG = FFG.Substring(0, FFG.IndexOf("."));
            string SSG = Convert.ToString(b);
            SSG = SSG.Substring(SSG.IndexOf(".") + 1);
            //Console.WriteLine(FFG + "" + SSG);

            if (SG.Length > SSG.Length)
            {
                int len = SG.Length - SSG.Length;
                for (int i = 0; i < len; i++)
                {
                    SSG = SSG + 0;
                }
                

            }
            else if (SG.Length==SSG.Length)
            {   }
            else
            {
                int len = SSG.Length - SG.Length;
                for (int i = 0; i < len; i++)
                {
                    SG = SG + 0;
                }

            }

            if (Convert.ToString(a).IndexOf("-") != -1 && Convert.ToString(b).IndexOf("-") != -1)
            {
                res = "-";
                cor = true;

            }
             if ( (Convert.ToString(a).IndexOf("-") != -1 || Convert.ToString(b).IndexOf("-") != -1) && cor == false)
            {
                
              if(a<0==true && Math.Max(Math.Abs(a), Math.Abs(b) ) == Math.Abs(a))
               return DEF(Math.Abs(a), Math.Abs(b))*-1;
                else if (b<0==true && Math.Max(Math.Abs(a), Math.Abs(b)) == Math.Abs(b))
                    return DEF(Math.Abs(a), Math.Abs(b))*-1;
              else
                    return DEF(Math.Abs(a), Math.Abs(b));
            }
             
            
                Fractions = Convert.ToDecimal(SG) + Convert.ToDecimal(SSG);
                if (Fractions.ToString().Length > SG.Length)
                {
                    Fractions = Convert.ToDecimal(Fractions.ToString().Substring(1));
                if(cor==false)
                    number =+ 1;
                if (cor == true)
                    number =- 1;
                }

                number += Convert.ToDecimal(FG) + Convert.ToDecimal(FFG);

                res = number.ToString() + "." + Fractions.ToString();
           
            return Convert.ToDecimal(res);
        }
        public static decimal DEF(decimal a, decimal b)
        {
            
            string res="";
            decimal number = 0, Fractions ,max;
            string FG = Convert.ToString(a);
            FG = FG.Substring(0, FG.IndexOf("."));
            string SG = Convert.ToString(a);
            SG = SG.Substring(SG.IndexOf(".") + 1);
            // Console.WriteLine(Convert.ToDouble(FG)+1 + "" + SG);

            ////////////////////////////////////////
            string FFG = Convert.ToString(b);
            FFG = FFG.Substring(0, FFG.IndexOf("."));
            string SSG = Convert.ToString(b);
            SSG = SSG.Substring(SSG.IndexOf(".") + 1);
            if (SG.Length > SSG.Length)
            {
                int len = SG.Length - SSG.Length;
                for (int i = 0; i < len; i++)
                {
                    SSG = SSG + 0;
                }


            }
            else if (SG.Length == SSG.Length)
            { }
            else
            {
                int len = SSG.Length - SG.Length;
                for (int i = 0; i < len; i++)
                {
                    SG = SG + 0;
                }

            }
            if (Convert.ToString(a).IndexOf("-") != -1 && Convert.ToString(b).IndexOf("-") != -1 )
            {
               
                return DEF(Math.Abs(a), Math.Abs(b))*-1;
            }
            if (Convert.ToString(b).IndexOf("-") != -1)//+def-=sum+
            {
               
                return SUM(Math.Abs(a), Math.Abs(b));

            }
            if ( Convert.ToString(a).IndexOf("-") != -1 )//-def+=sum-
            {

                return SUM(Math.Abs(a), Math.Abs(b))*-1;
            }
            Fractions =Convert.ToDecimal(SG)-Convert.ToDecimal(SSG);
            if (Convert.ToDecimal(SSG) > Convert.ToDecimal(SG))
            {
                Fractions = Math.Max(Convert.ToDecimal(SSG), Convert.ToDecimal(SG)) - Math.Min(Convert.ToDecimal(SSG), Convert.ToDecimal(SG));
                number = -1;
            }
            number = Convert.ToDecimal(FG) - Convert.ToDecimal(FFG);
            if (Convert.ToDecimal(FFG) > Convert.ToDecimal(FG))
            {
                number = Math.Max(Convert.ToDecimal(FFG), Convert.ToDecimal(FG)) - Math.Min(Convert.ToDecimal(FFG), Convert.ToDecimal(FG));
                res = "-";
            }
            res += number.ToString() + "." + Fractions.ToString();
            return Convert.ToDecimal(res);





        }



    }
}
