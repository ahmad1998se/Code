
#include <iostream>
using namespace std;
 #include <cstdlib> 

class A
{
public :
	int y;
	int list[5];

};
void main()
{
	int *p1 , *p3;
	int  *p2[5];
 A Obj;
 A *pObj;
 Obj.y=5;
 for (int i=0;i<5;i++)
 Obj.list[i]=rand() %100;
 pObj=&Obj;
 Obj.y=5;//same line in question d and y 
 p1=&(*pObj).y;
 p3=pObj->list;
 for (int j=0;j<5;j++)
 p2[j]=&pObj->list[j];
 ///////////////////////////////////////////////////////////////
 cout<<" P1 Information "<<endl;
 cout<<" -----------------------------------------------------------------------------------------------"<<endl;
 cout << " The Address Of The Pointer :	"<<&p1<<endl;
 cout <<" The Content Of The Pointer : "<<p1<<endl;
 cout <<" The Content Of Where This Pointer Points : "<<*p1<<endl<<endl;
 cout<<" ***********************************************************************************************"<<endl;
 cout << " P2 Information ( Array Pointer ):"<<endl;
 cout<<" -----------------------------------------------------------------------------------------------"<<endl;
 cout << " The Address Of The Pointer :	"<<&p2<<endl;
 cout <<" The Content Of The Pointer : "<<p2<<endl;
 cout <<" The Content Of Where This Pointer Points : "<<endl<<endl;
 cout <<" Element Number \tContent \tAddress"<<endl;
 cout<<" -----------------------------------------------------------------------------------------------"<<endl;
 for (int p=0;p<5;p++)
 cout <<" P2["<<p<<"]"<<"\t\t\t"<<*p2[p]<<"\t"<<&p2[p]<<endl<<endl;
 cout<<" ***********************************************************************************************"<<endl;
 cout<<" P3 Information "<<endl;
 cout<<"------------------------------------------------------------------------------------------------"<<endl;
  cout << " The Address Of The Pointer :	"<<&p3<<endl;
 cout <<" The Content Of The Pointer : "<<p3<<endl;
 cout <<" The Content Of Where This Pointer Points : "<<*p3<<endl;
 delete p1;
 delete [] p2;
 delete p3;
}
//Ahmad_Hani_Al_Mahameed
