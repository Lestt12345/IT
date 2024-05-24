#include <iostream>
#include <windows.h>
using namespace std;

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int number;
//	cout << "Введіть шестизначне число: ";
//	cin >> number;
//	int d1 = number / 100000 % 10;
//	int d2 = number / 10000 % 10;
//	int d3 = number / 1000 % 10;
//	int d4 = number / 100 % 10;
//	int d5 = number / 10 % 10;
//	int d6 = number % 10;
//	if (number < 100000 || number > 999999) {
//		cout << "Число не є шестизначним";
//	}
//	else if (d1 + d2 + d3 == d4 + d5 + d6) {
//		cout << "Число щасливе";
//	}
//	else {
//		cout << "Число не щасливе";
//	}
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int number;
//	cout << "Введіть чотиризначне число: ";
//	cin >> number;
//	if (number < 1000 || number > 9999) {
//		cout << "Число не є чотиризначним";
//	}
//	int d1 = number / 1000 % 10;
//	int d2 = number / 100 % 10;
//	int d3 = number / 10 % 10;
//	int d4 = number % 10;
//	int newNumb = d2 * 1000 + d1 * 100 + d4 * 10 + d3;
//	cout << newNumb;
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//    int number;
//    int maxNumber;
//    for (int i = 0; i < 7; ++i) {
//        cout << "Введіть " << i + 1 << " число: ";
//        cin >> number;
//        if (i==0)
//        {
//            maxNumber = number;
//        }
//        if (number > maxNumber) {
//            maxNumber = number;
//        }
//    }
//    cout << "Максимальне число: " << maxNumber;
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//    int distance_a_b, distance_b_c, cargo_weight, fuel_perKm, fuel = 300;
//    cout << "Введіть відстань між пунктами А і В (км): ";
//    cin >> distance_a_b;
//    cout << "Введіть відстань між пунктами В і С (км): ";
//    cin >> distance_b_c;
//    cout << "Введіть вагу вантажу (кг): ";
//    cin >> cargo_weight;
//    if (cargo_weight <= 500) {
//        fuel_perKm = 1;
//    }
//    else if (cargo_weight <= 1000) {
//        fuel_perKm = 4;
//    }
//    else if (cargo_weight <= 1500) {
//        fuel_perKm = 7;
//    }
//    else if (cargo_weight <= 2000) {
//        fuel_perKm = 9;
//    }
//    else {
//        cout << "Літак не може підняти вантаж вагою понад 2000 кг";
//    }
//    if (cargo_weight <= 2000)
//    {
//        fuel -= distance_a_b * fuel_perKm;
//        if (fuel>0)
//        {
//            if (distance_b_c * fuel_perKm<300)
//            {
//                if (distance_b_c * fuel_perKm < fuel || distance_b_c * fuel_perKm - fuel == 0)
//                {
//                    cout << "Дозаправка не потрібна";
//                }
//                else
//                {
//                    cout << "Потрібно дозаправити: " << distance_b_c * fuel_perKm - fuel << "л палива";
//                }
//            }
//            else
//            {
//                cout << "Літак не долетить до пункту C";
//            }
//        }
//        else
//        {
//            cout << "Літак не долетить до пункту B";
//        }
//    }
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	double pr[10];
//	for (int i=0; i < 10; i++) {
//		pr[i] = rand() % 100;
//	}
//	cout << "Не зтиснутий:";
//	for (int i = 0; i < 10; i++) {
//		cout << " " << pr[i];
//	}
//	for (int i = 0; i < 10; i++) {
//		if (pr[i]==0)
//		{
//			pr[i] = -1;
//		}
//	}
//	cout << endl;
//	cout << "Зтиснутий:";
//	for (int i = 0; i < 10; i++) {
//		if (pr[i] > 0)
//		{
//			cout << " " << pr[i];
//		}
//	}
//	cout << " ";
//	for (int i = 0; i < 10; i++) {
//		if (pr[i] < 0)
//		{
//			cout << " " << pr[i];
//		}
//	}
//}

//void pryam(int n, int k) {
//	cout << "Введіть висоту: ";
//	cin >> n;
//	cout << "Введіть ширину: ";
//	cin >> k;
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < k; j++)
//		{
//			cout << "* ";
//		}
//		cout << endl;
//	}
//}
//
//int fact(int a) {
//	int sum = 1;
//	for (int i = 1; i <= a; i++) {
//		sum *= i;
//	}
//	return sum;
//}
//
//bool isPrst(int number) {
//	if (number <= 1) {
//		return false;
//	}
//
//	for (int i = 2; i * i <= number; ++i) {
//		if (number % i == 0) {
//			return false;
//		}
//	}
//
//	return true;
//}
//
//#define kub(c) (c*c*c)
//
//int max_Numb(int num1, int num2) {
//	if (num1 > num2) {
//		return num1;
//	}
//	else {
//		return num2;
//	}
//}
//
//string chek_znak(int e) {
//	if (e > 0) {
//		return "Число додатне";
//	}
//	else if (e < 0) {
//		return "Число від`ємне";
//	}
//	else {
//		return "Число дорівнює нулю";
//	}
//}
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	//1
//	pryam(1,2);
//	//2
//	int a;
//	cout << "Введіть число: ";
//	cin >> a;
//	cout << "Факторіал числа: " << fact(a) << endl;
//	//3
//	int b;
//	cout << "Введіть число: ";
//	cin >> b;
//	if (isPrst(b))
//	{
//		cout << "Число просте";
//	}
//	else
//	{
//		cout << "Число не просте";
//	}
//	//4
//	int c;
//	cout << "Введіть число: ";
//	cin >> c;
//	cout << kub(c);
//	//5
//	int num1, num2;
//	cout << "Введіть перше число: ";
//	cin >> num1;
//	cout << "Введіть друге число: ";
//	cin >> num2;
//	cout << max_Numb(num1, num2);
//	int e;
//	cout << "Введіть число: ";
//	cin >> e;
//	cout << chek_znak(e);
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	srand(time(NULL));
////1
//	/*int** arr;
//	int r = 0;
//	int s = 0;
//	cout << "Впишіть число рядків і стовпців: ";
//	cin >> r >> s;
//	arr = (int**)malloc(r * sizeof(int*));
//	for (int i = 0; i < r; i++)
//	{
//		arr[i] = (int*)malloc(s * sizeof(int));
//	}
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			arr[i][j] = rand() % 10;
//		}
//	}
//	cout << "Без змін: ";
//	cout << "\n";
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			cout << arr[i][j] << " ";
//		}
//		cout << "\n";
//	}
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			if (arr[i][j] == 0)
//			{
//				delete arr[i];
//			}
//		}
//	}
//	cout << endl;
//	bool skip = false;
//	cout << "Без нулів: ";
//	cout << "\n";
//	for (int i = 0; i < r; i++)
//	{
//		skip = false;
//		for (int j = 0; j < s; j++)
//		{
//			if (arr[i][j] < 0)
//			{
//				skip = true;
//				continue;
//			}
//			cout << arr[i][j] << " ";
//		}
//		if (skip)
//		{
//			continue;
//		}
//		cout << "\n";
//	}*/
////2
//	/*int** arr_f;
//	int** arr_s;
//	int** arr_th;
//	int r, s;
//
//
//	cout << "Впишіть число рядків і стовпців массиву: ";
//	cin >> r >> s;
//
//
//	arr_f = (int**)malloc(r * sizeof(int*));
//	for (int i = 0; i < r; i++)
//	{
//		arr_f[i] = (int*)malloc(s * sizeof(int));
//	}
//
//	arr_s = (int**)malloc(r * sizeof(int*));
//	for (int i = 0; i < r; i++)
//	{
//		arr_s[i] = (int*)malloc(s * sizeof(int));
//	}
//
//	arr_th = (int**)malloc(r * sizeof(int*));
//	for (int i = 0; i < r; i++)
//	{
//		arr_th[i] = (int*)malloc(s * sizeof(int));
//	}
//
//
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			arr_f[i][j] = rand() % 10;
//		}
//	}
//
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			arr_s[i][j] = rand() % 10;
//		}
//	}
//
//
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			arr_th[i][j] = arr_f[i][j] + arr_s[i][j];
//		}
//	}
//
//
//	cout << "Перший массив: ";
//	cout << "\n";
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			cout << arr_f[i][j] << " ";
//		}
//		cout << "\n";
//	}
//
//	cout << "Другий массив: ";
//	cout << "\n";
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			cout << arr_s[i][j] << " ";
//		}
//		cout << "\n";
//	}
//
//	cout << "Сума массивів: ";
//	cout << "\n";
//	for (int i = 0; i < r; i++)
//	{
//		for (int j = 0; j < s; j++)
//		{
//			cout << arr_th[i][j] << " ";
//		}
//		cout << "\n";
//	}*/
////3
//	/*int** arr_f;
//	int** arr_s;
//	int** arr_th;
//	int n, m, b, k;
//
//
//	cout << "Впишіть число рядків і стовпців массиву: ";
//	cin >> n >> m;
//	cout << "Впишіть число рядків і стовпців массиву: ";
//	cin >> b >> k;
//
//
//	if (n!=k || m!=b)
//	{
//		cout << "\noops...   Error :(\nЧисло рядків першого массиву повинно дорівнювати числу стовпців другого массиву,\nа число стовпців першого массиву повинно дорівнювати числу рядків другого массиву.\n\n";
//		return NULL;
//	}
//
//
//	arr_f = (int**)malloc(n * sizeof(int*));
//	for (int i = 0; i < n; i++)
//	{
//		arr_f[i] = (int*)malloc(m * sizeof(int));
//	}
//
//	arr_s = (int**)malloc(b * sizeof(int*));
//	for (int i = 0; i < b; i++)
//	{
//		arr_s[i] = (int*)malloc(k * sizeof(int));
//	}
//
//	arr_th = (int**)malloc(n * sizeof(int*));
//	for (int i = 0; i < n; i++)
//	{
//		arr_th[i] = (int*)malloc(k * sizeof(int));
//	}
//
//
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < m; j++)
//		{
//			arr_f[i][j] = rand() % 10;
//		}
//	}
//
//	for (int i = 0; i < b; i++)
//	{
//		for (int j = 0; j < k; j++)
//		{
//			arr_s[i][j] = rand() % 10;
//		}
//	}
//
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < k; j++)
//		{
//			arr_th[i][j] = 0;
//		}
//	}
//
//
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < k; j++)
//		{
//			for (int c = 0; c < m; c++)
//			{
//				arr_th[i][j] += arr_f[i][c] * arr_s[c][j];
//			}
//		}
//	}
//
//
//	cout << "Перший массив: ";
//	cout << "\n";
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < m; j++)
//		{
//			cout << arr_f[i][j] << " ";
//		}
//		cout << "\n";
//	}
//
//	cout << "Другий массив: ";
//	cout << "\n";
//	for (int i = 0; i < b; i++)
//	{
//		for (int j = 0; j < k; j++)
//		{
//			cout << arr_s[i][j] << " ";
//		}
//		cout << "\n";
//	}
//
//	cout << "Сума массивів: ";
//	cout << "\n";
//	for (int i = 0; i < n; i++)
//	{
//		for (int j = 0; j < k; j++)
//		{
//			cout << arr_th[i][j] << " ";
//		}
//		cout << "\n";
//	}*/
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	//1
//	/*int a, b;
//	cout << "Введіть 2 числа: ";
//	cin >> a >> b;
//	int* q = &a;
//	int* e = &b;
//	if (*q > *e)
//	{
//		cout << "<№1";
//	}
//	else if (*q < *e)
//	{
//		cout << "<№2";
//	}*/
//	//2
//	/*int a;
//	cout << "Введіть число: ";
//	cin >> a;
//	if (a>0)
//	{
//		cout << "Число додатьнє";
//	}
//	else if (a < 0)
//	{
//		cout << "Число відйемне";
//	}*/
//	//3
//	/*int a, b, temp;
//	cout << "Введіть 2 числа: ";
//	cin >> a >> b;
//	cout << "a=" << a << " b=" << b << endl;
//	int* q = &a;
//	int* e = &b;
//	temp = *e;
//	b = *q;
//	a = temp;
//	cout << "a=" << a << " b=" << b;*/
//	//4
//	/*int a, b, choice;
//	cout << "Введіть 2 числа: ";
//	cin >> a >> b;
//	cout << "1 - +\t2 - -\t3 - /\t4 - *" << endl;
//	cin >> choice;
//	int* da = &a;
//	int* db = &b;
//	int* dch = &choice;
//	if (*dch==1)
//	{
//		cout << *da + *db;
//	}
//	else if (*dch == 2)
//	{
//		cout << *da - *db;
//	}
//	else if (*dch == 3)
//	{
//		cout << *da / *db;
//	}
//	else if (*dch == 4)
//	{
//		cout << *da * *db;
//	}*/
//	//5
//	/*srand(time(NULL));
//	int arr[]{ rand() % 20,rand() % 20,rand() % 20,rand() % 20,rand() % 20 };
//	int summ = 0;
//	int* darr = &arr[0];
//	for (int i = 0; i < 5; i++)
//	{
//		cout << arr[i] << " ";
//	}
//	cout << endl;
//	for (int i = 0; i < 5; i++)
//	{
//		*(darr + i) = arr[i];
//		summ += *(darr + i);
//	}
//	cout << summ;*/
//}