#include "University.h"
#include "Person.h"

#include <iostream>
using namespace std;

class Student : public Person
{
private :
	string id;
    double GPA ;
	University uni;
public :
	Student(string a,string  b, int c, string d, string e, string f, double g);
	Student();
	~Student();
	void setInfo (string fName,string  sName, int age, string name, string location, string id, double GPA );
	void print ();



};