#include <iostream>
#include <string>
using namespace std;
class Person
{
	protected :
	string  fName ;
		string lName ;
		int age ;
public :

	Person();
	~Person();
	void print();
	void setInfo (string , string , int );


};