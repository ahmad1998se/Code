#include "PriceList.h"

pricelist::pricelist()
{
	cout<<"defualt constractor"<<endl;
}

	pricelist ::~pricelist()
	{
	cout<<"default distractor"<<endl;
	}
	bool pricelist::isEmpty()
	{
	if(length==0)
		return true;
	else
		return false;	
	}
	bool pricelist ::isFull()
	{
	if(length==50)
		return true ;
	else 
	return false;
	}
	void pricelist:: insert (double a)
	{
		if (isFull()==false)
	{
		list [length]=a;
	length++;
	}
	else 
		cout << "error full";
	}
	
	int pricelist:: getLength()
	{
	return length;
	}
	void pricelist:: print()
	{
	
	}
	
	void pricelist:: printAllgreater(double b)
	{
	if (
	}
	double pricelist:: min()
	{
	
	}
	void pricelist:: sum(double &a)
	{
	
	}
	void pricelist:: spilt(pricelist & b, pricelist &c)
	{
	
	}
	double pricelist::getPrice()
	{}