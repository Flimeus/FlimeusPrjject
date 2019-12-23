#include <iostream>
#include <math.h>
using namespace std;
int main()
{
	float u, x, k, S, eps;
	do
	{
		cout << "x=";
		cin >> x;
		if (x == 0)
			cout << "Incorrect value eps" << endl;

	} while (x == 0);
	do
	{
		cout << "eps=";
		cin >> eps;
		if (eps <= 0 || eps >= 1)
			cout << "Incorrect value eps" << endl;
	} while (eps <= 0 || eps >= 1);

	S = 0.0;
	k = 0;
	u = 1;
	do
	{
		cout << "u" << k << "=" << u << endl;
		S += u;
		k++;
		u *= -pow(x, 2) / (k + 1);

	} while (abs(u) > eps);

	system("pause");
	return 0;
}
