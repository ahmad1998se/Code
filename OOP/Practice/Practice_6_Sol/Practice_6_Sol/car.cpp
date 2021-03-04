#include <iostream>
using namespace std;
#include <string>
 static int vcount;
	class vehicle
{ 
private:
    int wheels;
    double price;
    string color;
public:
	
     vehicle()
	 {
	 wheels=4;
		 price=1200;
	 color="Black";
	 }
	 vehicle(int w,double p, string c)
	 {
	wheels=w;
	price=p;
	 color=c;
	 
	 }
     void initialize(int w,double p, string c)
	 {
	 wheels=w;
	price=p;
	 color=c;
	 
	 }
	 void print()
	 {
	 cout<<"number of wheels "<<wheels<<endl;
	 cout<<"The color of vehicle is " <<color<<endl;
	 cout<<"The price of vehicle is " << price<<endl;
	 
	 }
     static void incrementCount()
	 {
	 
	 vcount++;
	 }
     ~vehicle()
	 {
	 	cout<<"End of vehicle object"<<endl;
	 
	 }
};
//*******************************************************************
class car : public vehicle
{private:
    int load;
    double weight;
public:	
    car()
	{
	load=4;
	weight=1200;
	options=0;
	vcount++;
	}
    car(int w, double p, string c, int l, double cw):vehicle(w,p,c)
	{
	load=l;
    weight=cw;
	vcount++;
	}
    void initialize(int w, double p, string c, int l, double cw)
	{vehicle::initialize(w,p,c);
	load=l;
    weight=cw;
	}
    int options;
     string optionsList[50];
     void addOption(string p)
	 {
	 optionsList[options]=p;
	 options++;
	 }
    void print()
	{
		vehicle::print();	
		cout<<"Load of car is "<<load<<endl;
		cout<<"whight is "<<weight<<endl;
		cout<<"Option of car "<<endl;
		cout<<"Number of option are "<<options<<endl;
		for(int i=0;i<options;i++)
		cout<<"options "<<i+1<<" is "<<optionsList[i]<<endl;	
		
	
	}
    ~car()

	{
	cout<<"End of car object"<<endl;
	}
  };
void main()
{
car c1 ;
c1.initialize(4,1500,"Black",4,125);
c1.addOption("GPS");
c1.addOption("turbo");
car c2;
c2.initialize(6,25000,"Red",12,500);
c2.print();
cout<<"******************************************************"<<endl;
c1.print();
cout<<"&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&"<<endl;
cout<<"Number of vehicle are "<<vcount<<endl;

}


