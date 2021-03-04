#include <iostream>
#include <string>
using namespace std;
class University 
{
private :
	string name ;
	string location ;

public :
	University();
	~University();
	void setInfo(string , string );
	string getName();
    string getLocation();



};