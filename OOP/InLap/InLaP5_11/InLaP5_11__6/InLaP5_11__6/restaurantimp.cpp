#include <iostream>
#include <string>
#include "restaurant.h"
using namespace std;
rest::rest()
{
	length=0;

}
	void rest:: insert(string t,double r)
	{
		if(length!=0)
	{
		for(int i=0;i<4;i++)
		
		{
			cout<<"please enter the name and the price for meal # "<<i<<endl;
			cin>>t;
			cout <<"  " ;
			cin>>r;
			cout<<t<<"\t"<<r<<endl;
		
		}
		
		}
		else 
			cout << " this is full " <<endl;
		
		
	}
	void rest:: printallmeals()
	{
		cout<<"******************************************"<<endl;
		cout<<"Meal \t \t price "<<endl;
		cout<<"-------------------------"<<endl;
	if (length!=0)
	{
		for(int i = 0 ; i<4;i++)
		{
			cout<<meal[i].name<<"\t"<<meal[i].price<<endl;
		
		}

	}
		else
	cout<<"can't print bec is full"<<endl;
	cout<<"Enter a price that you want to ccount  the number of all meals that have  perices less than it ";
	}
	int rest ::countalllessthan(double a)
	{
	int count=0;
		for (int i=0;i<4;i++)
		{
			if(meal[i].price<a)
				count ++;
		}
		return count;
		
	
	}
	void rest ::riseofprices(double b)
	{
	for (int i=0;i<4;i++)
	{
		cout<<meal[i].name<<meal[i].price+b<<endl;
	
	}
		
	
	}
	rest ::~rest()
	{
	cout<<"goood bye...."<<endl;
	}
