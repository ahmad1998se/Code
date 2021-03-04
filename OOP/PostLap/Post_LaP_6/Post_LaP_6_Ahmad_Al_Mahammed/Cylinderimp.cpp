#include "Cylinder.h"

const double  Pi = 3.14;

void Cylinder:: SetCylinder(double b, double n)
{
	Radius = b;
	Height = n;

}
void Cylinder :: GetCylinder(double & d, double & f)
{
	d = Radius;
	f = Height;

}
void Cylinder::CalculateVolume()
{
	double cv;

	cv = Pi * (Radius * Radius)* Height;

	ThreeDShape::SetVolume(cv);
}
void Cylinder:: CalculateSurfaceArea()
{
	double csa;

	csa = 2 * Pi * (Radius * Radius) + 2 * Pi * Radius * Height;
	ThreeDShape::SetSurfaceArea(csa);

}