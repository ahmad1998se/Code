using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POST_LAP_2
{
    class TelephoneNumberWordGenerator
    {
        private int Sevendigit;      
        private List<string> sevenletter=new List<string>();
       // private List<string> seven_LetterWord;

        public List<string> Seven_LetterWord { get => sevenletter; }

        public Boolean ReadSevenDigit(int seven_digit)
        {
            string number = seven_digit.ToString();

            Boolean t =false;
            if (number.Length == 7)
            {
                t = true;
                for (int i = 0; i < number.Length; i++)
                {
                    if ( (Int32.Parse(number[i].ToString()) > 1 && Int32.Parse(number[i].ToString()) < 10) && t == true )
                    {
                        t = true;
                    }
                    else
                    {
                        t = false;
                        break;
                    }

                }
            }

            if (t == true)
            {
                Sevendigit = seven_digit;
                return true;
            }
            else
                return false;
        }
        public void GenerateSevenLetterWords()
        {
            //if (ReadSevenDigit(Sevendigit) == true)
           // {


                string[][] comp ={
              new string[] { "Nothing"},
              new string[] { "Nothing"},
            new string[] { "A","B","c"},
            new string[] { "D","E","F"},
            new string[] { "G","H","I"},
            new string[] { "J","K","L"},
            new string[] { "M","N","O"},
            new string[] { "P","Q","R","S"},
            new string[] { "T","U","V"},
            new string[] { "W","X","Y","Z"}, };
                string number = Sevendigit.ToString();

                var q = from x1 in comp[Int32.Parse(number[0].ToString())]
                        from x2 in comp[Int32.Parse(number[1].ToString())]
                        from x3 in comp[Int32.Parse(number[2].ToString())]
                        from x4 in comp[Int32.Parse(number[3].ToString())]
                        from x5 in comp[Int32.Parse(number[4].ToString())]
                        from x6 in comp[Int32.Parse(number[5].ToString())]
                        from x7 in comp[Int32.Parse(number[6].ToString())]

                        select new { x1, x2, x3, x4, x5, x6, x7 };

           
            foreach (var item in q.ToList())
                {
                    string xx = (item.x1 + item.x2 + item.x3 + item.x4 + item.x5 + item.x6 + item.x7);
                    sevenletter.Add(xx);
               
                }

            


        }
        public String ShowListOfWords()
        {

            GenerateSevenLetterWords();
            string result = "The Possible Word :";
            foreach (var item in Seven_LetterWord)
            {
                result += item+ Environment.NewLine;
                
            }
            return result;
        }





    }
}
