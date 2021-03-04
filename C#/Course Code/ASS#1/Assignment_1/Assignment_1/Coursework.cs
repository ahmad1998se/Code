using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Coursework
    {
        //feild
        //property
        //funcation
        protected Assignment[] assignment = new Assignment[4];
        protected Quiz[] quiz = new Quiz[6];
        protected Exam[] exam = new Exam[3];
        Grade gr = new Grade();







        //funcation
        public bool addAssignment(Assignment[] assignment)//this method return true if the assignment grade is correct, o.w., it returns false
        {
            bool t = false;
            for (int i = 0; i < assignment.Length - 1; i++)
            {
                if (assignment[i].score(assignment[i].grade) != false)
                    t = true;

            }
            if (t == true)
                return true;
            else
                return false;
        }
        public bool addQuiz(Quiz[] quiz)
        {
            bool t = false;
            for (int i = 0; i < quiz.Length - 1; i++)
            {
                if (quiz[i].score(quiz[i].grade) != false)
                    t = true;

            }
            if (t == true)
                return true;
            else
                return false;

        }
        public bool addExam(Exam[] exam)
        {
            bool t = false;
            for (int i = 0; i < exam.Length - 1; i++)
            {
                if (exam[i].score(exam[i].First) != false && exam[i].score(exam[i].Second) != false && exam[i].score(exam[i].Final) != false)
                    t = true;

            }
            if (t == true)
                return true;
            else
                return false;
        }
        public bool calcGrade() // this method calculates the course grade if all coursework items are inserted and returns true, o.w., it returns false
        {
            if (addAssignment(this.assignment) == true && addQuiz(this.quiz) == true && addExam(this.exam) == true)
                return true;
            return false;

        }

        public Grade getGrade() //returns the calculated grade
        {
            /* Grade temp = new Grade();
             temp.TotalScore = sumA() + sumE() + sumQ();
            this.gr = temp;*/
            return this.gr;
            //how return the grade as obj 
        }
        public Quiz lowestQuiz() //returns the lowest Quiz
        {
            Quiz temp = new Quiz();
            temp = quiz[0];
            for (int i = 0; i < quiz.Length - 1; i++)
            {
                if (quiz[i].grade > temp.grade)
                    temp = quiz[i];

            }
            return temp;

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






    }
}
