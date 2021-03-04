#include "University.h"

	University::University()
	{
		name="";
	location="";
	}
	University::~University()
	{
	cout<<"This is the University Destructor" <<endl;
	}
	void University:: setInfo(string a, string b)
	{
	name=a;
	location=b;
	}
	string University:: getName( )
	{
	return name;
	}
	string University:: getLocation()
	{
		return location;
	}