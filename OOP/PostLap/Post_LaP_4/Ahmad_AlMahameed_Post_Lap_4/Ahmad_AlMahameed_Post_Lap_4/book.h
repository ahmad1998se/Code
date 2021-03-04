#include <iostream>
#include <string>
using namespace std;

struct authorinfo
{
	string name ;
	string id;

};
class book
{
private :
	string name ;
	string isbn;
	authorinfo ainfo;
public :
	void setall(string,string,string,string);
	string getisbn()const;
	string getauthorid()const;
	void print()const;
	bool compare(const book &)const;

	
};
	book getbookbyisbn(book t[],string is);
	bool compare(const book &a , const book &b);