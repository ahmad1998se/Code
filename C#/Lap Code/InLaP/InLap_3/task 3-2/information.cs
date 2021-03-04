using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_2
{
    public enum persontype { Male, Female };
    public enum edutype { Medicine, Nursing, Dentistry };
    public enum ranktype { Pass, Good, VeryGood, Excellent };
    class information:IComparable
    {
        public int CompareTo(object A)
        {
            
                if(A is information)
            {
                information temp = (information)A;
                return this.scores.CompareTo(temp.scores);
            }
                else
            throw new Exception("Not INFO");

        }

        private string SSN;
        private string FullName;        private persontype Gender;
        private edutype Education;
       private ranktype Rank ;
       private int Graduation_Year;
            private int Year_of_Experiance;
         public int Scores;

        public string SSN1 { get => SSN; set => SSN = value; }
        public string FullName1 { get => FullName; set => FullName = value; }
        public persontype Gender1 { get => Gender; set => Gender = value; }
        public edutype Education1 { get => Education; set => Education = value; }
        public ranktype Rank1 { get => Rank; set => Rank = value; }
        public int Graduation_Year1 { get => Graduation_Year; set => Graduation_Year = value; }
        public int Year_of_Experiance1 { get => Year_of_Experiance; set => Year_of_Experiance = value; }
        public int scores
        {
            get { int sum = 0;
                if (Rank == ranktype.Pass)
                    sum += 4;
               else  if (Rank == ranktype.Good)
                    sum += 6;
                else if (Rank == ranktype.VeryGood)
                    sum += 8;
                else if (Rank == ranktype.Excellent)
                    sum += 12;

                if (Year_of_Experiance <= 12 && Year_of_Experiance > 0)
                    sum += Year_of_Experiance;
                else
                    sum += 12;

                if ((DateTime.Now.Year - Graduation_Year) <= 6)
                    sum += (DateTime.Now.Year - Graduation_Year);
                else
                    sum += 6;

                return sum;
            }

        }







    }
}
