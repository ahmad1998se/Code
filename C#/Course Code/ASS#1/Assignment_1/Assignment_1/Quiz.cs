using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Quiz
    {
        private int _grade;

        public int grade
        {
            set
            {
                this._grade = value;
            }
            get
            {
                return _grade;
            }


        }


        public bool score(int mark)
        {
            if (mark >= 0 && mark <= 100)
                return true;
            else
                return false;

        }





    }
}
