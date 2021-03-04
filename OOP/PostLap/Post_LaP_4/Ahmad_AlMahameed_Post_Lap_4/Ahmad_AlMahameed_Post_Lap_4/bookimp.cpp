#include "book.h"
void book:: setall(string a,string b ,string c,string d)
{
	name=a;
	isbn=b;
	ainfo.name=c;	
	ainfo.id=d;
}
	string book:: getisbn()const
	{
	return isbn;
	}
	string book:: getauthorid()const
	{
		return ainfo.id;
	}
	void book::print()const
	{		
	cout<<"book name :  "<<name<<endl;
	cout<<"book isbn :  "<<isbn<<endl;
	cout<<"author name :  "<<ainfo.name<<endl;
	cout<<"author id :  "<<ainfo.id<<endl;
	
	}
	bool book::compare(const book &w)const
	{
		if(name==w.name && isbn ==w.isbn && ainfo.name ==w.ainfo.name &&ainfo.id== w.ainfo.id)
	  return true ;
	}
	bool compare(const book &a , const book &b)
	{
		if (a.getisbn()==b.getisbn()&& a.getauthorid()==b.getauthorid())
		return true;
	}
	book getbookbyisbn(book t[],string is)
	{
	int u;
	for (int i=0;i<3;i++)
	{
	if (t[i].getisbn()==is)
		u=i;	}
		return t[u] ;
	
	}