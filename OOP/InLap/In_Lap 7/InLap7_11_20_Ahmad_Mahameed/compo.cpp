#include <iostream>
#include <string>
using namespace std;
class Person
{
private :
    string name;
    int age;
  public:
      Person()
	  {
	  name="ALI";
		age=56;
	  
	  }


	 
      void setInfo(string s, int a)
	  {
	  name=s;
	  age=a;
	  }
      void print()
	  {
	  cout<<"the name of person is "<<name<<endl;
	  cout<<"the age of person is " << age << endl;

	  }
~Person()
{
cout<<"destractor of person"<<endl;
}
};



class  Building 
{
private :
    string address;
    int numOfFloors;
    double area;
  public:
      Building()
	  {
 address="xyz-address";
	numOfFloors=4;
	 area=650;
	  }
      void setInfo(string s, int a, double r)
	  {
	   address=s;
	numOfFloors=a;
	 area=r;
	  
	  }

      void print()
	  {
	  cout<<"the address is "<<address<<endl;
	  cout<<"the numOfFloors is "<<numOfFloors<<endl;
	  cout<<"the area is "<<area<<endl;
	  }
	~ Building()
	{
	cout<<"destractor of buliding"<<endl;
	
	}
};

class Restaurant :public Building
{
private :

double restIncome;
string restName ;
protected :
	string empNames[15];
	int empNumber;

public :
	Person owner;
	Restaurant()
	{
	restName="xyz-resurant";
		 restIncome=5000;
		empNumber =0;
	}
	void setInfo(string a,int b ,string s ,int q,double t,double m,string l,int y)
	{
		owner.setInfo(a,b);
		Building::setInfo(s,q,t);
		 restIncome=m;
		restName=l;
		empNumber =0;
	
	}
	void newEmp (string o)
	{

		empNames[empNumber]=o;
		empNumber ++;
	}
	void Print ()
	{
		owner.print();
		Building::print();
		cout<<"restraunt name "<<restName<<endl;
		cout<<"restIncome name "<<restIncome<<endl;
		cout<<"empNumber name "<<empNumber<<endl;
			cout<<"emp name "<<empNames<<endl;

	
	
	
	}
~Restaurant()
{
cout<<"destracot of restraunt " <<endl;

}
};

void main ()
{
	string name ;
	int age ;	
	string address;
	double area ;
	int numof;
	int numpofe;
	string namer;
	double income ;
	Restaurant rest1;
	cout<<"enter Restaurant info "<<endl;
	cout <<"address : ";
		cin>>address;
	cout <<"number of floors : ";
		cin>>numof;
	cout<<"area ";
		cin>>area;
	cout << "name " ;
		cin>>namer;
	cout << "income";
		cin>>income;
	cout <<" owner name ";
		cin>>name;
	cout << "owner age "; 
		cin>>age;
	cout << " enter three emp names ";
	cin>>numpofe;
	rest1.setInfo(name,age,address,numof,area,income,namer,numpofe);
	for (int i=0;i<3;i++)
	{string ss;
		cin>>ss;
		rest1.newEmp(ss);
	}
	
	rest1.owner.print();
	rest1.Building::print();
	rest1.Print();
	cout <<"number of empo"<<numof<<endl;



}