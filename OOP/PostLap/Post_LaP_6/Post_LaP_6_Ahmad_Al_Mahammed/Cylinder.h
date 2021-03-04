
#include "ThreeDShape.h"

class Cylinder : public ThreeDShape
{

private:
	double Radius;
	double Height;
public:
	void SetCylinder(double, double);
	void GetCylinder(double &, double &);
	void CalculateVolume();
	void CalculateSurfaceArea();


};
