#include"book.h"
void main ()
{
	book blist[3];
	book o;
	int counter=1;
	string a , b ,c , d;
	cout<<"reading book information :"<<endl;
	for(int i=0;i<3;i++)
	{
    
	 cout<<"Enter book name of bbok number:  "<<counter<<endl;
		cin>>a;
	cout<<"Enter book isbn of bbok number:  "<<counter<<endl;
		cin>>b;
	cout<<"Enter book author name of bbok number:  "<<counter<<endl;
		cin>>c;
	cout<<"Enter book author id of bbok number:  "<<counter<<endl;
		cin>>d;
		 blist[i].setall(a,b,c,d);
		 counter++;
	}

	o=getbookbyisbn(blist,"isbn_12_123");
	
	o.print();

	if(blist[0].compare(blist[1]))
		cout<<"are equals"<<endl;
	else
    cout<<"are not equals"<<endl;
	

	if(compare(blist[1],blist[2]))
		cout<<"are equals"<<endl;
	else
    cout<<"are not equals"<<endl;
	
	system ("pause");
}