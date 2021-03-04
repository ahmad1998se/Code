using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Grade : Coursework
    {
        private int _TotalScore;
        private double _Pointgrade;
        private string _Lettergrade;

        public int TotalScore
        {
            set
            {

                _TotalScore = sumA() + sumE() + sumQ();


                /*this._TotalScore =Convert.ToInt16( value);
                
                    while(this._TotalScore > 100 || this._TotalScore < 0)
                    {
                        _TotalScore = Convert.ToInt16(Console.ReadLine());
                        
                    }*/
            }
            // this._TotalScore = value;


            get
            {
                return _TotalScore;
            }


        }

        public double Pointgrade
        {
            set
            {
                this._Pointgrade = value;
            }
            get
            {
                return _Pointgrade;
            }


        }

        public string Lettergrade
        {
            set
            {    /* this._Lettergrade =Convert.ToString(value);
                 if (this._TotalScore > 100 || this._TotalScore < 0)
                 {
                     _Lettergrade = Console.ReadLine();
                 }*/

                if (this._TotalScore >= 0 || this._TotalScore <= 49)
                    _Lettergrade = "F";
                else if (this._TotalScore >= 50 || this._TotalScore <= 52)
                    _Lettergrade = "D-";
                else if (this._TotalScore >= 53 || this._TotalScore <= 56)
                    _Lettergrade = "D";
                else if (this._TotalScore >= 57 || this._TotalScore <= 59)
                    _Lettergrade = "D+";
                else if (this._TotalScore >= 60 || this._TotalScore <= 62)
                    _Lettergrade = "C-";
                else if (this._TotalScore >= 63 || this._TotalScore <= 66)
                    _Lettergrade = "C";
                else if (this._TotalScore >= 67 || this._TotalScore <= 69)
                    _Lettergrade = "C+";
                else if (this._TotalScore >= 70 || this._TotalScore <= 72)
                    _Lettergrade = "B-";
                else if (this._TotalScore >= 73 || this._TotalScore <= 76)
                    _Lettergrade = "B";
                else if (this._TotalScore >= 77 || this._TotalScore <= 79)
                    _Lettergrade = "B+";
                else if (this._TotalScore >= 80 || this._TotalScore <= 84)
                    _Lettergrade = "A-";
                else if (this._TotalScore >= 85 || this._TotalScore <= 94)
                    _Lettergrade = "A";
                else if (this._TotalScore >= 95 || this._TotalScore <= 700)
                    _Lettergrade = "A+";





            }
            get
            {
                return _Lettergrade;

            }


        }

        public int sumA()
        {
            int A = 0;
            for (int i = 0; i < assignment.Length - 1; i++)
            {
                A += assignment[i].grade;
            }
            A = (A / 3) / 100;
            return A;

        }
        public int sumE()
        {
            int E = 0;

            E += exam[0].First % 10;
            E += exam[1].Second % 20;
            E += exam[2].Final % 40;
            return E;



        }
        public int sumQ()
        {
            int Q = 0;
            for (int i = 0; i < quiz.Length - 1; i++)
            {
                Q += quiz[i].grade;

            }
            Q = Q - this.lowestQuiz().grade;
            Q = (Q / 5) / 100;
            return Q;
        }


        /* PROPRETY
         *TotalScore
         *Pointgrade
        *Lettergrade*/
    }
}
