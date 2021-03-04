#include <iostream>
using namespace std;
class vehicle 
{  
private: 
    int wheels; 
    double price; 
    string color; 
public: 
    vehicle();  // setting the values: Black,4,5000 for color,wheels,and price respectively  
    void setInfo(int,double,string); 
    void print();// print the values of the data member  
    ~vehicle(); 
}; 