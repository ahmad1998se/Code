#include "Cylinder.h"


void main()
{

	Cylinder c1 ,c2;

	int q;

	int w;

	int o;

	int p;

	cout << "Enter The Radius And The Height Of The Cylinder : ";

	cin >> q >> w;

	c1.SetCylinder(q, w);

	c1.CalculateVolume();

	c1.CalculateSurfaceArea();

	c1.PrintVolume();

	c1.PrintSurfaceArea();

	cout << "Enter The Radius And The Height Of The Cylinder : ";

	cin >>o >>p;

	c2.SetCylinder(o, p);

	c2.CalculateVolume();

	c2.CalculateSurfaceArea();

	cout <<" The Volume of  the cylinder is : " <<c2.GetVolume() << endl;

	cout << " The SurfaceArea of  the cylinder is : "<<c2.GetSurfaceArea() << endl;










}