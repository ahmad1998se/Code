#include "Student.h"
	Student::Student(string a,string  b, int c, string d, string e, string f, double g)
	{
	Person::setInfo(a,b,c);
	uni.setInfo(d,e);
	id=f;
	GPA=g;
	}
	Student::Student()
	{
		 id="";
         GPA =0;
	}
	Student::~Student()
	{
	cout<<"This is the Student Destructor" <<endl;
	}
	void Student:: setInfo (string a,string  b, int c, string d, string e, string f, double g )
	{
	Person::setInfo(a,b,c);
	uni.setInfo(d,e);
	id=f;
	GPA=g;
	}
	void Student:: print ()
	{
        cout <<"The student ";
	    Person::print();
		cout <<"The University : "<<uni.getName()<<" " <<uni.getLocation()<<endl;
		cout<<"Student Id : "<<id<<endl;
		cout<<"Student GPA : "<<GPA<<endl;
	}