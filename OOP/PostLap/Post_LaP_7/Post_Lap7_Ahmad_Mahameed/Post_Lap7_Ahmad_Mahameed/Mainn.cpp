#include "Student.h"
void main()
{
	

	string first,last,uniName,uniLoc,id; 
int age; 
double gpa; 
cout<<"Enter the needed information for the new student: "<<endl; 
cout<<"First Name: "; 
cin>>first; 
cout<<"Last Name: "; 
cin>>last; 
cout<<"Student age: "; 
cin>>age; 
cout<<"University name: "; 
cin>>uniName; 
cout<<"University location: "; 
cin>>uniLoc; 
cout<<"Student ID: "; 
cin>>id; 
cout<<"Student GPA: "; 
cin>>gpa; 
cout<<"\n\n\n"; 
 
Student s1(first,last,age,uniName,uniLoc,id,gpa); 
s1.print(); 
cout<<"\n\n\n"; 

}