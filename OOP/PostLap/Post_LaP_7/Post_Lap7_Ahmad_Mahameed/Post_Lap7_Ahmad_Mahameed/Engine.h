#include "Car.h"

class Engine{ 
int num;   
double speed;  
public: 
Engine() ; //setting the values: 123,344 for num,speed respectively 
void setInfo(int n, double s); 
void print(); 
~Engine();  
}; 