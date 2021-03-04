using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Exam
    {
        public enum EXAMTYPE
        {

            _First, _Second, _Final

        }
        public EXAMTYPE Type { get; set; }
        private int _First;
        private int _Second;
        private int _Final;

        public int First
        {
            set
            {
                this._First = value;
            }
            get
            {
                return _First;
            }
        }
        public int Second
        {
            set
            {
                this._Second = value;
            }
            get
            {
                return _Second;
            }
        }
        public int Final
        {
            set
            {
                this._Final = value;
            }
            get
            {
                return _Final;
            }
        }



        public bool score(int mark)
        {
            if (mark >= 0 && mark <= 100)
                return true;
            else
                return false;
        }
        //extra >> because i'm solved the ass before give us enum 
        public bool examType(EXAMTYPE examType)
        {
            if (this.Type == examType)
                return true;
            else
                return false;
        }



        /*public bool examType(EXAMTYPE examType)//NOTE THIS DELETED
        { }*/
    }
}
