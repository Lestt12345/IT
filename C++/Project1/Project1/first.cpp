#include <iostream>
#include <windows.h>
using namespace std;

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int a;
//	int b;
//	int c;
//	int d;
//	int e;
//	cout << "Введіть першу оцінку: ";
//	cin >> a;
//	cout << "Введіть другу оцінку: ";
//	cin >> b;
//	cout << "Введіть третю оцінку: ";
//	cin >> c;
//	cout << "Введіть четверту оцінку: ";
//	cin >> d;
//	cout << "Введіть п'яту оцінку: ";
//	cin >> e;
//	if ((a+b+c+d+e)/5>=4)
//	{
//		cout << "Ви допущені";
//	}
//	else
//	{
//		cout << "Ви не допущені";
//	}
// }
//
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int a;
//	cout << "Введіть числло: ";
//	cin >> a;
//	if (a%2==0)
//	{
//		a=a*3;
//		cout << a;
//	}
//	else {
//		float b=a/2.0;
//		cout << b;
//	}
//}
//
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	float a;
//	float b;
//	string choice;
//	cout << "Введіть перше числло: ";
//	cin >> a;
//	cout << "Введіть друге числло: ";
//	cin >> b;
//	cout << "Дії: + - / *" << endl << "Оберіть дію: ";
//	cin >> choice;
//	if (choice=="+")
//	{
//		cout << a << "+" << b << "=" << a+b;
//	}
//	else if (choice=="-")
//	{
//		cout << a << "-" << b << "=" << a-b;
//	}
//	else if (choice=="/")
//	{
//		if (b==0)
//		{
//			cout << "На нуль ділити не можна";
//		}
//		else
//		{
//			cout << a << "/" << b << "=" << a/b;
//		}
//	}
//	else if (choice=="*")
//	{
//		cout << a << "*" << b << "=" << a*b;
//	}
//	else
//	{
//		cout << "У переліку немає такої дії";
//	}
//}