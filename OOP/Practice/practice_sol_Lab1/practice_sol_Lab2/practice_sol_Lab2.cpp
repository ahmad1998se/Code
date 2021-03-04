#include<iostream>
#include<string>
using namespace std;
struct course
{ string name;
 int id, grade;
};
struct student
{ string fName,lName;
  course course_list[4];

};

void read(student &s)
{
	cout<<"Enter the first name"<<endl;
	cin>>s.fName;
	cout<<"Enter the Last name"<<endl;
	cin>>s.lName;
	cout<<"courses Info"<<endl;
	for(int i=0;i<4;i++)
	{  cout<<"Enter the course name"<<endl;
	cin>>s.course_list[i].name;
	cout<<"Enter The course id"<<endl;
	cin>>s.course_list[i].id;
	cout<<"Enter the Grade"<<endl;
	cin>>s.course_list[i].grade;
	if(s.course_list[i].grade<35)
		s.course_list[i].grade=35;
	else if(s.course_list[i].grade>100)
		s.course_list[i].grade=100;
	
	}


}
double get_Avg(student s)
{ double sum=0;
 for(int i=0;i<4;i++)
 {
	 sum+=s.course_list[i].grade;
 }
 return sum/4;
}

void print(student s)
{
	cout<<"First name is "<<s.fName<<endl;
	cout<<"Last name is "<<s.lName<<endl;
	cout<<"The average is "<<get_Avg(s)<<endl;
}
void main()
{ student s;
  read(s);
  print(s);

}