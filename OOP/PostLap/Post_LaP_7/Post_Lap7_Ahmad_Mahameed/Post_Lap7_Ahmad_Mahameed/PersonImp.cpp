#include "Person.h"
	Person::Person()
	{
		 fName="";
		 lName ="";
		 age =0;
	
	}
	Person::~Person()
	{
	cout<<"This is the Person Destructor"<<endl;
	}
	void Person:: print()
	{
	cout<<fName<<" "<<lName<<" "<<age<<" years old "<<endl;
	}
	void Person:: setInfo (string a, string b, int c)
	{
		fName=a;
		 lName =b;
		 age =c;
	
	}