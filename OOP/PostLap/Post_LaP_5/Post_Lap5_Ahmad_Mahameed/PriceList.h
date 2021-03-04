#include <iostream>
#include <string>
using namespace std;
class pricelist
{
private : 
	int length ;
	double list[50];
	double price;
public:
	pricelist();
	~pricelist();
	bool isEmpty();
	bool isFull();
	int getLength();
	void print();
	void insert (double);
	void printAllgreater(double);
	double min();
	void sum(double &);
	void spilt(pricelist & , pricelist &);
	double getPrice()
};
