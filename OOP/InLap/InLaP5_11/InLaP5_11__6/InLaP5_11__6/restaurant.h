
#include <iostream>
#include <string>
using namespace std;
struct mealnode
{
string name;
double price;
};

class rest
{
	mealnode meal[10];
	int length;
public :
	rest();
	void insert(string,double);
	void printallmeals();
	int countalllessthan(double);
	void riseofprices(double);
	~rest();

};