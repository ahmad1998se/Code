using System;

namespace POST_LAP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0;

            string Op;
            Console.WriteLine("Welcome to our calculator ^_^");


            Console.WriteLine("Choose The Operation ");
            Console.WriteLine("Enter 1 for Summation ");
            Console.WriteLine("Enter 2 for Difference ");
            Console.WriteLine("Enter C for Clean ");
            Console.WriteLine("Enter # for Exit ");

            Op = Console.ReadLine();
            while (Op != "#")
            {
                if (Op == "1")
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
                        Console.WriteLine(second);
                        SUM(first, second, ref c);
                        if (c > 0)
                        {
                            Console.WriteLine(SUM(first, second, ref c));
                        }
                        else
                        {
                            Console.WriteLine(SUM(first, second, ref c));

                        }

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("The Value You Enter NOT Numeric");
                    }


                }
                if (Op == "2")
                {
                    try
                    {
                        Decimal first;
                        decimal second;
                        Console.WriteLine("Enter The First Number ");
                        first = Convert.ToDecimal(Console.ReadLine());
                        if (first.ToString().IndexOf(".") == -1)
                        { first = Convert.ToDecimal(string.Format("{0:0.00}", first)); }
                        Console.WriteLine("Enter The Second Number ");
                        second = Convert.ToDecimal(Console.ReadLine());
                        if (second.ToString().IndexOf(".") == -1)
                        { second = Convert.ToDecimal(string.Format("{0:0.00}", second)); }
                        DEF(first, second, ref c);
                        if (c > 0)
                        {
                            Console.WriteLine(DEF(first, second, ref c));
                        }
                        else
                        {
                            Console.WriteLine(DEF(first, second, ref c));

                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("The Value You Enter NOT Numeric");
                    }

                }
                if (Op == "C"|| Op == "c")
                {
                    Console.Clear();
                }



                Console.WriteLine("Choose The Operation ");
                Console.WriteLine("Enter 1 for Summation ");
                Console.WriteLine("Enter 2 for Difference ");
                Console.WriteLine("Enter C for Clean ");
                Console.WriteLine("Enter # for Exit ");
                
                Op = Console.ReadLine();
            }
            Console.WriteLine("------------ GOOD BYE ------------ ");



        }

        public static string SUM(decimal a, decimal b, ref int c)
        {
            string FG = Convert.ToString(a);
            FG = FG.Substring(0, FG.IndexOf("."));
            string SG = Convert.ToString(a);
            SG = SG.Substring(SG.IndexOf(".") + 1);
            //  Console.WriteLine(Convert.ToDouble(FG) + 1 + "" + SG);

            ////////////////////////////////////////
            string FFG = Convert.ToString(b);
            FFG = FFG.Substring(0, FFG.IndexOf("."));
            string SSG = Convert.ToString(b);
            SSG = SSG.Substring(SSG.IndexOf(".") + 1);
            // Console.WriteLine(FFG + "" + SSG);

            if (SG.Length > SSG.Length)
            {
                int len = SG.Length - SSG.Length;
                for (int i = 0; i < len; i++)
                {
                    SSG = SSG + 0;
                }


            }
            else if (SG.Length == SSG.Length)
            {



            }
            else
            {

                int len = SSG.Length - SG.Length;
                for (int i = 0; i < len; i++)
                {
                    SG = SG + 0;
                }

            }
            a = Convert.ToDecimal(SG);
            b = Convert.ToDecimal(SSG);
            decimal tempsum = a + b;
            int B = Convert.ToInt32(FG) + Convert.ToInt32(FFG);
            if (tempsum.ToString().Length > SSG.Length)
            {
                c++;

                return B.ToString() + "." + tempsum.ToString();
            }
            else
            {
                return B.ToString() + "." + tempsum.ToString();
            }

        }
        public static string DEF(decimal a, decimal b, ref int c)
        {
            string FG = Convert.ToString(a);
            FG = FG.Substring(0, FG.IndexOf("."));
            string SG = Convert.ToString(a);
            SG = SG.Substring(SG.IndexOf(".") + 1);
            // Console.WriteLine(Convert.ToDouble(FG) + 1 + "" + SG);

            ////////////////////////////////////////
            string FFG = Convert.ToString(b);
            FFG = FFG.Substring(0, FFG.IndexOf("."));
            string SSG = Convert.ToString(b);
            SSG = SSG.Substring(SSG.IndexOf(".") + 1);
            //    Console.WriteLine(FFG + "" + SSG);

            if (SG.Length > SSG.Length)
            {
                int len = SG.Length - SSG.Length;
                for (int i = 0; i < len; i++)
                {
                    SSG = SSG + 0;
                }


            }
            else if (SG.Length == SSG.Length)
            {



            }
            else
            {

                int len = SSG.Length - SG.Length;
                for (int i = 0; i < len; i++)
                {
                    SG = SG + 0;
                }

            }
            a = Convert.ToDecimal(SG);
            b = Convert.ToDecimal(SSG);
            //  double tempsum = a - b;
            int B = Convert.ToInt32(FG) - Convert.ToInt32(FFG);
            if (a >= b)
            {
                decimal tempsum = a - b;

                return B.ToString() + "." + tempsum.ToString();
            }
            else
            {
                decimal tempsum = b - a;
                return B.ToString() + "." + tempsum.ToString();
            }

        }

        /*public static decimal x(int a, int b)

        {
            string FG = Convert.ToString(a);
            string SG = Convert.ToString(b);
            Console.WriteLine(FG + "" + SG);
            return 2.5;
        }*/



    }
}
