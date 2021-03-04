
#include "ThreeDShape.h"

void ThreeDShape:: SetVolume(double a)
{
	Volume = a;

}

double ThreeDShape:: GetVolume()
{
	return Volume;
}

void ThreeDShape:: SetSurfaceArea(double b)
{
	SurfaceArea = b;
}

double ThreeDShape:: GetSurfaceArea()
{
	return SurfaceArea;

}

void ThreeDShape:: PrintVolume()
{
	cout << " The Volume of  the cylinder is : "<<Volume<<endl;
}

void ThreeDShape:: PrintSurfaceArea()
{
	cout << " The SurfaceArea of  the cylinder is : "<<SurfaceArea<<endl;

}