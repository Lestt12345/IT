#include <iostream>
#include <windows.h>
using namespace std;

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int number;
//	cout << "������ ����������� �����: ";
//	cin >> number;
//	int d1 = number / 100000 % 10;
//	int d2 = number / 10000 % 10;
//	int d3 = number / 1000 % 10;
//	int d4 = number / 100 % 10;
//	int d5 = number / 10 % 10;
//	int d6 = number % 10;
//	if (number < 100000 || number > 999999) {
//		cout << "����� �� � ������������";
//	}
//	else if (d1 + d2 + d3 == d4 + d5 + d6) {
//		cout << "����� �������";
//	}
//	else {
//		cout << "����� �� �������";
//	}
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int number;
//	cout << "������ ������������ �����: ";
//	cin >> number;
//	if (number < 1000 || number > 9999) {
//		cout << "����� �� � �������������";
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
//        cout << "������ " << i + 1 << " �����: ";
//        cin >> number;
//        if (i==0)
//        {
//            maxNumber = number;
//        }
//        if (number > maxNumber) {
//            maxNumber = number;
//        }
//    }
//    cout << "����������� �����: " << maxNumber;
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//    int distance_a_b, distance_b_c, cargo_weight, fuel_perKm, fuel = 300;
//    cout << "������ ������� �� �������� � � � (��): ";
//    cin >> distance_a_b;
//    cout << "������ ������� �� �������� � � � (��): ";
//    cin >> distance_b_c;
//    cout << "������ ���� ������� (��): ";
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
//        cout << "˳��� �� ���� ������ ������ ����� ����� 2000 ��";
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
//                    cout << "���������� �� �������";
//                }
//                else
//                {
//                    cout << "������� �����������: " << distance_b_c * fuel_perKm - fuel << "� ������";
//                }
//            }
//            else
//            {
//                cout << "˳��� �� �������� �� ������ C";
//            }
//        }
//        else
//        {
//            cout << "˳��� �� �������� �� ������ B";
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
//	cout << "�� ���������:";
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
//	cout << "���������:";
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
//	cout << "������ ������: ";
//	cin >> n;
//	cout << "������ ������: ";
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
//		return "����� �������";
//	}
//	else if (e < 0) {
//		return "����� ��`����";
//	}
//	else {
//		return "����� ������� ����";
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
//	cout << "������ �����: ";
//	cin >> a;
//	cout << "�������� �����: " << fact(a) << endl;
//	//3
//	int b;
//	cout << "������ �����: ";
//	cin >> b;
//	if (isPrst(b))
//	{
//		cout << "����� ������";
//	}
//	else
//	{
//		cout << "����� �� ������";
//	}
//	//4
//	int c;
//	cout << "������ �����: ";
//	cin >> c;
//	cout << kub(c);
//	//5
//	int num1, num2;
//	cout << "������ ����� �����: ";
//	cin >> num1;
//	cout << "������ ����� �����: ";
//	cin >> num2;
//	cout << max_Numb(num1, num2);
//	int e;
//	cout << "������ �����: ";
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
//	cout << "������� ����� ����� � ��������: ";
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
//	cout << "��� ���: ";
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
//	cout << "��� ����: ";
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
//	cout << "������� ����� ����� � �������� �������: ";
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
//	cout << "������ ������: ";
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
//	cout << "������ ������: ";
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
//	cout << "���� �������: ";
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
//	cout << "������� ����� ����� � �������� �������: ";
//	cin >> n >> m;
//	cout << "������� ����� ����� � �������� �������: ";
//	cin >> b >> k;
//
//
//	if (n!=k || m!=b)
//	{
//		cout << "\noops...   Error :(\n����� ����� ������� ������� ������� ���������� ����� �������� ������� �������,\n� ����� �������� ������� ������� ������� ���������� ����� ����� ������� �������.\n\n";
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
//	cout << "������ ������: ";
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
//	cout << "������ ������: ";
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
//	cout << "���� �������: ";
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
//	cout << "������ 2 �����: ";
//	cin >> a >> b;
//	int* q = &a;
//	int* e = &b;
//	if (*q > *e)
//	{
//		cout << "<�1";
//	}
//	else if (*q < *e)
//	{
//		cout << "<�2";
//	}*/
//	//2
//	/*int a;
//	cout << "������ �����: ";
//	cin >> a;
//	if (a>0)
//	{
//		cout << "����� ��������";
//	}
//	else if (a < 0)
//	{
//		cout << "����� �������";
//	}*/
//	//3
//	/*int a, b, temp;
//	cout << "������ 2 �����: ";
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
//	cout << "������ 2 �����: ";
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

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	/*int year_s, month_s, day_s, year_f, month_f, day_f;
//	int days_total = 0;
//	int help_tool = 0;
//	cout << "������ �����: xxxx xx xx\n\t      0001 01 01 (�� ������� ���� ���������������, � ����� �� ���� ������������.\n\t                  ���� �� ������� ����� �� ������ ���� �� �������)\n\n\t    ��  �. �.\n";
//	cout << "����� ����: ____ __ __\b\b\b\b\b\b\b\b\b\b";
//	cin >> year_s >> month_s >> day_s;
//	cout << "����� ����: ____ __ __\b\b\b\b\b\b\b\b\b\b";
//	cin >> year_f >> month_f >> day_f;
//	if (year_f < year_s)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if (!((year_s % 4 == 0 && year_s % 100 != 0) || (year_s % 400 == 0)) && month_s > 28)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if (((year_s % 4 == 0 && year_s % 100 != 0) || (year_s % 400 == 0)) && month_s > 29)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if ((month_s == 4 || month_s == 6 || month_s == 9 || month_s == 11) && month_s > 30)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if ((month_s == 1 || month_s == 3 || month_s == 5 || month_s == 7 || month_s == 8 || month_s == 10 || month_s == 12) && month_s > 31)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if (!((year_f % 4 == 0 && year_f % 100 != 0) || (year_f % 400 == 0)) && month_f > 28)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if (((year_f % 4 == 0 && year_f % 100 != 0) || (year_f % 400 == 0)) && month_f > 29)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if ((month_f == 4 || month_f == 6 || month_f == 9 || month_f == 11) && month_f > 30)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	if ((month_f == 1 || month_f == 3 || month_f == 5 || month_f == 7 || month_f == 8 || month_f == 10 || month_f == 12) && month_f > 31)
//	{
//		cout << "\nError";
//		return 0;
//	}
//	for (int i = year_s; i < year_f+1; i++)
//	{
//		for (int j = 1; j < 13; j++)
//		{
//			help_tool++;
//			if (help_tool == 1)
//			{
//				j = month_s;
//				if (month_s == month_f && year_s == year_f)
//				{
//					days_total += day_f - day_s;
//					break;
//				}
//				else
//				{
//					j = month_s;
//					if (j == 2)
//					{
//						if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
//						{
//							days_total += 29 - day_s;
//						}
//						else
//						{
//							days_total += 28 - day_s;
//						}
//					}
//					else if (j == 4 || j == 6 || j == 9 || j == 11)
//					{
//						days_total += 30 - day_s;
//					}
//					else
//					{
//						days_total += 31 - day_s;
//					}
//				}
//				continue;
//			}
//			if (i == year_f && j == month_f)
//			{
//				days_total += day_f;
//				break;
//			}
//			if (j == 2)
//			{
//				if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
//				{
//					days_total += 29;
//				}
//				else
//				{
//					days_total += 28;
//				}
//			}
//			else if (j == 4 || j == 6 || j == 9 || j == 11)
//			{
//				days_total += 30;
//			}
//			else
//			{
//				days_total += 31;
//			}
//		}
//	}
//	cout << days_total;*/
//	//2
//	/*float rate1, rate2, rate3,
//		zp1 = 0, zp2 = 0, zp3 = 0;
//	cout << "������ ������ ��� ���������:\n1: ";
//	cin >> rate1;
//	cout << "2: ";
//	cin >> rate2;
//	cout << "3: ";
//	cin >> rate3;
//	if (rate1 < 500)
//	{
//		zp1 += 200 + (rate1 * 0.03);
//	}
//	else if (rate1 >= 500 && rate1 < 1000)
//	{
//		zp1 += 200 + (rate1 * 0.05);
//	}
//	else
//	{
//		zp1 += 200 + (rate1 * 0.08);
//	}
//	if (rate2 < 500)
//	{
//		zp2 += 200 + (rate2 * 0.03);
//	}
//	else if (rate2 >= 500 && rate2 < 1000)
//	{
//		zp2 += 200 + (rate2 * 0.05);
//	}
//	else
//	{
//		zp2 += 200 + (rate2 * 0.08);
//	}
//	if (rate3 < 500)
//	{
//		zp3 += 200 + (rate3 * 0.03);
//	}
//	else if (rate3 >= 500 && rate3 < 1000)
//	{
//		zp3 += 200 + (rate3 * 0.05);
//	}
//	else
//	{
//		zp3 += 200 + (rate3 * 0.08);
//	}
//	cout << "\n�������� ����� ���������:\n1 - " << zp1 << "$\n2 - " << zp2 << "$\n3 - " << zp3 << "$";
//	if (zp1 > zp2 && zp1 > zp3)
//	{
//		cout << "\n\n��������� ��������: Manager 1.\t�� ������ ����� � ����� 200$";
//		zp1 += 200;
//	}
//	else if (zp2 > zp1 && zp2 > zp3)
//	{
//		cout << "\n\n��������� ��������: Manager 2.\t�� ������ ����� � ����� 200$";
//		zp2 += 200;
//	}
//	else
//	{
//		cout << "\n\n��������� ��������: Manager 3.\t�� ������ ����� � ����� 200$";
//		zp3 += 200;
//	}*/
//}

//#include <string>
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	//1
//	/*int count_Same = 0;
//	for (int i = 100; i < 1000; i++)
//	{
//		if (i / 100 == (i / 10) % 10 || i / 100 == i % 10 || (i / 10) % 10 == i % 10)
//		{
//			count_Same++;
//		}
//	}
//	cout << "ʳ������ ����� ����� � �������� �� 100 �� 999, � ���� � �� ������� �����: " << count_Same << endl;
//	//2
//	int count_notSame = 0;
//	for (int i = 100; i < 1000; i++)
//	{
//		if (i / 100 != (i / 10) % 10 && i / 100 != i % 10 && (i / 10) % 10 != i % 10)
//		{
//			count_notSame++;
//		}
//	}
//	cout << "ʳ������ ����� ����� � �������� �� 100 �� 999, � ���� �� ����� ����: " << count_notSame << endl;
//	//3
//	int numb;
//	cout << "������ �����: ";
//	cin >> numb;
//	string str_numb = to_string(numb);
//	for (int i = 0; i < str_numb.length(); i++)
//	{
//		if (str_numb[i] != '3' && str_numb[i] != '6')
//		{
//			cout << str_numb[i];
//		}
//	}
//	cout << endl;
//	//4
//	int a;
//	cout << "������ �����: ";
//	cin >> a;
//	cout << "����� B, ��� ���� A ������� �� B*B � �� ������� �� B*B*B:\n";
//	for (int i = 1; i * i <= a; i++) {
//		if (a % (i * i) == 0 && a % (i * i * i) != 0) {
//			cout << i << " ";
//		}
//	}
//	cout << endl;
//	//5
//	int c,d;
//	int sum = 0;
//	cout << "������ �����: ";
//	cin >> d;
//	c = d;
//	while (c != 0) {
//		sum += c % 10;
//		c /= 10;
//	}
//	if (sum * sum * sum == d * d)
//	{
//		cout << "��� ���� ���� ����� " << d << " ������� A*A";
//	}
//	else
//	{
//		cout << "��� ���� ���� ����� " << d << " �� ������� A*A";
//	}
//	cout << endl;
//	//6
//	int b;
//	cout << "������ �����: ";
//	cin >> b;
//	for (int i = 1; i < b; i++)
//	{
//		if (b % i == 0)
//		{
//			cout << i << " ";
//		}
//	}
//	cout << endl;*/
//	//7
//	int s,e;
//	cout << "������ �����: ";
//	cin >> s >> e;
//	if (s > e)
//	{
//		for (int i = 1; i < e + 1; i++)
//		{
//			if (s % i == 0 && e % i == 0)
//			{
//				cout << i << " ";
//			}
//		}
//	}
//	else
//	{
//		for (int i = 1; i < s + 1; i++)
//		{
//			if (s % i == 0 && e % i == 0)
//			{
//				cout << i << " ";
//			}
//		}
//	}
//	cout << endl;
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	//1
//	/*double arr[10];
//	double arr1[5];
//	double arr2[5];
//	srand(time(NULL));
//	
//	for (int i = 0; i < 10; i++)
//	{
//		arr[i] = rand() % 20;
//		cout << arr[i] << " ";
//	}
//	cout << endl;
//	cout << "������ �� 5 ��������:\n";
//	for (int i = 0; i < 5; i++)
//	{
//		arr1[i] = arr[i];
//		cout << arr1[i] << " ";
//	}
//	cout << endl;
//	for (int i = 0; i < 5; i++)
//	{
//		arr2[i] = arr[i+5];
//		cout << arr2[i] << " ";
//	}*/
//	//2
//	double arr[5];
//	double arr1[5];
//	double arr2[5];
//	srand(time(NULL));
//	cout << "����� 1:\n";
//	for (int i = 0; i < 5; i++)
//	{
//		arr1[i] = rand() % 20;
//		cout << arr1[i] << " ";
//	}
//	cout << endl;
//	cout << "����� 2:\n";
//	for (int i = 0; i < 5; i++)
//	{
//		arr2[i] = rand() % 20;
//		cout << arr2[i] << " ";
//	}
//	cout << endl;
//	cout << "���� ������:\n";
//	for (int i = 0; i < 5; i++)
//	{
//		arr[i] = arr1[i]+ arr2[i];
//		cout << arr[i] << " ";
//	}
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	//1
//	/*double arr[2][5];
//	int a,b;
//	cout << "������ �����: ";
//	cin >> a;
//	arr[0][0] = a;
//	cout << "�����:\n";
//	cout << arr[0][0] << "\t";
//	for (int i = 1; i < 5; i++)
//	{
//		arr[0][i] = arr[0][i - 1] * 2;
//		cout << arr[0][i] << "\t";
//		if (i == 4)
//		{
//			b = arr[0][4];
//		}
//	}
//	cout << endl;
//	arr[1][0] = b * 2;
//	cout << arr[1][0] << "\t";
//	for (int i = 1; i < 5; i++)
//	{
//		arr[1][i] = arr[1][i - 1] * 2;
//		cout << arr[1][i] << "\t";
//	}
//	//2
//	double arr[2][5];
//	int a, b;
//	cout << "������ �����: ";
//	cin >> a;
//	arr[0][0] = a;
//	cout << "�����:\n";
//	cout << arr[0][0] << "\t";
//	for (int i = 1; i < 5; i++)
//	{
//		arr[0][i] = arr[0][i - 1] + 1;
//		cout << arr[0][i] << "\t";
//		if (i == 4)
//		{
//			b = arr[0][4];
//		}
//	}
//	cout << endl;
//	arr[1][0] = b + 1;
//	cout << arr[1][0] << "\t";
//	for (int i = 1; i < 5; i++)
//	{
//		arr[1][i] = arr[1][i - 1] + 1;
//		cout << arr[1][i] << "\t";
//	}*/
//	//3
//	double arr[2][5];
//	srand(time(NULL));
//	cout << "�����:\n";
//	for (int i = 0; i < 5; i++)
//	{
//		arr[0][i] = rand() % 20;
//		cout << arr[0][i] << "\t";
//	}
//	cout << endl;
//	for (int i = 0; i < 5; i++)
//	{
//		arr[1][i] = rand() % 20;
//		cout << arr[1][i] << "\t";
//	}
//	cout << endl;
//	int ch = 1, zsuv, tmp, tmp1;
//	double arr1[2][5];
//	while (ch!=0)
//	{
//		cout << "Menu:\n";
//		cout << "1 - ������� �����\n";
//		cout << "2 - ���� ������\n";
//		cout << "3 - ���� ��������\n";
//		cout << "4 - ���� �����\n";
//		cout << "5 - ���� ����\n";
//		cout << "0 - Exit\n";
//		cout << "����: ";
//		cin >> ch;
//		if (ch == 1)
//		{
//			cout << "�����:\n";
//			for (int i = 0; i < 5; i++)
//			{
//				cout << arr[0][i] << "\t";
//			}
//			cout << endl;
//			for (int i = 0; i < 5; i++)
//			{
//				cout << arr[1][i] << "\t";
//			}
//			cout << endl;
//		}
//		else if (ch == 2)
//		{
//			cout << "�� ������ ���: ";
//			cin >> zsuv;
//			for (int i = 0; i < zsuv; i++)
//			{
//				arr1[0][0] = arr[0][4];
//				arr1[1][0] = arr[1][4];
//				for (int j = 0; j < 4; j++)
//				{
//					arr1[0][j + 1] = arr[0][j];
//					arr1[1][j + 1] = arr[1][j];
//				}
//				for (int j = 0; j < 5; j++)
//				{
//					arr[0][j] = arr1[0][j];
//					arr[1][j] = arr1[1][j];
//				}
//			}
//		}
//		else if (ch == 3)
//		{
//			cout << "�� ������ ���: ";
//			cin >> zsuv;
//			for (int i = 0; i < zsuv; i++)
//			{
//				arr1[0][4] = arr[0][0];
//				arr1[1][4] = arr[1][0];
//				for (int j = 4; j > 0; j--)
//				{
//					arr1[0][j - 1] = arr[0][j];
//					arr1[1][j - 1] = arr[1][j];
//				}
//				for (int j = 0; j < 5; j++)
//				{
//					arr[0][j] = arr1[0][j];
//					arr[1][j] = arr1[1][j];
//				}
//			}
//		}
//		else if (ch == 4 || ch == 5)
//		{
//			for (int j = 0; j < 5; j++)
//			{
//				arr1[0][j] = arr[0][j];
//				arr1[1][j] = arr[1][j];
//			}
//			for (int j = 0; j < 5; j++)
//			{
//				arr[0][j] = arr1[1][j];
//				arr[1][j] = arr1[0][j];
//			}
//		}
//		else if (ch == 0)
//		{
//			cout << "\nbye";
//		}
//		else
//		{
//			cout << "error\n";
//		}
//	}
//}

//int pov(int a, int n) {
//	int result = a;
//	for (int i = 1; i < n; i++)
//	{
//		result *= a;
//	}
//	return result;
//}
//
//int dosc_numb(int a, int b) {
//	int sum;
//	//int s = 1;
//	//int arr = arrr;
//	for (int i = a + 1; i < b; i++)
//	{
//		sum = 0;
//		for (int j = 1; j < i; j++)
//		{
//			if (i % j == 0)
//			{
//				sum += j;
//			}
//		}
//		if (i == sum)
//		{
//			cout << i << " ";
//		}
//	}
//	//arr[0] = s;
//	return 0;
//}
//
//char card(char a, char b) {
//	cout << "||||||||||\n";
//	cout << "|" << a << "||||||||\n";
//	cout << "|" << b << "||||||||\n";
//	cout << "||||||||||\n";
//	cout << "||||||||||\n";
//	cout << "||||||||" << a << "|\n";
//	cout << "||||||||" << b << "|\n";
//	cout << "||||||||||\n";
//	return NULL;
//}
//
//bool good_numb(int a) {
//	int d1 = a / 100000 % 10;
//	int d2 = a / 10000 % 10;
//	int d3 = a / 1000 % 10;
//	int d4 = a / 100 % 10;
//	int d5 = a / 10 % 10;
//	int d6 = a % 10;
//	
//	if (d1 + d2 + d3 == d4 + d5 + d6) {
//		return true;
//	}
//	else {
//		return false;
//	}
//}
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	//1
//	/*int a, n;
//	cout << "������ �����: ";
//	cin >> a;
//	cout << "������ ������: ";
//	cin >> n;
//	cout << a << "^" << n << " = " << pov(a, n);
//	//2
//	int a, b;
//	cout << "������ �����: ";
//	cin >> a;
//	cout << "������ �����: ";
//	cin >> b;
//	cout << "���� ����� � �������� �� ����: " << sum_v_diap(a, b);
//	//3
//	int a, b;
//	//int** arrr[]{ 0 };
//	cout << "������ �����: ";
//	cin >> a;
//	cout << "������ �����: ";
//	cin >> b;
//	//int arr = dosc_numb(a, b);
//	//int size = arrr[0];
//	cout << "����������� ����� � ����� ��������: ";
//	dosc_numb(a, b);
//	//4
//	char a,b;
//	cout << "������:\n� � ��� 7 �\n������ ������ �� ���� �����, � ������ �� �����\n� - �����\n� - �����\n� - ϳ��\n� - �����\n";
//	cout << "������ �����: ";
//	cin >> a >> b;
//	card(a,b);*/
//	//5
//	int a;
//	cout << "������ ����������� �����: ";
//	cin >> a;
//	if (a < 100000 || a > 999999) {
//		cout << "����� �� � ������������";
//		return 0;
//	}
//	if (good_numb(a))
//	{
//		cout << "����� �������";
//	}
//	else
//	{
//		cout << "����� �� �������";
//	}
//}

//1

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int ch = -1;
//	while (ch < 0 || ch > 10)
//	{
//		cout << "������ ������:"
//			<< "\n 1 - ������ �"
//			<< "\n 2 - ������ �"
//			<< "\n 3 - ������ �"
//			<< "\n 4 - ������ �"
//			<< "\n 5 - ������ �"
//			<< "\n 6 - ������ �"
//			<< "\n 7 - ������ �"
//			<< "\n 8 - ������ �"
//			<< "\n 9 - ������ �"
//			<< "\n 10 - ������ �"
//			<< "\n 0 - �����"
//			<< "\n��� ����: ";
//		cin >> ch;
//        if (ch == 1) {
//            cout << endl;
//            for (int i = 0; i < 5; i++)
//            {
//                cout << "   ";
//                for (int j = 0; j < i; j++)
//                {
//                    cout << "  ";
//                }
//                for (int j = 0; j < 5 - i; j++)
//                {
//                    cout << "* ";
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 2) {
//            cout << endl;
//            for (int i = 0; i < 5; i++)
//            {
//                cout << "   ";
//                for (int j = 0; j < i+1; j++)
//                {
//                    cout << "* ";
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 3) {
//            cout << endl;
//            for (int i = 0; i < 5; i++)
//            {
//                cout << "   ";
//                for (int j = 0; j < i; j++)
//                {
//                    cout << " ";
//                }
//                for (int j = 0; j < 5 - i; j++)
//                {
//                    cout << "* ";
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 4) {
//            for (int i = 0; i < 6; i++)
//            {
//                cout << "   ";
//                for (int j = 0; j < 5 - i; j++)
//                {
//                    cout << " ";
//                }
//                for (int j = 0; j < i; j++)
//                {
//                    cout << "* ";
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 5) {
//            cout << endl;
//            for (int i = 0; i < 5; i++)
//            {
//                cout << "   ";
//                for (int j = 0; j < i; j++)
//                {
//                    cout << " ";
//                }
//                for (int j = 0; j < 5 - i; j++)
//                {
//                    cout << "* ";
//                }
//                cout << endl;
//            }
//            cout << "\b\b\b\b\b\b\b\b";
//            for (int i = 1; i < 6; i++)
//            {
//                cout << "   ";
//                for (int j = 0; j < 5 - i; j++)
//                {
//                    cout << " ";
//                }
//                for (int j = 0; j < i; j++)
//                {
//                    cout << "* ";
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 6) {
//            cout << "�� ������ ������ �\n";
//        }
//        else if (ch == 7) {
//            for (int i = 0; i < 6; i++) {
//                for (int j = 0; j < 5; j++) {
//                    if ((j <= i && i < 3) || (j < 2 && i == 3) || (j < 1 && i == 4)) {
//                        cout << "* "; // ����� �����������
//                    }
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 8) {
//            cout << "�� ������ ������ �\n";
//        }
//        else if (ch == 9) {
//            for (int i = 0; i < 6; i++)
//            {
//                for (int j = 0; j < 6; j++)
//                {
//                    if (j > i)
//                    {
//                        cout << "* ";
//                    }
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 10) {
//            for (int i = 0; i < 6; i++)
//            {
//                cout << "   ";
//                for (int j = 0; j < 5 - i; j++)
//                {
//                    cout << "  ";
//                }
//                for (int j = 0; j < i; j++)
//                {
//                    cout << "* ";
//                }
//                cout << endl;
//            }
//        }
//        else if (ch == 0) {
//            cout << "\n�� ���������\n";
//        }
//        else {
//            cout << "������� ����\n\n������ ������: ";
//        }
//	}
//}

//2

//int countDigits(int number) {
//    if (number == 0) return 1;
//    int count = 0;
//    number = abs(number);
//    while (number > 0) {
//        number /= 10;
//        count++;
//    }
//    return count;
//}
//
//int sumDigits(int number) {
//    if (number == 0) return 0;
//    int sum = 0;
//    number = abs(number);
//    while (number > 0) {
//        sum += number % 10;
//        number /= 10;
//    }
//    return sum;
//}
//
//double averageDigits(int number) {
//    if (number == 0) return 0;
//    double sum = 0, count = 0;
//    number = abs(number);
//    while (number > 0) {
//        sum += number % 10;
//        number /= 10;
//        count++;
//    }
//    return (count == 0) ? 0 : sum / count;
//}
//
//int countZeros(int number) {
//    int count = 0;
//    number = abs(number);
//    while (number > 0) {
//        if (number % 10 == 0) {
//            count++;
//        }
//        number /= 10;
//    }
//    return count;
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int number;
//    int choice;
//    cout << "������ �����: ";
//    cin >> number;
//    cout << "\n����:\n";
//    cout << "1. ʳ������ ���� � ����\n";
//    cout << "2. ���� ���� � ����\n";
//    cout << "3. ������� ����������� ����\n";
//    cout << "4. ʳ������ ���� � ����\n";
//    cout << "0. �����\n";
//    while (true) {
//        cout << "������� �����: ";
//        cin >> choice;
//        if (choice == 1) {
//            cout << "ʳ������ ���� � ����: " << countDigits(number) << endl;
//            break;
//        }
//        else if (choice == 2) {
//            cout << "���� ���� � ����: " << sumDigits(number) << endl;
//            break;
//        }
//        else if (choice == 3) {
//            cout << "������� ����������� ����: " << averageDigits(number) << endl;
//            break;
//        }
//        else if (choice == 4) {
//            cout << "ʳ������ ���� � ����: " << countZeros(number) << endl;
//            break;
//        }
//        else if (choice == 0) {
//            cout << "����� � ��������." << endl;
//            break;
//        }
//        else {
//            cout << "������������ ����. ��������� �� ���.\n";
//        }
//    }
//}

//3

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	int size, enter = 0;
//	cout << "������ �����: ";
//	cin >> size;
//	for (int i = 1; i < 25; i++)
//	{
//		if (i % 2 == 0)
//		{
//			for (int j = 0; j < size; j++)
//			{
//				cout << "_";
//			}
//		}
//		else
//		{
//			for (int j = 0; j < size; j++)
//			{
//				cout << "*";
//			}
//		}
//		if (enter == 7)
//		{
//			cout << "\n\n";
//			enter = 0;
//		}
//		else
//		{
//			enter++;
//		}
//	}
//	enter = 0;
//	for (int i = 1; i < 25; i++)
//	{
//		if (i % 2 == 0)
//		{
//			for (int j = 0; j < size; j++)
//			{
//				cout << "*";
//			}
//		}
//		else
//		{
//			for (int j = 0; j < size; j++)
//			{
//				cout << "_";
//			}
//		}
//		if (enter == 7)
//		{
//			cout << "\n\n";
//			enter = 0;
//		}
//		else
//		{
//			enter++;
//		}
//	}
//}

//struct numb
//{
//	int	numb;
//	int index;
//};
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	//1
//	/*srand(time(NULL));
//	int arr[10];
//	int mx_numb, mn_numb;
//	cout << "�����: ";
//	for (int i = 0; i < 10; i++)
//	{
//		arr[i] = rand() % 21;
//		cout << arr[i] << " ";
//	}
//	cout << endl;
//	mx_numb = arr[0];
//	mn_numb = arr[0];
//	for (int i = 0; i < 10; i++)
//	{
//		if (arr[i] > mx_numb)
//		{
//			mx_numb = arr[i];
//		}
//		if (arr[i] < mn_numb)
//		{
//			mn_numb = arr[i];
//		}
//	}
//	cout << "����������� ��������: " << mx_numb << endl;
//	cout << "̳�������� ��������: " << mn_numb << endl;
//	//2
//	int arr[12];
//	int mx_numb, mn_numb, frst_numb, lst_numb;
//	for (int i = 0; i < 12; i++)
//	{
//		cout << "������ �������� �� " << i + 1 << " �����: ";
//		cin >> arr[i];
//	}
//	cout << "\n������ ������� ��������: ";
//	cin >> frst_numb;
//	cout << "������ ����� ��������: ";
//	cin >> lst_numb;
//	mx_numb = arr[frst_numb - 1];
//	mn_numb = arr[frst_numb - 1];
//	for (int i = frst_numb; i < lst_numb; i++)
//	{
//		if (arr[i] > mx_numb)
//		{
//			mx_numb = arr[i];
//		}
//		if (arr[i] < mn_numb)
//		{
//			mn_numb = arr[i];
//		}
//	}
//	cout << "������������ ��������: " << mx_numb << endl;
//	cout << "̳��������� ��������: " << mn_numb << endl;
//	//3*/
//	int size, sum_of_vid = 0, dob_min_max = 1, dob_count2 = 1, sum_of_vid_frstTOlst = 0;
//	numb mn_numb, mx_numb, mn_numb1, mn_numb2;
//	cout << "������ ����� ������: ";
//	cin >> size;
//	int* arr = new int[size];
//	srand(time(NULL));
//	for (int i = 0; i < size; i++)
//	{
//		if ((rand() % 3) == 0)
//		{
//			arr[i] = rand() % 21;
//		}
//		else
//		{
//			arr[i] = (rand() % 21) * (-1);
//		}
//		cout << arr[i] << "\t";
//	}
//
//	for (int i = 0; i < size; i++)
//	{
//		if (arr[i] < 0)
//		{
//			sum_of_vid += arr[i];
//		}
//	}
//
//	mn_numb.numb = arr[0];
//	mx_numb.numb = arr[0];
//	mn_numb.index = 0;
//	mx_numb.index = 0;
//	for (int i = 0; i < size; i++)
//	{
//		if (arr[i] > mx_numb.numb)
//		{
//			mx_numb.numb = arr[i];
//			mx_numb.index = i;
//		}
//		if (arr[i] < mn_numb.numb)
//		{
//			mn_numb.numb = arr[i];
//			mn_numb.index = i;
//		}
//	}
//	if (mn_numb.index < mx_numb.index)
//	{
//		for (int i = mn_numb.index; i < mx_numb.index + 1; i++)
//		{
//			dob_min_max *= arr[i];
//		}
//	}
//	else
//	{
//		for (int i = mx_numb.index; i < mn_numb.index + 1; i++)
//		{
//			dob_min_max *= arr[i];
//		}
//	}
//
//	for (int i = 1; i < size; i++)
//	{
//		if (i % 2 == 0)
//		{
//			continue;
//		}
//		else
//		{
//			dob_count2 *= arr[i];
//		}
//	}
//
//	mn_numb1.numb = 0;
//	mn_numb2.numb = 0;
//	mn_numb1.index = 0;
//	mn_numb2.index = 0;
//	for (int i = 0; i < size; i++)
//	{
//		if (mn_numb1.numb == 0 && arr[i] < 0)
//		{
//			mn_numb1.numb = arr[i];
//			mn_numb1.index = i;
//		}
//		if (arr[i] < 0)
//		{
//			mn_numb2.numb = arr[i];
//			mn_numb2.index = i;
//		}
//	}
//	for (int i = mn_numb1.index; i < mn_numb2.index + 1; i++)
//	{
//		sum_of_vid_frstTOlst += arr[i];
//	}
//	
//	cout << "\n���� ��'����� ��������: " << sum_of_vid;
//	cout << "\n������� ��������, �� ����������� �� min � max ����������: " << dob_min_max;
//	if (size > 1)
//	{
//	cout << "\n������� �������� � ������� ��������: " << dob_count2;
//	}
//	else
//	{
//		cout << "\n������� �������� � ������� ��������: 0";
//	}
//	cout << "\n���� ��������, �� ����������� �� ������ � �������� ��'������ ����������: " << sum_of_vid_frstTOlst;
//}

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	srand(time(NULL));
//	/*int size1, size2;
//
//	cout << "������ ����� ������ 1: ";
//	cin >> size1;
//	int* arr1 = new int[size1];
//	for (int i = 0; i < size1; i++)
//	{
//		arr1[i] = rand() % 11;
//	}
//
//	cout << "������ ����� ������ 2: ";
//	cin >> size2;
//	int* arr2 = new int[size2];
//	for (int i = 0; i < size2; i++)
//	{
//		arr2[i] = rand() % 11;
//	}
//
//	int size3 = 0;
//	int povt1 = 0;
//	for (int i = 0; i < size1; i++)
//	{
//		povt1 = 0;
//		for (int j = 0; j < size2; j++)
//		{
//			if (arr1[i] == arr2[j])
//			{
//				povt1++;
//				break;
//			}
//		}
//		if (povt1 == 0)
//		{
//			size3++;
//		}
//	}
//	int arr3_in = 0;
//	int* arr3 = new int[size3];
//	for (int i = 0; i < size1; i++)
//	{
//		povt1 = 0;
//		for (int j = 0; j < size2; j++)
//		{
//			if (arr1[i] == arr2[j])
//			{
//				povt1++;
//				break;
//			}
//		}
//		if (povt1 == 0)
//		{
//			arr3[arr3_in] = arr1[i];
//			arr3_in++;
//		}
//	}
//	cout << "\n����� 1:";
//	for (int i = 0; i < size1; i++)
//	{
//		cout << "  " << arr1[i];
//	}
//	cout << "\n����� 2:";
//	for (int i = 0; i < size2; i++)
//	{
//		cout << "  " << arr2[i];
//	}
//	int povt = 0;
//	for (int i = 0; i < size3; i++)
//	{
//		povt = 0;
//		if (arr3[i] == -11)
//		{
//			continue;
//		}
//		for (int j = 0; j < size3; j++)
//		{
//			if (povt == 1 && arr3[i] == arr3[j])
//			{
//				arr3[j] = -11;
//			}
//			else if (povt == 0 && arr3[i] == arr3[j])
//			{
//				povt++;
//			}
//		}
//	}
//	cout << "\n����� 3:";
//	for (int i = 0; i < size3; i++)
//	{
//		if (arr3[i] != -11)
//		{
//			cout << "  " << arr3[i];
//		}
//	}*/
//	//2
//	int size1, size2, size3, size4;
//	cout << "������ ����� ������ 1: ";
//	cin >> size1;
//	int* arr1 = new int[size1];
//	for (int i = 0; i < size1; i++)
//	{
//		arr1[i] = rand() % 11;
//	}
//
//	cout << "������ ����� ������ 2: ";
//	cin >> size2;
//	int* arr2 = new int[size2];
//	for (int i = 0; i < size2; i++)
//	{
//		arr2[i] = rand() % 11;
//	}
//	size3 = 0;
//	int povt1 = 0;
//	for (int i = 0; i < size1; i++)
//	{
//		povt1 = 0;
//		for (int j = 0; j < size2; j++)
//		{
//			if (arr1[i] == arr2[j])
//			{
//				povt1++;
//				break;
//			}
//		}
//		if (povt1 == 0)
//		{
//			size3++;
//		}
//	}
//	int arr3_in = 0;
//	int* arr3 = new int[size3];
//	for (int i = 0; i < size1; i++)
//	{
//		povt1 = 0;
//		for (int j = 0; j < size2; j++)
//		{
//			if (arr1[i] == arr2[j])
//			{
//				povt1++;
//				break;
//			}
//		}
//		if (povt1 == 0)
//		{
//			arr3[arr3_in] = arr1[i];
//			arr3_in++;
//		}
//	}
//	size4 = 0;
//	int povt2 = 0;
//	for (int i = 0; i < size2; i++)
//	{
//		povt2 = 0;
//		for (int j = 0; j < size1; j++)
//		{
//			if (arr2[i] == arr1[j])
//			{
//				povt2++;
//				break;
//			}
//		}
//		if (povt2 == 0)
//		{
//			size4++;
//		}
//	}
//	int arr4_in = 0;
//	int* arr4 = new int[size4];
//	for (int i = 0; i < size2; i++)
//	{
//		povt2 = 0;
//		for (int j = 0; j < size1; j++)
//		{
//			if (arr2[i] == arr1[j])
//			{
//				povt2++;
//				break;
//			}
//		}
//		if (povt2 == 0)
//		{
//			arr4[arr4_in] = arr2[i];
//			arr4_in++;
//		}
//	}
//	int size5 = size3 + size4;
//	int* arr5 = new int[size5];
//	for (int i = 0; i < size3; i++)
//	{
//		arr5[i] = arr3[i];
//	}
//	for (int i = 0; i < size4; i++)
//	{
//		arr5[i + size3] = arr4[i];
//	}
//	int povt = 0;
//	for (int i = 0; i < size5; i++)
//	{
//		povt = 0;
//		if (arr5[i] == -11)
//		{
//			continue;
//		}
//		for (int j = 0; j < size3; j++)
//		{
//			if (povt == 1 && arr5[i] == arr5[j])
//			{
//				arr5[j] = -11;
//			}
//			else if (povt == 0 && arr5[i] == arr5[j])
//			{
//				povt++;
//			}
//		}
//	}
//	cout << "\n����� 1:";
//	for (int i = 0; i < size1; i++)
//	{
//		cout << "  " << arr1[i];
//	}
//	cout << "\n����� 2:";
//	for (int i = 0; i < size2; i++)
//	{
//		cout << "  " << arr2[i];
//	}
//	cout << "\n����� 3:";
//	for (int i = 0; i < size5; i++)
//	{
//		if (arr5[i] != -11)
//		{
//			cout << "  " << arr5[i];
//		}
//	}
//}



//int* alloc_arr(int size) {
//    return new int[size];
//}
//
//void init_arr(int* arr, int size, int value = 0) {
//    for (int i = 0; i < size; i++) {
//        arr[i] = value;
//    }
//}
//
//void out_arr(const int* arr, int size) {
//    for (int i = 0; i < size; i++) {
//        cout << arr[i] << " ";
//    }
//    cout << endl;
//}
//
//void del_arr(int* arr) {
//    delete[] arr;
//}
//
//int* add(int* arr, int& size, int new_element) {
//    int* new_arr = new int[size + 1];
//    for (int i = 0; i < size; i++) {
//        new_arr[i] = arr[i];
//    }
//    new_arr[size] = new_element;
//    size++;
//    delete[] arr;
//    return new_arr;
//}
//
//int* add_index(int* arr, int& size, int index, int new_element) {
//    if (index < 0 || index > size) {
//        cout << "������ �������� �� ���!" << endl;
//        return arr;
//    }
//
//    int* new_arr = new int[size + 1];
//    for (int i = 0; i < index; i++) {
//        new_arr[i] = arr[i];
//    }
//    new_arr[index] = new_element;
//    for (int i = index; i < size; i++) {
//        new_arr[i + 1] = arr[i];
//    }
//    size++;
//    delete[] arr;
//    return new_arr;
//}
//
//int* del(int* arr, int& size, int index) {
//    if (index < 0 || index >= size) {
//        cout << "������ �������� �� ���!" << endl;
//        return arr;
//    }
//
//    int* new_arr = new int[size - 1];
//    for (int i = 0; i < index; i++) {
//        new_arr[i] = arr[i];
//    }
//    for (int i = index + 1; i < size; i++) {
//        new_arr[i - 1] = arr[i];
//    }
//    size--;
//    delete[] arr;
//    return new_arr;
//}
//
//bool is_prime(int num) {
//    if (num <= 1) return false;
//    if (num <= 3) return true;
//    if (num % 2 == 0 || num % 3 == 0) return false;
//    for (int i = 5; i * i <= num; i += 6) {
//        if (num % i == 0 || num % (i + 2) == 0) return false;
//    }
//    return true;
//}
//
//int* del_primes(int* arr, int size, int& new_size) {
//    int* temp_arr = new int[size];
//    int count = 0;
//
//    for (int i = 0; i < size; i++) {
//        if (!is_prime(arr[i])) {
//            temp_arr[count++] = arr[i];
//        }
//    }
//
//    new_size = count;
//
//    int* new_arr = new int[new_size];
//    for (int i = 0; i < new_size; i++) {
//        new_arr[i] = temp_arr[i];
//    }
//
//    delete[] temp_arr;
//
//    return new_arr;
//}
//
//void split_array(int* arr, int size, int*& pos_arr, int& pos_size, int*& neg_arr, int& neg_size, int*& zero_arr, int& zero_size) {
//    int pos_count = 0, neg_count = 0, zero_count = 0;
//
//    for (int i = 0; i < size; ++i) {
//        if (arr[i] > 0) ++pos_count;
//        else if (arr[i] < 0) ++neg_count;
//        else ++zero_count;
//    }
//
//    pos_arr = new int[pos_count];
//    neg_arr = new int[neg_count];
//    zero_arr = new int[zero_count];
//
//    pos_size = 0; neg_size = 0; zero_size = 0;
//    for (int i = 0; i < size; ++i) {
//        if (arr[i] > 0) pos_arr[pos_size++] = arr[i];
//        else if (arr[i] < 0) neg_arr[neg_size++] = arr[i];
//        else zero_arr[zero_size++] = arr[i];
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    //1
//    /*int size = 0;
//    int* arr = nullptr;
//
//    while (true) {
//        cout << "\n\n����:\n";
//        cout << "1. ������� �����\n";
//        cout << "2. ������������� �����\n";
//        cout << "3. ������� �����\n";
//        cout << "4. ������ ������� � �����\n";
//        cout << "5. �������� ������� �� ��������\n";
//        cout << "6. �������� ������� �� ��������\n";
//        cout << "7. �������� ����� � �����\n";
//        cout << "������ ��� ����: ";
//        int choice;
//        cin >> choice;
//
//        if (choice == 1) {
//            cout << "������ ����� ������: ";
//            cin >> size;
//            del_arr(arr);
//            arr = alloc_arr(size);
//            cout << "����� ������� � ������� " << size << "." << endl;
//        }
//        else if (choice == 2) {
//            if (arr == nullptr) {
//                cout << "����� �� �������!" << endl;
//            }
//            else {
//                int value;
//                cout << "������ �������� ��� ������������ ������: ";
//                cin >> value;
//                init_arr(arr, size, value);
//                cout << "����� �������������." << endl;
//            }
//        }
//        else if (choice == 3) {
//            if (arr == nullptr) {
//                cout << "����� �� �������!" << endl;
//            }
//            else {
//                cout << "���� ������: ";
//                out_arr(arr, size);
//            }
//        }
//        else if (choice == 4) {
//            if (arr == nullptr) {
//                cout << "����� �� �������!" << endl;
//            }
//            else {
//                int new_element;
//                cout << "������ ������� ��� ���������: ";
//                cin >> new_element;
//                arr = add(arr, size, new_element);
//                cout << "������� ������." << endl;
//            }
//        }
//        else if (choice == 5) {
//            if (arr == nullptr) {
//                cout << "����� �� �������!" << endl;
//            }
//            else {
//                int index, new_element;
//                cout << "������ ������ ��� �������: ";
//                cin >> index;
//                cout << "������ ������� ��� �������: ";
//                cin >> new_element;
//                arr = add_index(arr, size, index, new_element);
//                cout << "������� ���������." << endl;
//            }
//        }
//        else if (choice == 6) {
//            if (arr == nullptr) {
//                cout << "����� �� �������!" << endl;
//            }
//            else {
//                int index;
//                cout << "������ ������ ��� ���������: ";
//                cin >> index;
//                arr = del(arr, size, index);
//                cout << "������� ��������." << endl;
//            }
//        }
//        else if (choice == 7) {
//            del_arr(arr);
//            cout << "����� ��������. ����� � ��������." << endl;
//            break;
//        }
//        else {
//            cout << "������� ����! ���� �����, ������ ����� �� 1 �� 7." << endl;
//        }
//    }
//    //2
//    srand(time(NULL));
//    int size;
//    cout << "������ ����� ������: ";
//    cin >> size;
//    int* arr = new int[size];
//    for (int i = 0; i < size; i++)
//    {
//        arr[i] = rand() % 21;
//    }
//    cout << "�����: ";
//    for (int i = 0; i < size; ++i) {
//        cout << arr[i] << " ";
//    }
//    cout << endl;
//
//    int new_size;
//
//    int* new_arr = del_primes(arr, size, new_size);
//
//    cout << "����� �����: ";
//    for (int i = 0; i < new_size; ++i) {
//        cout << new_arr[i] << " ";
//    }
//    cout << endl;*/
//    //3
//    int size = 10;
//    int arr[] = { 3, -1, 0, 2, -5, 7, 0, -3, 4, -2 };
//
//    cout << "�����: ";
//    for (int i = 0; i < size; ++i) {
//        cout << arr[i] << " ";
//    }
//    cout << endl;
//
//    int* pos_arr, * neg_arr, * zero_arr;
//    int pos_size, neg_size, zero_size;
//
//    split_array(arr, size, pos_arr, pos_size, neg_arr, neg_size, zero_arr, zero_size);
//
//    cout << "��������� ��������: ";
//    for (int i = 0; i < pos_size; ++i) {
//        cout << pos_arr[i] << " ";
//    }
//    cout << endl;
//
//    cout << "³�'���� ��������: ";
//    for (int i = 0; i < neg_size; ++i) {
//        cout << neg_arr[i] << " ";
//    }
//    cout << endl;
//
//    cout << "������ ��������: ";
//    for (int i = 0; i < zero_size; ++i) {
//        cout << zero_arr[i] << " ";
//    }
//    cout << endl;
//}

//#include <time.h> 
////1
//*const int N = 8;
//const int moves[8][2] = { {2, 1}, {2, -1}, {-2, 1}, {-2, -1},
//                          {1, 2}, {1, -2}, {-1, 2}, {-1, -2} };
//
//bool is_valid(int x, int y, int board[N][N]) {
//    return (x >= 0 && x < N && y >= 0 && y < N && board[x][y] == -1);
//}
//
//void print_board(int board[N][N]) {
//    for (int i = 0; i < N; ++i) {
//        for (int j = 0; j < N; ++j) {
//            if (board[i][j] < 10)
//                cout << " ";
//                cout << board[i][j]+1 << " ";
//        }
//        cout << endl;
//    }
//}
//
//int count_next_moves(int x, int y, int board[N][N]) {
//    int count = 0;
//    for (int i = 0; i < 8; ++i) {
//        int next_x = x + moves[i][0];
//        int next_y = y + moves[i][1];
//        if (is_valid(next_x, next_y, board)) {
//            count++;
//        }
//    }
//    return count;
//}
//
//void sort_moves(int x, int y, pair<int, int> sorted_moves[8], int board[N][N]) {
//    int move_count = 0;
//    for (int i = 0; i < 8; ++i) {
//        int next_x = x + moves[i][0];
//        int next_y = y + moves[i][1];
//        if (is_valid(next_x, next_y, board)) {
//            sorted_moves[move_count++] = { next_x, next_y };
//        }
//    }
//
//    for (int i = 0; i < move_count - 1; ++i) {
//        for (int j = 0; j < move_count - i - 1; ++j) {
//            int count_a = count_next_moves(sorted_moves[j].first, sorted_moves[j].second, board);
//            int count_b = count_next_moves(sorted_moves[j + 1].first, sorted_moves[j + 1].second, board);
//            if (count_a > count_b) {
//                swap(sorted_moves[j], sorted_moves[j + 1]);
//            }
//        }
//    }
//}
//
//bool solve_knight_tour(int x, int y, int move_i, int board[N][N]) {
//    if (move_i == N * N) {
//        return true;
//    }
//
//    pair<int, int> sorted_moves[8];
//    sort_moves(x, y, sorted_moves, board);
//
//    for (int i = 0; i < 8 && sorted_moves[i].first != -1; ++i) {
//        int next_x = sorted_moves[i].first;
//        int next_y = sorted_moves[i].second;
//        board[next_x][next_y] = move_i;
//        if (solve_knight_tour(next_x, next_y, move_i + 1, board)) {
//            return true;
//        }
//        board[next_x][next_y] = -1;
//    }
//
//    return false;
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//
//    int board[N][N];
//    for (int i = 0; i < N; ++i) {
//        for (int j = 0; j < N; ++j) {
//            board[i][j] = -1;
//        }
//    }
//
//    int start_x, start_y;
//    cout << "������ ��������� ���������� X (1-8): ";
//    cin >> start_x;
//    cout << "������ ��������� ���������� Y (1-8): ";
//    cin >> start_y;
//
//    if (start_x < 1 || start_x > N || start_y < 1 || start_y > N) {
//        cout << "���������� ����������!" << endl;
//        exit(1);
//    }
//
//    // ��������� ���������� � �������� 1-8 �� 0-7
//    start_x -= 1;
//    start_y -= 1;
//
//    board[start_x][start_y] = 0;
//
//    if (solve_knight_tour(start_x, start_y, 1, board)) {
//        cout << "г����� ��������!" << endl;
//        print_board(board);
//    }
//    else {
//        cout << "г����� �� ����." << endl;
//    }
//}
////2
//const int size1 = 4;
//const int empty1 = 0;
//
//void print_board(int board[size1][size1]) {
//    for (int i = 0; i < size1; ++i) {
//        for (int j = 0; j < size1; ++j) {
//            if (board[i][j] == empty1) {
//                cout << "    ";
//            } else {
//                if (board[i][j] < 10) {
//                    cout << " " << board[i][j] << "  ";
//                } else {
//                    cout << board[i][j] << "  ";
//                }
//            }
//        }
//        cout << "\n";
//    }
//}
//
//bool is_solved(int board[size1][size1]) {
//    int count = 1;
//    for (int i = 0; i < size1; ++i) {
//        for (int j = 0; j < size1; ++j) {
//            if (board[i][j] != empty1 && board[i][j] != count++) {
//                return false;
//            }
//        }
//    }
//    return true;
//}
//
//bool move_tile(int board[size1][size1], int direction) {
//    int dx[] = { -1, 1, 0, 0 };
//    int dy[] = { 0, 0, -1, 1 };
//
//    int empty_x, empty_y;
//    for (int i = 0; i < size1; ++i) {
//        for (int j = 0; j < size1; ++j) {
//            if (board[i][j] == empty1) {
//                empty_x = i;
//                empty_y = j;
//            }
//        }
//    }
//
//    int new_x = empty_x + dx[direction];
//    int new_y = empty_y + dy[direction];
//
//    if (new_x >= 0 && new_x < size1 && new_y >= 0 && new_y < size1) {
//        swap(board[empty_x][empty_y], board[new_x][new_y]);
//        return true;
//    }
//    return false;
//}
//
//void generate_board(int board[size1][size1]) {
//    int num = 1;
//    for (int i = 0; i < size1; ++i) {
//        for (int j = 0; j < size1; ++j) {
//            board[i][j] = num++;
//        }
//    }
//    board[size1 - 1][size1 - 1] = empty1;
//
//    srand(time(NULL));
//    for (int i = 0; i < 1000; ++i) {
//        int direction = rand() % 4;
//        move_tile(board, direction);
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int board[size1][size1];
//    generate_board(board);
//
//    cout << "��� '�'�������'! �������������� W, A, S, D ��� ���������� ������. Q ��� ������." << endl;
//
//    while (!is_solved(board)) {
//        print_board(board);
//
//        char move;
//        cout << "��� ���: ";
//        cin >> move;
//
//        if (move == 'q' || move == 'Q') {
//            cout << "����� � ���." << endl;
//            break;
//        }
//
//        int direction = -1;
//        if (move == 'w' || move == 'W') {
//            direction = 0;
//        } else if (move == 's' || move == 'S') {
//            direction = 1;
//        } else if (move == 'a' || move == 'A') {
//            direction = 2;
//        } else if (move == 'd' || move == 'D') {
//            direction = 3;
//        }
//
//        if (direction != -1 && !move_tile(board, direction)) {
//            cout << "������������ ���! ��������� �� ���." << endl;
//        }
//    }
//
//    if (is_solved(board)) {
//        cout << "³����! �� �������!" << endl;
//    }
//}*/
////3
//const int size1 = 3;
//const char empty1 = ' ';
//const char playerX = 'X';
//const char playerO = 'O';
//
//// ������� ��� ��������� �����
//void printBoard(char board[size1][size1]) {
//    for (int i = 0; i < size1; ++i) {
//        for (int j = 0; j < size1; ++j) {
//            cout << board[i][j];
//            if (j < size1 - 1) cout << " | ";
//        }
//        cout << endl;
//        if (i < size1 - 1) {
//            cout << "--|---|--" << endl;
//        }
//    }
//    cout << endl;
//}
//
//// ������� ��� �������� �������
//bool checkWin(char board[size1][size1], char player) {
//    // �������� �����
//    for (int i = 0; i < size1; ++i) {
//        if (board[i][0] == player && board[i][1] == player && board[i][2] == player) {
//            return true;
//        }
//    }
//
//    // �������� ��������
//    for (int j = 0; j < size1; ++j) {
//        if (board[0][j] == player && board[1][j] == player && board[2][j] == player) {
//            return true;
//        }
//    }
//
//    // �������� ���������
//    if (board[0][0] == player && board[1][1] == player && board[2][2] == player) {
//        return true;
//    }
//    if (board[0][2] == player && board[1][1] == player && board[2][0] == player) {
//        return true;
//    }
//
//    return false;
//}
//
//// ������� ��� �������� ����
//bool checkDraw(char board[size1][size1]) {
//    for (int i = 0; i < size1; ++i) {
//        for (int j = 0; j < size1; ++j) {
//            if (board[i][j] == empty1) {
//                return false;
//            }
//        }
//    }
//    return true;
//}
//
//// ������� ��� ��������� ����
//bool makeMove(char board[size1][size1], int row, int col, char player) {
//    if (row >= 0 && row < size1 && col >= 0 && col < size1 && board[row][col] == empty1) {
//        board[row][col] = player;
//        return true;
//    }
//    return false;
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    char board[size1][size1];
//    for (int i = 0; i < size1; ++i) {
//        for (int j = 0; j < size1; ++j) {
//            board[i][j] = empty1;
//        }
//    }
//
//    char currentPlayer = playerX;
//    bool gameOver = false;
//
//    while (!gameOver) {
//        printBoard(board);
//
//        int row, col;
//        cout << "������� " << currentPlayer << ", ������ ��� ��� (����� � ��������): ";
//        cin >> row >> col;
//
//        if (!makeMove(board, row - 1, col - 1, currentPlayer)) {
//            cout << "����������� ���. ��������� �� ���." << endl;
//            continue;
//        }
//
//        if (checkWin(board, currentPlayer)) {
//            printBoard(board);
//            cout << "������� " << currentPlayer << " ������!" << endl;
//            gameOver = true;
//        }
//        else if (checkDraw(board)) {
//            printBoard(board);
//            cout << "��� ���������� ������." << endl;
//            gameOver = true;
//        }
//        else {
//            currentPlayer = (currentPlayer == playerX) ? playerO : playerX;
//        }
//    }
//}

////1
//*void print_users(int* mobile_numbers, int* home_numbers, int size) {
//    cout << "������ ������������:\n";
//    for (int i = 0; i < size; ++i) {
//        cout << "��������: " << mobile_numbers[i] << ", ��������: " << home_numbers[i] << '\n';
//    }
//}
//
//void sort_by_mobile(int* mobile_numbers, int* home_numbers, int size) {
//    for (int i = 0; i < size - 1; ++i) {
//        for (int j = i + 1; j < size; ++j) {
//            if (mobile_numbers[i] > mobile_numbers[j]) {
//                swap(mobile_numbers[i], mobile_numbers[j]);
//                swap(home_numbers[i], home_numbers[j]);
//            }
//        }
//    }
//}
//
//void sort_by_home(int* mobile_numbers, int* home_numbers, int size) {
//    for (int i = 0; i < size - 1; ++i) {
//        for (int j = i + 1; j < size; ++j) {
//            if (home_numbers[i] > home_numbers[j]) {
//                swap(home_numbers[i], home_numbers[j]);
//                swap(mobile_numbers[i], mobile_numbers[j]);
//            }
//        }
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int mobile_numbers[10];
//    int home_numbers[10];
//    srand(time(NULL));
//    for (int i = 0; i < 10; i++)
//    {
//        mobile_numbers[i] = rand() % 9001;
//        while (mobile_numbers[i] < 1000)
//        {
//            mobile_numbers[i] = rand() % 9001;
//        }
//        home_numbers[i] = rand() % 9001;
//        while (home_numbers[i] < 1000)
//        {
//            home_numbers[i] = rand() % 9001;
//        }
//    }
//    int choice;
//    while (true) {
//        cout << "\n����:\n";
//        cout << "1. ³���������� �� �������� ��������\n";
//        cout << "2. ³���������� �� ��������� �������� ���������\n";
//        cout << "3. ������� ������ ������������\n";
//        cout << "4. �����\n";
//        cout << "������ ����� ������: ";
//        cin >> choice;
//
//        if (choice == 1) {
//            sort_by_mobile(mobile_numbers, home_numbers, 10);
//            cout << "³���������� �� ��������� ��������.\n";
//        }
//        else if (choice == 2) {
//            sort_by_home(mobile_numbers, home_numbers, 10);
//            cout << "³���������� �� ��������� ��������.\n";
//        }
//        else if (choice == 3) {
//            print_users(mobile_numbers, home_numbers, 10);
//        }
//        else if (choice == 4) {
//            cout << "�����.\n";
//            break;
//        }
//        else {
//            cout << "������� ����. ��������� �� ���.\n";
//        }
//    }
//}
////2
//void print_array(const int arr[], int size) {
//    for (int i = 0; i < size; ++i) {
//        cout << arr[i] << " ";
//    }
//    cout << endl;
//}
//void enhanced_bubble_sort(int arr[], int size) {
//    bool swapped;
//    for (int i = 0; i < size - 1; ++i) {
//        swapped = false;
//        for (int j = 0; j < size - i - 1; ++j) {
//            if (arr[j] > arr[j + 1]) {
//                swap(arr[j], arr[j + 1]);
//                swapped = true;
//            }
//        }
//        if (!swapped) {
//            break;
//        }
//    }
//}
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    srand(time(NULL));
//    int arr[10];
//    for (int i = 0; i < 10; i++)
//    {
//        arr[i] = rand() % 21;
//    }
//    cout << "����������� �����:\n";
//    print_array(arr, 10);
//    enhanced_bubble_sort(arr, 10);
//    cout << "³����������� �����:\n";
//    print_array(arr, 10);
//}*/
////3
//void flip(int arr[], int k) {
//    int start = 0;
//    while (start < k) {
//        swap(arr[start], arr[k - 1]);
//        start++;
//        k--;
//    }
//}
//
//int find_max_index(int arr[], int n) {
//    int max_idx = 0;
//    for (int i = 1; i < n; ++i) {
//        if (arr[i] > arr[max_idx]) {
//            max_idx = i;
//        }
//    }
//    return max_idx;
//}
//
//void pancake_sort(int arr[], int size) {
//    for (int n = size; n > 1; --n) {
//        int max_idx = find_max_index(arr, n);
//        if (max_idx != n - 1) {
//            if (max_idx != 0) {
//                flip(arr, max_idx + 1);
//            }
//            flip(arr, n);
//        }
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int stack[] = { 3, 6, 1, 5, 2, 4 };
//    cout << "����������� �����:\n";
//    for (int i = 0; i < 6; ++i) {
//        cout << stack[i] << " ";
//    }
//    pancake_sort(stack, 6);
//    cout << "\n³����������� �����:\n";
//    for (int i = 0; i < 6; ++i) {
//        cout << stack[i] << " ";
//    }
//}

//int line_srch(int arr[], int size, int key) {
//    for (int i = 0; i < size; ++i) {
//        if (arr[i] == key) {
//            return i;
//        }
//    }
//    return -1;
//}
//
//int bin_srch(int arr[], int size, int key) {
//    int left = 0;
//    int right = size - 1;
//
//    while (left <= right) {
//        int mid = left + (right - left) / 2;
//
//        if (arr[mid] == key) {
//            return mid;
//        }
//        else if (arr[mid] < key) {
//            left = mid + 1;
//        }
//        else {
//            right = mid - 1;
//        }
//    }
//    return -1;
//}
//
//int bin_to_dec(const string& bin_str) {
//    int dec_value = 0;
//    int base = 1;
//
//    for (int i = bin_str.length() - 1; i >= 0; --i) {
//        if (bin_str[i] == '1') {
//            dec_value += base;
//        }
//        base *= 2;
//    }
//    return dec_value;
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    //1
//    int arr[] = { 3, 5, 7, 9, 11 };
//    int key;
//    cout << "������ ���� ��� ������: ";
//    cin >> key;
//    int index = line_srch(arr, 5, key);
//    if (index != -1) {
//        cout << "���� �������� �� ������: " << index << endl;
//    }
//    else {
//        cout << "���� �� ��������" << endl;
//    }
//    //2
//    cout << "������ ���� ��� ������: ";
//    cin >> key;
//    index = bin_srch(arr, 5, key);
//    if (index != -1) {
//        cout << "���� �������� �� ������: " << index << endl;
//    }
//    else {
//        cout << "���� �� ��������" << endl;
//    }
//    //3
//    string bin_str;
//    cout << "������ ����� � ������� ������: ";
//    cin >> bin_str;
//
//    int dec_value = bin_to_dec(bin_str);
//
//    cout << "��������� �������������: " << dec_value;
//}

////1
//*void init(int** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        for (int j = 0; j < size; ++j) {
//            matrix[i][j] = rand() % 21;
//        }
//    }
//}
//void init(double** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        for (int j = 0; j < size; ++j) {
//            matrix[i][j] = static_cast<double>(rand() % 21);
//        }
//    }
//}
//void init(char** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        for (int j = 0; j < size; ++j) {
//            matrix[i][j] = static_cast<char>(rand() % 256);
//        }
//    }
//}
//
//
//
//void print(int** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        for (int j = 0; j < size; ++j) {
//            cout << matrix[i][j] << "\t";
//        }
//        cout << "\n\n";
//    }
//}
//void print(double** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        for (int j = 0; j < size; ++j) {
//            cout << matrix[i][j] << "\t";
//        }
//        cout << "\n\n";
//    }
//}
//void print(char** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        for (int j = 0; j < size; ++j) {
//            cout << matrix[i][j] << "\t";
//        }
//        cout << "\n\n";
//    }
//}
//
//
//
//void find_diag(int** matrix, int size, int& min_val, int& max_val) {
//    min_val = matrix[0][0];
//    max_val = matrix[0][0];
//
//    for (int i = 1; i < size; ++i) {
//        if (matrix[i][i] < min_val) {
//            min_val = matrix[i][i];
//        }
//        if (matrix[i][i] > max_val) {
//            max_val = matrix[i][i];
//        }
//    }
//}
//void find_diag(double** matrix, int size, double& min_val, double& max_val) {
//    min_val = matrix[0][0];
//    max_val = matrix[0][0];
//
//    for (int i = 1; i < size; ++i) {
//        if (matrix[i][i] < min_val) {
//            min_val = matrix[i][i];
//        }
//        if (matrix[i][i] > max_val) {
//            max_val = matrix[i][i];
//        }
//    }
//}
//void find_diag(char** matrix, int size, char& min_val, char& max_val) {
//    min_val = matrix[0][0];
//    max_val = matrix[0][0];
//
//    for (int i = 1; i < size; ++i) {
//        if (matrix[i][i] < min_val) {
//            min_val = matrix[i][i];
//        }
//        if (matrix[i][i] > max_val) {
//            max_val = matrix[i][i];
//        }
//    }
//}
//
//
//
//void bubble_sort(int* row, int size) {
//    for (int i = 0; i < size - 1; ++i) {
//        for (int j = 0; j < size - i - 1; ++j) {
//            if (row[j] > row[j + 1]) {
//                swap(row[j], row[j + 1]);
//            }
//        }
//    }
//}
//void bubble_sort(double* row, int size) {
//    for (int i = 0; i < size - 1; ++i) {
//        for (int j = 0; j < size - i - 1; ++j) {
//            if (row[j] > row[j + 1]) {
//                swap(row[j], row[j + 1]);
//            }
//        }
//    }
//}
//void bubble_sort(char* row, int size) {
//    for (int i = 0; i < size - 1; ++i) {
//        for (int j = 0; j < size - i - 1; ++j) {
//            if (row[j] > row[j + 1]) {
//                swap(row[j], row[j + 1]);
//            }
//        }
//    }
//}
//void sort_rows(int** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        bubble_sort(matrix[i], size);
//    }
//}
//void sort_rows(double** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        bubble_sort(matrix[i], size);
//    }
//}
//void sort_rows(char** matrix, int size) {
//    for (int i = 0; i < size; ++i) {
//        bubble_sort(matrix[i], size);
//    }
//}
//
//
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    srand(time(NULL));
//
//
//    int** int_matrix = new int* [3];
//    for (int i = 0; i < 3; ++i) {
//        int_matrix[i] = new int[3];
//    }
//    init(int_matrix, 3);
//    cout << "������� int:" << endl;
//    print(int_matrix, 3);
//
//    int min_int, max_int;
//    find_diag(int_matrix, 3, min_int, max_int);
//    cout << "Int - ̳����� �� �������: " << min_int << ", �������� �� �������: " << max_int << endl;
//
//    sort_rows(int_matrix, 3);
//    cout << "³���������� ������� int:" << endl;
//    print(int_matrix, 3);
//    cout << endl;
//
//
//    double** double_matrix = new double* [3];
//    for (int i = 0; i < 3; ++i) {
//        double_matrix[i] = new double[3];
//    }
//    init(double_matrix, 3);
//    cout << "������� double:" << endl;
//    print(double_matrix, 3);
//
//    double min_double, max_double;
//    find_diag(double_matrix, 3, min_double, max_double);
//    cout << "Double - ̳����� �� �������: " << min_double << ", �������� �� �������: " << max_double << endl;
//
//    sort_rows(double_matrix, 3);
//    cout << "³���������� ������� double:" << endl;
//    print(double_matrix, 3);
//    cout << endl;
//
//
//    char** char_matrix = new char* [3];
//    for (int i = 0; i < 3; ++i) {
//        char_matrix[i] = new char[3];
//    }
//    init(char_matrix, 3);
//    cout << "������� char:" << endl;
//    print(char_matrix, 3);
//
//    char min_char, max_char;
//    find_diag(char_matrix, 3, min_char, max_char);
//    cout << "Char - ̳����� �� �������: " << min_char << ", �������� �� �������: " << max_char << endl;
//
//    sort_rows(char_matrix, 3);
//    cout << "³���������� ������� char:" << endl;
//    print(char_matrix, 3);
//}
////2
//int nsd(int a, int b) {
//    if (b == 0) {
//        return a;
//    }
//    return nsd(b, a % b);
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int a, b;
//    cout << "������ ��� ��� �����: ";
//    cin >> a >> b;
//    cout << "��������� ������� ������: " << nsd(a, b);
//}*/
////3
//void check_guess(int secret, int guess, int& bulls, int& cows) {
//    int secret_digits[4], guess_digits[4];
//    bulls = 0;
//    cows = 0;
//    for (int i = 0; i < 4; i++) {
//        secret_digits[i] = secret % 10;
//        guess_digits[i] = guess % 10;
//        secret /= 10;
//        guess /= 10;
//    }
//    for (int i = 0; i < 4; i++) {
//        if (guess_digits[i] == secret_digits[i]) {
//            bulls++;
//        }
//        else {
//            for (int j = 0; j < 4; j++) {
//                if (i != j && guess_digits[i] == secret_digits[j]) {
//                    cows++;
//                    break;
//                }
//            }
//        }
//    }
//}
//void game(int secret, int attempt_count) {
//    int guess;
//    int bulls, cows;
//    cout << "������ ������������ �����: ";
//    cin >> guess;
//    if (guess < 1000 || guess > 9999) {
//        cout << "���� �����, ������ ����� ������������ �����." << endl;
//        game(secret, attempt_count);
//        return;
//    }
//    check_guess(secret, guess, bulls, cows);
//    cout << "����: " << bulls << ", ������: " << cows << endl;
//    if (bulls == 4) {
//        cout << "³����! �� ������� ����� �� " << attempt_count << " �����!" << endl;
//    }
//    else {
//        game(secret, attempt_count + 1);
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    srand(time(NULL));
//    int secret_number = 1000 + rand() % 9000;
//    cout << "� �������� ������������ �����. ��������� ���� �������." << endl;
//    game(secret_number, 1);
//}

//char* remove_char_at(char* str, int index) {
//    if (index < 0 || index >= strlen(str) - 1) {
//        cout << "������ �������� �� ��� �����\n";
//        return str;
//    }
//    for (int i = index; i < strlen(str) - 1; ++i) {
//        str[i] = str[i + 1];
//    }
//    str[strlen(str) - 1] = '\0';
//    return str;
//}
//
//char* remove_all(char* str, char to_remove) {
//    int j = 0;
//    for (size_t i = 0; i < strlen(str); ++i) {
//        if (str[i] != to_remove) {
//            str[j++] = str[i];
//        }
//    }
//    str[j] = '\0';
//    return str;
//}
//
//char* insert_char_at(char* str, int index, char to_insert) {
//    if (index < 0 || index > strlen(str) - 1) {
//        cout << "������ �������� �� ��� �����\n";
//        return str;
//    }
//    for (int i = strlen(str); i >= index; i--) {
//        str[i + 1] = str[i];
//    }
//    str[index] = to_insert;
//    str[strlen(str) + 1] = '\0';
//    return str;
//}
//
//char* replace_t_on_zv(char* str) {
//    for (int i = 0; i < strlen(str); ++i) {
//        if (str[i] == '.') {
//            str[i] = '!';
//        }
//    }
//    return str;
//}
//
//int count_povt(const char* str, char to_find) {
//    int count = 0;
//    for (int i = 0; i < strlen(str); ++i) {
//        if (str[i] == to_find) {
//            count++;
//        }
//    }
//    return count;
//}
//
//void count_characters(const char* str, int& let_count, int& digit_count, int& other_count) {
//    let_count = 0;
//    digit_count = 0;
//    other_count = 0;
//
//    size_t len = strlen(str);
//    for (size_t i = 0; i < len; ++i) {
//        char ch = str[i];
//        if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z')) {
//            let_count++;
//        }
//        else if (ch >= '0' && ch <= '9') {
//            digit_count++;
//        }
//        else {
//            other_count++;
//        }
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int choice;
//    char input[1000];
//    int index;
//    char to_remove, to_insert;
//    int letter_count, digit_count, other_count;
//    cout 
//        << "1. �������� ������ �� �������\n"
//        << "2. �������� �� ��������� �������� �������\n"
//        << "3. �������� ������ � �����\n"
//        << "4. ������� ������ �� ����� ������\n"
//        << "5. ���������� ������� �������� �������\n"
//        << "6. ���������� �����, ����� � ���� �������\n"
//        << "��� ����: "
//        ;
//    cin >> choice;
//    cin.ignore();
//    if (choice == 1) {
//        cout << "������ �����: ";
//        fgets(input, sizeof(input), stdin);
//        cout << "������ ����� ������� ��� ���������: ";
//        cin >> index;
//        cout << "���������: " << remove_char_at(input, index) << endl;
//    }
//    else if (choice == 2) {
//        cout << "������ �����: ";
//        fgets(input, sizeof(input), stdin);
//        cout << "������ ������ ��� ���������: ";
//        cin >> to_remove;
//        cout << "���������: " << remove_all(input, to_remove) << endl;
//    }
//    else if (choice == 3) {
//        cout << "������ �����: ";
//        fgets(input, sizeof(input), stdin);
//        cout << "������ ������� ��� �������: ";
//        cin >> index;
//        cout << "������ ������ ��� �������: ";
//        cin >> to_insert;
//        cout << "���������: " << insert_char_at(input, index, to_insert) << endl;
//    }
//    else if (choice == 4) {
//        cout << "������ �����: ";
//        fgets(input, sizeof(input), stdin);
//        cout << "���������: " << replace_t_on_zv(input) << endl;
//    }
//    else if (choice == 5) {
//        cout << "������ �����: ";
//        fgets(input, sizeof(input), stdin);
//        cout << "������ ������ ��� ���������: ";
//        cin >> to_remove;
//        cout << "ʳ������ �������� �������: " << count_povt(input, to_remove) << endl;
//    }
//    else if (choice == 6) {
//        cout << "������ �����: ";
//        fgets(input, sizeof(input), stdin);
//        count_characters(input, letter_count, digit_count, other_count);
//        cout << "ʳ������ ����: " << letter_count << endl;
//        cout << "ʳ������ ����: " << digit_count << endl;
//        cout << "ʳ������ ����� �������: " << other_count << endl;
//    }
//    else {
//        cout << "������� ����!" << endl;
//    }
//}

//int mystrcmp(const char* str1, const char* str2) {
//    while (*str1 && (*str1 == *str2)) {
//        str1++;
//        str2++;
//    }
//    if (*str1 > *str2) {
//        return 1;
//    }
//    if (*str1 < *str2) {
//        return -1;
//    }
//    return 0;
//}
//
//int StringToNumber(const char* str) {
//    int result = 0;
//    while (*str) {
//        if (*str >= '0' && *str <= '9') {
//            result = result * 10 + (*str - '0');
//        }
//        else {
//            cout << "���������� ������ � �����\n";
//            return 0;
//        }
//        str++;
//    }
//    return result;
//}
//
//char* NumberToString(int numb) {
//    static char numb_[12];
//    char* ptr = numb_ + sizeof(numb_) - 1;
//    *ptr = '\0';
//    bool is_negative = (numb < 0);
//    if (numb == 0) {
//        *(--ptr) = '0';
//    }
//    else if (is_negative) {
//        numb = -numb;
//    }
//    while (numb > 0) {
//        *(--ptr) = '0' + (numb % 10);
//        numb /= 10;
//    }
//    if (is_negative) {
//        *(--ptr) = '-';
//    }
//    return ptr;
//}
//
//
//char* Uppercase(char* str1) {
//    char* ptr = str1;
//    while (*ptr) {
//        if (*ptr >= 'a' && *ptr <= 'z') {
//            *ptr -= ('a' - 'A');
//        }
//        ptr++;
//    }
//    return str1;
//}
//
//char* Lowercase(char* str1) {
//    char* ptr = str1;
//    while (*ptr) {
//        if (*ptr >= 'A' && *ptr <= 'Z') {
//            *ptr += ('a' - 'A');
//        }
//        ptr++;
//    }
//    return str1;
//}
//
//char* mystrrev(char* str) {
//    char* reversed = new char[strlen(str) + 1];
//    if (!reversed) {
//        return nullptr;
//    }
//    for (int i = 0; i < strlen(str); i++) {
//        reversed[i] = str[strlen(str) - 1 - i];
//    }
//    reversed[strlen(str)] = '\0';
//    return reversed;
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    char str_frst[1000], str_sec[1000];
//    cout << "������ �����: ";
//    fgets(str_frst, sizeof(str_frst), stdin);
//    cout << "������ �����: ";
//    fgets(str_sec, sizeof(str_sec), stdin);
//    cout << mystrcmp(str_frst, str_sec) << endl;
//
//    char numStr[12];
//    cout << "����� � �����: ";
//    fgets(numStr, sizeof(numStr), stdin);
//    numStr[strcspn(numStr, "\n")] = '\0';
//    cout << StringToNumber(numStr) << endl;
//
//    int num;
//    cout << "����� � �����: ";
//    cin >> num;
//    cin.ignore();
//    cout << NumberToString(num) << endl;
//
//    char str1[1000];
//    cout << "������ ������ � �������: ";
//    fgets(str1, sizeof(str1), stdin);
//    cout << "Uppercase: " << Uppercase(str1) << endl;
//
//    char str2[1000];
//    cout << "������� ������ � ������: ";
//    fgets(str2, sizeof(str2), stdin);
//    cout << "Lowercase: " << Lowercase(str2) << endl;
//
//    char str3[1000];
//    cout << "������ �����: ";
//    fgets(str3, sizeof(str3), stdin);
//    cout << mystrrev(str3);
//}

//*void add_col(int**& arr, int& rows, int& cols, int* new_col, int pos) {
//    if (pos < 0 || pos > cols) {
//        cout << "����������� ������� ���������!" << endl;
//        return;
//    }
//    int** new_arr = new int* [rows];
//    for (int i = 0; i < rows; i++)
//    {
//        new_arr[i] = new int[cols + 1];
//    }
//    for (int i = 0; i < rows; i++) {
//        for (int j = 0; j < pos; j++) {
//            new_arr[i][j] = arr[i][j];
//        }
//        new_arr[i][pos] = new_col[i];
//        for (int j = pos; j < cols; j++) {
//            new_arr[i][j + 1] = arr[i][j];
//        }
//    }
//    for (int i = 0; i < rows; i++) {
//        delete[] arr[i];
//    }
//    delete[] arr;
//    arr = new_arr;
//    cols++;
//}
//
//void del_col(int**& arr, int& rows, int& cols, int pos) {
//    if (pos < 0 || pos >= cols) {
//        cout << "����������� ������� ���������!" << endl;
//        return;
//    }
//    int** new_arr = new int* [rows];
//    for (int i = 0; i < rows; i++)
//    {
//        new_arr[i] = new int[cols - 1];
//    }
//    for (int i = 0; i < rows; i++) {
//        for (int j = 0; j < pos; j++) {
//            new_arr[i][j] = arr[i][j];
//        }
//        for (int j = pos; j < cols - 1; j++) {
//            new_arr[i][j] = arr[i][j + 1];
//        }
//    }
//    for (int i = 0; i < rows; i++) {
//        delete[] arr[i];
//    }
//    delete[] arr;
//    arr = new_arr;
//    cols--;
//}
//
//void print_arr(int** arr, int rows, int cols) {
//    for (int i = 0; i < rows; i++) {
//        for (int j = 0; j < cols; j++) {
//            cout << arr[i][j] << "\t";
//        }
//        cout << "\n\n";
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int rows = 2;
//    int cols = 3;
//    srand(time(NULL));
//    int** arr = new int* [rows];
//    for (int i = 0; i < rows; i++) {
//        arr[i] = new int[cols];
//    }
//    for (int i = 0; i < rows; i++)
//    {
//        for (int j = 0; j < cols; j++)
//        {
//            arr[i][j] = rand() % 21;
//        }
//    }
//    cout << "���������� �������:" << endl;
//    print_arr(arr, rows, cols);
//    //1
//    cout << "������ �������� ������ ��������� (�� ������ �������� �� �����): ";
//    int* new_col = new int[rows];
//    for (int i = 0; i < rows; i++) {
//        cin >> new_col[i];
//    }
//    int pos;
//    cout << "������ ������� ��� ��������� ���������: ";
//    cin >> pos;
//    add_col(arr, rows, cols, new_col, pos - 1);
//    cout << "������� ���� ��������� ���������:" << endl;
//    print_arr(arr, rows, cols);
//    //2
//    cout << "������ ������� ��������� ��� ���������: ";
//    cin >> pos;
//    del_col(arr, rows, cols, pos - 1);
//    cout << "������� ���� ��������� ���������:" << endl;
//    print_arr(arr, rows, cols);
//}*/
//
//void shift_rows(int**& arr, int rows, int cols, int shift, bool up) {
//    if (shift < 0) shift += shift * 2;
//    int** new_arr = new int* [rows];
//    for (int i = 0; i < rows; i++) {
//        new_arr[i] = new int[cols];
//    }
//    if (up) {
//        for (int i = 0; i < rows; i++) {
//            for (int j = 0; j < cols; j++) {
//                new_arr[i][j] = arr[(i + shift) % rows][j];
//            }
//        }
//    }
//    else {
//        for (int i = 0; i < rows; i++) {
//            for (int j = 0; j < cols; j++) {
//                new_arr[i][j] = arr[(i - shift + rows) % rows][j];
//            }
//        }
//    }
//    for (int i = 0; i < rows; ++i) {
//        delete[] arr[i];
//    }
//    delete[] arr;
//    arr = new_arr;
//}
//
//void shift_columns(int**& arr, int rows, int cols, int shift, bool left) {
//    if (shift < 0) shift += shift * 2;
//    int** new_arr = new int* [rows];
//    for (int i = 0; i < rows; ++i) {
//        new_arr[i] = new int[cols];
//    }
//    if (left) {
//        for (int i = 0; i < rows; ++i) {
//            for (int j = 0; j < cols; ++j) {
//                new_arr[i][j] = arr[i][(j + shift) % cols];
//            }
//        }
//    }
//    else {
//        for (int i = 0; i < rows; ++i) {
//            for (int j = 0; j < cols; ++j) {
//                new_arr[i][j] = arr[i][(j - shift + cols) % cols];
//            }
//        }
//    }
//    for (int i = 0; i < rows; ++i) {
//        delete[] arr[i];
//    }
//    delete[] arr;
//    arr = new_arr;
//}
//
//void printMatrix(int** arr, int rows, int cols) {
//    for (int i = 0; i < rows; ++i) {
//        for (int j = 0; j < cols; ++j) {
//            cout << arr[i][j] << "\t";
//        }
//        cout << "\n\n";
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    srand(time(NULL));
//    int rows, cols;
//    cout << "������ ������� ����� (M): ";
//    cin >> rows;
//    cout << "������ ������� �������� (N): ";
//    cin >> cols;
//    int** arr = new int* [rows];
//    for (int i = 0; i < rows; i++)
//    {
//        arr[i] = new int[cols];
//    }
//    for (int i = 0; i < rows; ++i) {
//        for (int j = 0; j < cols; ++j) {
//            arr[i][j] = rand() % 21;
//        }
//    }
//    cout << "��������� �������:" << endl;
//    printMatrix(arr, rows, cols);
//    int shift;
//    bool dir;
//    cout << "������ ������� ����� �����: ";
//    cin >> shift;
//    cout << "������ �������� ����� ����� (1 - �����, 0 - ����): ";
//    cin >> dir;
//    shift_rows(arr, rows, cols, shift, dir);
//    cout << "������� ���� ����� �����:" << endl;
//    printMatrix(arr, rows, cols);
//    cout << "������ ������� ����� ���������: ";
//    cin >> shift;
//    cout << "������ �������� ����� ��������� (1 - ����, 0 - ������): ";
//    cin >> dir;
//    shift_columns(arr, rows, cols, shift, dir);
//    cout << "������� ���� ����� ���������:" << endl;
//    printMatrix(arr, rows, cols);
//}

//*void tran(const int arr[3][3], int tran_arr[3][3]) {
//    for (int i = 0; i < 3; ++i) {
//        for (int j = 0; j < 3; ++j) {
//            tran_arr[j][i] = arr[i][j];
//        }
//    }
//}
//
//void print_arr(const int arr[3][3]) {
//    for (int i = 0; i < 3; ++i) {
//        for (int j = 0; j < 3; ++j) {
//            cout << arr[i][j] << " ";
//        }
//        cout << endl;
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int arr[3][3] = {
//        {1, 2, 3},
//        {4, 5, 6},
//        {7, 8, 9}
//    };
//    int tran_arr[3][3];
//    cout << "�� ������������� �������:\n";
//    print_arr(arr);
//    tran(arr, tran_arr);
//    cout << "������������� �������:\n";
//    print_arr(tran_arr);
//}*/
//
//char** add(char** arr, int& count) {
//    char** new_arr = new char* [2];
//    for (int i = 0; i < 2; i++)
//    {
//        new_arr[i] = new char[count + 1];
//    }
//    for (int i = 0; i < count; i++)
//    {
//        strcpy_s(&new_arr[0][i], 100, &arr[0][i]);
//        strcpy_s(&new_arr[1][i], 20, &arr[1][i]);
//    }
//    cin.ignore();
//    cout << "������ ��'�: ";
//    fgets(&new_arr[0][count], 100, stdin);
//    cout << "������ ����� ��������: ";
//    fgets(&new_arr[1][count], 20, stdin);
//    if (count > 0)
//    {
//        delete[] arr;
//    }
//    count++;
//    return new_arr;
//}
//
//void srch_name(char** arr, int count) {
//    char name[100];
//    cin.ignore();
//    cout << "������ ��'� ��� ������: ";
//    fgets(name, sizeof(name), stdin);
//    bool found = false;
//    for (int i = 0; i < count; ++i) {
//        if (strcmp(&arr[0][i], name) == 0) {
//            cout << "����� ��������:\n";
//            cout << "��'�: " << &arr[0][i] << endl;
//            cout << "����� ��������: " << &arr[1][i] << endl;
//            found = true;
//            break;
//        }
//    }
//    if (!found) {
//        cout << "����� �� ��������.\n";
//    }
//}
//
//void srch_phone(char** arr, int count) {
//    char phone[20];
//    cin.ignore();
//    cout << "������ ����� �������� ��� ������: ";;
//    fgets(phone, sizeof(phone), stdin);
//    bool found = false;
//    for (int i = 0; i < count; ++i) {
//        if (strcmp(&arr[1][i], phone) == 0) {
//            cout << "����� ��������:\n";
//            cout << "��'�: " << arr[0][i] << endl;
//            cout << "����� ��������: " << arr[1][i] << endl;
//            found = true;
//            break;
//        }
//    }
//    if (!found) {
//        cout << "����� �� ��������.\n";
//    }
//}
//
//void edit(char** arr, int count) {
//    int ch;
//    for (int i = 0; i < count; i++)
//    {
//        cout << i + 1 << ".\n��`�: " << &arr[0][i] << "�����: " << &arr[1][i] << "\n\n";
//    }
//    cout << "������ ����� ������ ��� ����: ";
//    cin >> ch;
//    if (ch<1 || ch>count) {
//        cout << "����� �� ��������.\n";
//    }
//    else
//    {
//        cin.ignore();
//        cout << "������ ��'�: ";
//        fgets(&arr[0][ch - 1], 100, stdin);
//        cout << "������ ����� ��������: ";
//        fgets(&arr[1][ch - 1], 20, stdin);
//        cout << "����� ��������.\n";
//    }
//}
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int count = 0;
//    char** arr = new char*[0];
//    int choice = 0;
//    while (choice != 5) {
//        cout << "\n����:\n";
//        cout << "1. ������ ����� �����\n";
//        cout << "2. ����� �� ��'��\n";
//        cout << "3. ����� �� ������� ��������\n";
//        cout << "4. ���� ������\n";
//        cout << "5. �����\n";
//        cout << "��� ����: ";
//        cin >> choice;
//        if (choice == 1) {
//            arr = add(arr, count);
//        }
//        else if (choice == 2) {
//            if (count > 0)
//            {
//                srch_name(arr, count);
//            }
//            else
//            {
//                cout << "���� ������\n";
//            }
//        }
//        else if (choice == 3) {
//            if (count > 0)
//            {
//                srch_phone(arr, count);
//            }
//            else
//            {
//                cout << "���� ������\n";
//            }
//        }
//        else if (choice == 4) {
//            if (count > 0)
//            {
//                edit(arr, count);
//            }
//            else
//            {
//                cout << "���� ������\n";
//            }
//        }
//        else if (choice == 5) {
//            cout << "����� � ��������.\n";
//        }
//        else {
//            cout << "������������ ����. ��������� �� ���.\n";
//        }
//    }
//}

//#include <string>
//struct Complex {
//	double real;
//	double imag;
//};
//
//struct Car {
//	int length;
//	int clearance;
//	int engine_volume;
//	int engine_power;
//	int wheel_diameter;
//	string color;
//	string transmission_type;
//
//	void out() const {
//		cout << "�������: " << length << " �����\n";
//		cout << "������: " << clearance << " �����\n";
//		cout << "��'�� �������: " << engine_volume << " ����\n";
//		cout << "���������� �������: " << engine_power << " ������� ���\n";
//		cout << "ĳ����� ����: " << wheel_diameter << " �����\n";
//		cout << "����: " << color << "\n";
//		cout << "��� ������� �������: " << transmission_type << "\n";
//	}
//};
//
//void set_values(Car cars[]) {
//	for (int i = 0; i < 5; i++) {
//		cout << "������ ���� ��� ��������� " << (i + 1) << ":\n";
//		cout << "�������: ";
//		cin >> cars[i].length;
//		cout << "������: ";
//		cin >> cars[i].clearance;
//		cout << "��'�� �������: ";
//		cin >> cars[i].engine_volume;
//		cout << "���������� �������: ";
//		cin >> cars[i].engine_power;
//		cout << "ĳ����� ����: ";
//		cin >> cars[i].wheel_diameter;
//		cin.ignore();
//		cout << "����: ";
//		getline(cin, cars[i].color);
//		cout << "��� ������� �������: ";
//		getline(cin, cars[i].transmission_type);
//	}
//}
//
//void srch_color(const Car cars[]) {
//	string color;
//	cout << "������ ���� ��� ������: ";
//	cin.ignore();
//	getline(cin, color);
//	bool found = false;
//	for (int i = 0; i < 5; ++i) {
//		if (cars[i].color == color) {
//			cars[i].out();
//			found = true;
//		}
//	}
//	if (!found) {
//		cout << "�������� � �������� " << color << " �� ��������.\n";
//	}
//}
//
//void srch_tr_type(Car cars[]) {
//	string trans_type;
//	cout << "������ ��� ������� ������� ��� ������: ";
//	cin.ignore();
//	getline(cin, trans_type);
//	bool found = false;
//	for (int i = 0; i < 5; ++i) {
//		if (cars[i].transmission_type == trans_type) {
//			cars[i].out();
//			found = true;
//		}
//	}
//	if (!found) {
//		cout << "�������� � ����� ������� ������� " << trans_type << " �� ��������.\n";
//	}
//}
//
//void out_arr(Car cars[]) {
//	bool found = false;
//	for (int i = 0; i < 5; ++i) {
//		cout << i + 1 << ".\n";
//		cars[i].out();
//	}
//}
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	/*Complex n1, n2;
//	cout << "������ ����� �� ����� ������� 1: ";
//	cin >> n1.real >> n1.imag;
//	cout << "������ ����� �� ����� ������� 2: ";
//	cin >> n2.real >> n2.imag;
//	cout << "real: " << n1.real << " + " << n2.real << " = " << n1.real + n2.real << endl
//		<< "imag: " << n1.imag << " + " << n2.imag << " = " << n1.imag + n2.imag << endl;
//	cout << "real: " << n1.real << " - " << n2.real << " = " << n1.real - n2.real << endl
//		<< "imag: " << n1.imag << " - " << n2.imag << " = " << n1.imag - n2.imag << endl;
//	cout << "real: " << n1.real << " * " << n2.real << " = " << n1.real * n2.real << endl
//		<< "imag: " << n1.imag << " * " << n2.imag << " = " << n1.imag * n2.imag << endl;
//	if (n2.real = 0)
//	{
//		cout << "real: " << n1.real << " : " << n2.real << " = " << "error" << endl;
//	}
//	else
//	{
//		cout << "real: " << n1.real << " : " << n2.real << " = " << n1.real / n2.real << endl;
//	}
//	if (n2.imag = 0)
//	{
//		cout << "imag: " << n1.imag << " : " << n2.imag << " = " << "error" << endl;
//	}
//	else
//	{
//		cout << "imag: " << n1.imag << " : " << n2.imag << " = " << n1.imag / n2.imag << endl;
//	}*/
//	//2
//	Car* cars = new Car[5];
//	int choice = 0;
//	while (choice != 4) {
//		cout << "\n����:\n";
//		cout << "1. ������ ��������\n";
//		cout << "2. ³��������� ��������\n";
//		cout << "3. ����� �������\n";
//		cout << "4. �����\n";
//		cout << "��� ����: ";
//		cin >> choice;
//
//		if (choice == 1) {
//			set_values(cars);
//		}
//		else if (choice == 2) {
//			out_arr(cars);
//		}
//		else if (choice == 3) {
//			int searchChoice;
//			cout << "\n���� ������:\n";
//			cout << "1. ����� �� ��������\n";
//			cout << "2. ����� �� ����� ������� �������\n";
//			cout << "��� ����: ";
//			cin >> searchChoice;
//
//			if (searchChoice == 1) {
//				srch_color(cars);
//			}
//			else if (searchChoice == 2) {
//				srch_tr_type(cars);
//			}
//			else {
//				cout << "������������ ���� ������.\n";
//			}
//		}
//		else if (choice == 4) {
//			cout << "����� � ��������.\n";
//		}
//		else {
//			cout << "������������ ����. ��������� �� ���.\n";
//		}
//	}
//}

//*struct Car {
//    string color;
//    string model;
//    union Number {
//        int number;
//        char word[9];
//    } number;
//    bool is_number;
//
//    void fill() {
//        cout << "������ ����: ";
//        getline(cin, color);
//        cout << "������ ������: ";
//        getline(cin, model);
//
//        cout << "������ ����� (5-������� ��� ����� �� 8 �������): ";
//        char input[9];
//        cin.getline(input, 9);
//
//        bool is_digit = true;
//        for (int i = 0; input[i] != '\0'; ++i) {
//            if (input[i] < '0' || input[i] > '9') {
//                is_digit = false;
//                break;
//            }
//        }
//
//        if (is_digit && strlen(input) == 5) {
//            number.number = atoi(input);
//            is_number = true;
//        }
//        else {
//            strcpy(number.word, input);
//            is_number = false;
//        }
//    }
//
//    void print() const {
//        cout << "����: " << color << "\n";
//        cout << "������: " << model << "\n";
//        cout << "�����: ";
//        if (is_number) {
//            cout << number.number << "\n";
//        }
//        else {
//            cout << number.word << "\n";
//        }
//    }
//};
//
//void editCar(Car& car) {
//    cout << "����������� ������:\n";
//    car.fill();
//}
//
//void printAllCars(const Car cars[], int count) {
//    for (int i = 0; i < count; ++i) {
//        cout << "������ " << (i + 1) << ":\n";
//        cars[i].print();
//        cout << endl;
//    }
//}
//
//void searchByNumber(const Car cars[], int count, const char* search_number) {
//    bool found = false;
//    for (int i = 0; i < count; ++i) {
//        if (cars[i].is_number) {
//            if (atoi(search_number) == cars[i].number.number) {
//                cars[i].print();
//                found = true;
//                break;
//            }
//        }
//        else {
//            if (strcmp(cars[i].number.word, search_number) == 0) {
//                cars[i].print();
//                found = true;
//                break;
//            }
//        }
//    }
//    if (!found) {
//        cout << "������ � ������� " << search_number << " �� ��������.\n";
//    }
//}
//
//int main() {
//    const int max_cars = 10;
//    Car cars[max_cars];
//    int count = 0;
//
//    while (true) {
//        cout << "����:\n";
//        cout << "1. ��������� ���� ������\n";
//        cout << "2. ���� ��� �����\n";
//        cout << "3. ���������� ������\n";
//        cout << "4. ����� �� �������\n";
//        cout << "5. �����\n";
//        cout << "������� �����: ";
//
//        int choice;
//        cin >> choice;
//        cin.ignore();
//
//        if (choice == 1) {
//            if (count < max_cars) {
//                cout << "���������� ������ " << (count + 1) << ":\n";
//                cars[count].fill();
//                count++;
//            }
//            else {
//                cout << "����� ����� ����������.\n";
//            }
//        }
//        else if (choice == 2) {
//            printAllCars(cars, count);
//        }
//        else if (choice == 3) {
//            int index;
//            cout << "������ ������ ������ ��� ����������� (1 �� " << count << "): ";
//            cin >> index;
//            cin.ignore();
//            if (index >= 1 && index <= count) {
//                editCar(cars[index - 1]);
//            }
//            else {
//                cout << "������������ ������.\n";
//            }
//        }
//        else if (choice == 4) {
//            char search_number[9];
//            cout << "������ ����� ��� ������: ";
//            cin.getline(search_number, 9);
//            searchByNumber(cars, count, search_number);
//        }
//        else if (choice == 5) {
//            cout << "����� � ��������.\n";
//            break;
//        }
//        else {
//            cout << "������������ ����. ���� �����, ��������� �� ���.\n";
//        }
//    }
//}*/
//
//enum Entity_Type {
//    BIRD,
//    CATTLE,
//    HUMAN
//};
//
//union Characteristic {
//    double flight_speed;
//    bool is_even_toed;
//    int iq_level;
//};
//
//struct Living_Entity {
//    double speed;
//    Entity_Type type;
//    string color;
//    Characteristic characteristic;
//
//    void input() {
//        cout << "������ �������� ����������� (��/���): ";
//        cin >> speed;
//        cin.ignore();
//
//        cout << "������ ��� (0 - ����, 1 - ������, 2 - ������): ";
//        int type_input;
//        cin >> type_input;
//        cin.ignore();
//        if (type_input == 0) type = BIRD;
//        else if (type_input == 1) type = CATTLE;
//        else if (type_input == 2) type = HUMAN;
//
//        cout << "������ ����: ";
//        getline(cin, color);
//
//        if (type == BIRD) {
//            cout << "������ �������� ������� (��/���): ";
//            cin >> characteristic.flight_speed;
//        }
//        else if (type == CATTLE) {
//            cout << "������, �� � ������������� (0 - ��, 1 - ���): ";
//            int is_even_toed_input;
//            cin >> is_even_toed_input;
//            characteristic.is_even_toed = (is_even_toed_input == 1);
//        }
//        else if (type == HUMAN) {
//            cout << "������ ����� IQ: ";
//            cin >> characteristic.iq_level;
//        }
//        cin.ignore();
//    }
//
//    void print() const {
//        cout << "�������� �����������: " << speed << " ��/���\n";
//        cout << "���: ";
//        if (type == BIRD) {
//            cout << "����\n";
//            cout << "�������� �������: " << characteristic.flight_speed << " ��/���\n";
//        }
//        else if (type == CATTLE) {
//            cout << "������\n";
//            cout << "������������: " << (characteristic.is_even_toed ? "���" : "ͳ") << "\n";
//        }
//        else if (type == HUMAN) {
//            cout << "������\n";
//            cout << "г���� IQ: " << characteristic.iq_level << "\n";
//        }
//        cout << "����: " << color << "\n";
//    }
//};
//
//void edit_entity(Living_Entity& entity) {
//    cout << "����������� �����:\n";
//    entity.input();
//}
//
//void print_all_entities(const Living_Entity entities[], int count) {
//    for (int i = 0; i < count; ++i) {
//        cout << "�������� " << (i + 1) << ":\n";
//        entities[i].print();
//        cout << endl;
//    }
//}
//
//void search_by_characteristic(const Living_Entity entities[], int count, Entity_Type type) {
//    bool found = false;
//    for (int i = 0; i < count; ++i) {
//        if (entities[i].type == type) {
//            entities[i].print();
//            found = true;
//        }
//    }
//    if (!found) {
//        cout << "��������� ���� �� ��������.\n";
//    }
//}
//
//int main() {
//    const int max_entities = 10;
//    Living_Entity entities[max_entities];
//    int count = 0;
//
//    while (true) {
//        cout << "����:\n";
//        cout << "1. ������ ���� �������\n";
//        cout << "2. ���� ��� ���������\n";
//        cout << "3. ���������� ��������\n";
//        cout << "4. ����� �� ���������������\n";
//        cout << "5. �����\n";
//        cout << "������� �����: ";
//
//        int choice;
//        cin >> choice;
//        cin.ignore();
//
//        if (choice == 1) {
//            if (count < max_entities) {
//                cout << "�������� ����� ������� " << (count + 1) << ":\n";
//                entities[count].input();
//                count++;
//            }
//            else {
//                cout << "����� ��������� ����������.\n";
//            }
//        }
//        else if (choice == 2) {
//            print_all_entities(entities, count);
//        }
//        else if (choice == 3) {
//            int index;
//            cout << "������ ������ ������� ��� ����������� (1 �� " << count << "): ";
//            cin >> index;
//            cin.ignore();
//            if (index >= 1 && index <= count) {
//                edit_entity(entities[index - 1]);
//            }
//            else {
//                cout << "������������ ������.\n";
//            }
//        }
//        else if (choice == 4) {
//            cout << "������ ��� ������� ��� ������ (0 - ����, 1 - ������, 2 - ������): ";
//            int type_input;
//            cin >> type_input;
//            cin.ignore();
//            if (type_input == 0) search_by_characteristic(entities, count, BIRD);
//            else if (type_input == 1) search_by_characteristic(entities, count, CATTLE);
//            else if (type_input == 2) search_by_characteristic(entities, count, HUMAN);
//        }
//        else if (choice == 5) {
//            cout << "����� � ��������.\n";
//            break;
//        }
//        else {
//            cout << "������������ ����. ���� �����, ��������� �� ���.\n";
//        }
//    }
//}

//bool is_vowel(char c) {
//	char lower_c = c | 0x20;
//	return lower_c == 'a' || lower_c == 'e' || lower_c == 'i' || lower_c == 'o' || lower_c == 'u';
//}
//
//bool is_consonant(char c) {
//	char lower_c = c | 0x20;
//	return (lower_c >= 'a' && lower_c <= 'z') && !is_vowel(c);
//}
//
//char caesar_cipher(char c, int shift) {
//	if (c >= 'A' && c <= 'Z') {
//		return (c - 26 + shift) % 26 + 'A';
//	}
//	else if (c >= 'a' && c <= 'z') {
//		return (c - '�' + shift) % 26 + 'a';
//	}
//	else {
//		return c;
//	}
//}
//
//#include <fstream>
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	/*char f1_t[1000];
//	char f2_t[1000];
//	char path[255];
//	FILE* f;
//	cout << "������ ���� �� 1 �����: ";
//	cin >> path;
//	fopen_s(&f, path, "r");
//	fscanf(f, "%s", f1_t);
//	fclose(f);
//	cout << "������ ���� �� 2 �����: ";
//	cin >> path;
//	fopen_s(&f, path, "r");
//	fscanf(f, "%s", f2_t);
//	fclose(f);
//	if (strcmp(f1_t, f2_t) == 0)
//	{
//		cout << "����� �������";
//	}
//	else
//	{
//		cout << f1_t << endl << f2_t;
//	}
//	char path[255];
//	int chars = 0;
//	int line = 0;
//	int vowel = 0;
//	int consonant = 0;
//	int digit = 0;
//	char c;
//	cout << "������ ���� �� �����: ";
//	cin >> path;
//	ifstream f(path);
//	while (f.get(c)) {
//		chars++;
//		if (c == '\n') {
//			line++;
//		}
//		if (c >= '0' && c <= '9') {
//			digit++;
//		}
//		else if (is_vowel(c)) {
//			vowel++;
//		}
//		else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) {
//			consonant++;
//		}
//	}
//	f.close();
//	cout << "������ ���� �� 2 �����: ";
//	cin >> path;
//	ofstream f1(path);
//	f1 << "ʳ������ �������: " << chars << endl;
//	f1 << "ʳ������ �����: " << line << endl;
//	f1 << "ʳ������ �������� ����: " << vowel << endl;
//	f1 << "ʳ������ ����������� ����: " << consonant << endl;
//	f1 << "ʳ������ ����: " << digit << endl;*/
//	char path[255];
//	char c;
//	int shift;
//	cout << "������ ���� �� �����: ";
//	cin >> path;
//	ifstream f_in(path);
//	cout << "������ ���� �� 2 �����: ";
//	cin >> path;
//	ofstream f_out(path);
//	cout << "������ ���� (���� �����): ";
//	cin >> shift;
//	while (f_in.get(c)) {
//		f_out << caesar_cipher(c, shift);
//	}
//}

//class Fraction {
//private:
//    int numerator;
//    int denominator;
//
//    int gcd(int a, int b) const {
//        while (b != 0) {
//            int temp = b;
//            b = a % b;
//            a = temp;
//        }
//        return a;
//    }
//
//    void simplify() {
//        int gcd_value = gcd(numerator, denominator);
//        numerator /= gcd_value;
//        denominator /= gcd_value;
//        if (denominator < 0) {
//            denominator = -denominator;
//            numerator = -numerator;
//        }
//    }
//
//public:
//    Fraction(int num = 0, int denom = 1) : numerator(num), denominator(denom) {
//        if (denominator == 0) {
//            cout << "�������: ��������� �� ���� ���� ��������." << endl;
//            denominator = 1;
//        }
//        simplify();
//    }
//
//    void input() {
//        cout << "������ ���������: ";
//        cin >> numerator;
//        cout << "������ ���������: ";
//        cin >> denominator;
//        if (denominator == 0) {
//            cout << "�������: ��������� �� ���� ���� ��������." << endl;
//            denominator = 1;
//        }
//        simplify();
//    }
//
//    void print() const {
//        cout << numerator << '/' << denominator << endl;
//    }
//
//    Fraction operator+(const Fraction& other) const {
//        int num = numerator * other.denominator + other.numerator * denominator;
//        int denom = denominator * other.denominator;
//        return Fraction(num, denom);
//    }
//
//    Fraction operator-(const Fraction& other) const {
//        int num = numerator * other.denominator - other.numerator * denominator;
//        int denom = denominator * other.denominator;
//        return Fraction(num, denom);
//    }
//
//    Fraction operator*(const Fraction& other) const {
//        int num = numerator * other.numerator;
//        int denom = denominator * other.denominator;
//        return Fraction(num, denom);
//    }
//
//    Fraction operator/(const Fraction& other) const {
//        if (other.numerator == 0) {
//            cout << "�������: ��������� ������� �� ����." << endl;
//            return *this;
//        }
//        int num = numerator * other.denominator;
//        int denom = denominator * other.numerator;
//        return Fraction(num, denom);
//    }
//};
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//
//    Fraction f1, f2;
//
//    cout << "������ ������ ���:" << endl;
//    f1.input();
//    cout << "������ ������ ���:" << endl;
//    f2.input();
//
//    cout << "������ ���: ";
//    f1.print();
//    cout << "������ ���: ";
//    f2.print();
//
//    Fraction sum = f1 + f2;
//    cout << "����: ";
//    sum.print();
//
//    Fraction diff = f1 - f2;
//    cout << "г�����: ";
//    diff.print();
//
//    Fraction prod = f1 * f2;
//    cout << "�������: ";
//    prod.print();
//
//    Fraction quot = f1 / f2;
//    cout << "������: ";
//    quot.print();
//}

//class People {
//private:
//    char* name;
//    int age;
//
//public:
//    People() : name(nullptr), age(0) {}
//
//    People(const char* name, int age) : age(age) {
//        this->name = new char[strlen(name) + 1];
//        strcpy(this->name, name);
//    }
//
//    People(const People& other) : age(other.age) {
//        if (other.name) {
//            name = new char[strlen(other.name) + 1];
//            strcpy(name, other.name);
//        }
//        else {
//            name = nullptr;
//        }
//    }
//
//    ~People() {
//        delete[] name;
//    }
//
//    People& operator=(const People& other) {
//        if (this == &other) return *this;
//        delete[] name;
//        age = other.age;
//        if (other.name) {
//            name = new char[strlen(other.name) + 1];
//            strcpy(name, other.name);
//        }
//        else {
//            name = nullptr;
//        }
//        return *this;
//    }
//
//    void display() const {
//        if (name) {
//            cout << "��'�: " << name << ", ³�: " << age << endl;
//        }
//    }
//};
//
//class Apartment {
//private:
//    People* people;
//    int num_people;
//
//public:
//    Apartment() : people(nullptr), num_people(0) {}
//
//    Apartment(int num_people) : num_people(num_people) {
//        people = new People[num_people];
//    }
//
//    Apartment(const Apartment& other) : num_people(other.num_people) {
//        people = new People[num_people];
//        for (int i = 0; i < num_people; ++i) {
//            people[i] = other.people[i];
//        }
//    }
//
//    ~Apartment() {
//        delete[] people;
//    }
//
//    Apartment& operator=(const Apartment& other) {
//        if (this == &other) return *this;
//        delete[] people;
//        num_people = other.num_people;
//        people = new People[num_people];
//        for (int i = 0; i < num_people; ++i) {
//            people[i] = other.people[i];
//        }
//        return *this;
//    }
//
//    void add_people(int index, const People& person) {
//        if (index >= 0 && index < num_people) {
//            people[index] = person;
//        }
//    }
//
//    void display() const {
//        cout << "�������� ��������:" << endl;
//        for (int i = 0; i < num_people; ++i) {
//            people[i].display();
//        }
//    }
//};
//
//class Building {
//private:
//    Apartment* apartments;
//    int num_apartments;
//
//public:
//    Building() : apartments(nullptr), num_apartments(0) {}
//
//    Building(int num_apartments, int people_per_apartment) : num_apartments(num_apartments) {
//        apartments = new Apartment[num_apartments];
//        for (int i = 0; i < num_apartments; ++i) {
//            apartments[i] = Apartment(people_per_apartment);
//        }
//    }
//
//    Building(const Building& other) : num_apartments(other.num_apartments) {
//        apartments = new Apartment[num_apartments];
//        for (int i = 0; i < num_apartments; ++i) {
//            apartments[i] = other.apartments[i];
//        }
//    }
//
//    ~Building() {
//        delete[] apartments;
//    }
//
//    Building& operator=(const Building& other) {
//        if (this == &other) return *this;
//        delete[] apartments;
//        num_apartments = other.num_apartments;
//        apartments = new Apartment[num_apartments];
//        for (int i = 0; i < num_apartments; ++i) {
//            apartments[i] = other.apartments[i];
//        }
//        return *this;
//    }
//
//    void add_people_to_apartment(int apartment_index, int people_index, const People& person) {
//        if (apartment_index >= 0 && apartment_index < num_apartments) {
//            apartments[apartment_index].add_people(people_index, person);
//        }
//    }
//
//    void display() const {
//        cout << "�������� �������:" << endl;
//        for (int i = 0; i < num_apartments; ++i) {
//            apartments[i].display();
//        }
//    }
//};
//
//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//
//    int num_apartments, people_per_apartment;
//
//    cout << "������ ������� ������� � �������: ";
//    cin >> num_apartments;
//    cout << "������ ������� ����� � ������ �������: ";
//    cin >> people_per_apartment;
//
//    Building building(num_apartments, people_per_apartment);
//
//    for (int i = 0; i < num_apartments; ++i) {
//        cout << "�������� " << i + 1 << ":" << endl;
//        for (int j = 0; j < people_per_apartment; ++j) {
//            char name[100];
//            int age;
//            cout << "������ ��'� ������ " << j + 1 << ": ";
//            cin.ignore();
//            cin.getline(name, 100);
//            cout << "������ �� ������ " << j + 1 << ": ";
//            cin >> age;
//            People person(name, age);
//            building.add_people_to_apartment(i, j, person);
//        }
//    }
//
//    cout << "���������� ������:" << endl;
//    building.display();
//
//    Building building_copy = building;
//    cout << "���� �����:" << endl;
//    building_copy.display();
//}

//class String {
//private:
//    char* str;
//    static int count;
//
//public:
//    String() {
//        str = new char[80];
//        str[0] = '\0';
//        count++;
//    }
//
//    String(int size) {
//        str = new char[size + 1];
//        str[0] = '\0';
//        count++;
//    }
//
//    String(const char* init_str) {
//        int size = strlen(init_str);
//        str = new char[size + 1];
//        strcpy(str, init_str);
//        count++;
//    }
//
//    ~String() {
//        delete[] str;
//        count--;
//    }
//
//    void input() {
//        cout << "������ �����: ";
//        cin.ignore();
//        cin.getline(str, 80);
//    }
//
//    void output() const {
//        cout << str << endl;
//    }
//
//    static int get_count() {
//        return count;
//    }
//};
//
//int main() {
//    String str1;
//    String str2(100);
//    String str3("Hello, World!");
//
//    str1.input();
//    str1.output();
//
//    str2.input();
//    str2.output();
//
//    str3.output();
//
//    cout << "ʳ������ ��������� ��'����: " << String::get_count() << endl;
//}

//class Car
//{
//private:
//	string marka;
//	int max_speed;
//	string* owners;
//	int owners_count;
//public:
//	Car() {
//		marka = "none";
//		max_speed = 0;
//		owners = nullptr;
//		owners_count = 0;
//	}
//	Car(string marka_, int max_speed_, string first_owner) {
//		marka = marka_;
//		max_speed = max_speed_;
//		owners = new string[1];
//		owners[0] = first_owner;
//		owners_count = 1;
//	}
//	~Car() {
//		delete[] owners;
//	}
//	void set_maxSpeed() {
//		cout << "������ ����. ��������: ";
//		cin >> max_speed;
//	}
//	int get_maxSpeed() {
//		return max_speed;
//	}
//	void set_marka() {
//		cout << "������ ����� ������: ";
//		cin >> marka;
//	}
//	string get_marka() {
//		return marka;
//	}
//	void add_owner() {
//		string name;
//		cout << "������ ��`� ������ ��������: ";
//		cin >> name;
//		string* new_owners;
//		if (owners == nullptr) {
//			new_owners = new string[1];
//		}
//		else {
//			new_owners = new string[owners_count + 1];
//			for (int i = 0; i < owners_count; i++) {
//				new_owners[i] = owners[i];
//			}
//		}
//		new_owners[owners_count] = name;
//		owners_count++;
//		delete[] owners;
//		owners = new_owners;
//	}
//	void out_owners() {
//		cout << "�������� �� ����� ���:\n";
//		for (int i = 0; i < owners_count; i++)
//		{
//			cout << i + 1 << " - " << owners[i] << endl;
//		}
//	}
//};
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	cout << "���� �1:\n";
//	Car car1;
//	int ch = -1;
//	while (ch != 0)
//	{
//		cout
//			<< "\n����:\n"
//			<< "1 - ������ �����\n"
//			<< "2 - ������ ����. ��������\n"
//			<< "3 - ������ ������ ��������\n"
//			<< "4 - ������� �����\n"
//			<< "5 - ������� ����. ��������\n"
//			<< "6 - ������� ��� ��������\n"
//			<< "0 - �����\n"
//			<< "��� ����: ";
//		cin >> ch;
//		if (ch == 1) {
//			car1.set_marka();
//		}
//		else if (ch == 2) {
//			car1.set_maxSpeed();
//		}
//		else if (ch == 3) {
//			car1.add_owner();
//		}
//		else if (ch == 4) {
//			cout << "�����: " << car1.get_marka() << endl;
//		}
//		else if (ch == 5) {
//			cout << "����. ��������: " << car1.get_maxSpeed() << endl;
//		}
//		else if (ch == 6) {
//			car1.out_owners();
//		}
//		else if (ch == 0) {
//			cout << "�����" << endl;
//		}
//		else {
//			cout << "������� ����" << endl;
//		}
//	}
//	cout << "���� �2:\n";
//	Car car2("BMW", 260, "owner kakoyto");
//	ch = -1;
//	while (ch != 0)
//	{
//		cout
//			<< "\n����:\n"
//			<< "1 - ������ �����\n"
//			<< "2 - ������ ����. ��������\n"
//			<< "3 - ������ ������ ��������\n"
//			<< "4 - ������� �����\n"
//			<< "5 - ������� ����. ��������\n"
//			<< "6 - ������� ��� ��������\n"
//			<< "0 - �����\n"
//			<< "��� ����: ";
//		cin >> ch;
//		if (ch == 1) {
//			car2.set_marka();
//		}
//		else if (ch == 2) {
//			car2.set_maxSpeed();
//		}
//		else if (ch == 3) {
//			car2.add_owner();
//		}
//		else if (ch == 4) {
//			cout << "�����: " << car2.get_marka() << endl;
//		}
//		else if (ch == 5) {
//			cout << "����. ��������: " << car2.get_maxSpeed() << endl;
//		}
//		else if (ch == 6) {
//			car2.out_owners();
//		}
//		else if (ch == 0) {
//			cout << "�����" << endl;
//		}
//		else {
//			cout << "������� ����" << endl;
//		}
//	}
//}

//class bank_acc
//{
//	string login;
//	string password;
//	double balance = 0;
//	string pib;
//	void plus_balance() {
//		double money;
//		cout << "+?: ";
//		cin >> money;
//		balance += money;
//	}
//	void minus_balance() {
//		double money;
//		string pass;
//		cout << "input your password: ";
//		cin >> pass;
//		if (pass == password)
//		{
//			cout << "-?: ";
//			cin >> money;
//			if (money > balance)
//			{
//				cout << "zabagato\n";
//			}
//			else
//			{
//				balance -= money;
//			}
//		}
//		else
//		{
//			cout << "ne virno\n";
//		}
//		
//	}
//	void chek_balance() {
//		cout << "your balance: " << balance << endl;
//	}
//	void change_password() {
//		string old_password;
//		string new_password;
//		cout << "input your password: ";
//		cin >> old_password;
//		if (old_password == password)
//		{
//			cout << "input new password: ";
//			cin >> new_password;
//			password = new_password;
//		}
//		else
//		{
//			cout << "ne virno\n";
//		}
//	}
//public:
//	bank_acc(string login, string password, double balance, string pib) {
//		this->login = login;
//		this->password = password;
//		this->balance = balance;
//		this->pib = pib;
//	}
//	void menu() {
//		int ch = -1;
//		while (ch != 0) {
//			cout
//				<< "\n����:\n"
//				<< "1 - ��������� �������\n"
//				<< "2 - ����� � �������\n"
//				<< "3 - ���������� ������\n"
//				<< "4 - ������ ������\n"
//				<< "0 - �����\n"
//				<< "��� ����: ";
//			cin >> ch;
//			switch (ch)
//			{
//			case 1:
//				plus_balance();
//				break;
//			case 2:
//				minus_balance();
//				break;
//			case 3:
//				chek_balance();
//				break;
//			case 4:
//				change_password();
//				break;
//			case 0:
//				cout << "�����\n";
//				break;
//			default:
//				cout << "������� ����\n";
//				break;
//			}
//		}
//	}
//};
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	bank_acc user1("us1", "pass1", 0.0, "q w e");
//	user1.menu();
//}

//class pryamokutnik
//{
//	double weight;
//	double height;
//	void set_size() {
//		double w, h;
//		cout << "set \"weight height\": ";
//		cin >> w >> h;
//		if (w <= 0 || h <= 0)
//		{
//			cout << "can`t be\n";
//		}
//		else
//		{
//			weight = w;
//			height = h;
//		}
//	}
//	void S() {
//		cout << weight * height << endl;
//	}
//	void P() {
//		cout << 2 * (weight + height) << endl;
//	}
//	void d() {
//		cout << sqrt(pow(weight, 2) + pow(weight, 2)) << endl;
//	}
//	void R() {
//		cout << sqrt(pow(weight, 2) + pow(weight, 2)) / 2 << endl;
//	}
//public:
//	pryamokutnik(double weight, double height) {
//		this->weight = weight;
//		this->height = height;
//	}
//	void menu() {
//		int ch = -1;
//		while (ch != 0) {
//			cout
//				<< "\n����:\n"
//				<< "1 - resize\n"
//				<< "2 - seek S\n"
//				<< "3 - seek P\n"
//				<< "4 - seek d\n"
//				<< "5 - seek R\n"
//				<< "0 - �����\n"
//				<< "��� ����: ";
//			cin >> ch;
//			switch (ch)
//			{
//			case 1:
//				set_size();
//				break;
//			case 2:
//				S();
//				break;
//			case 3:
//				P();
//				break;
//			case 4:
//				d();
//				break;
//			case 5:
//				R();
//				break;
//			case 0:
//				cout << "�����\n";
//				break;
//			default:
//				cout << "������� ����\n";
//				break;
//			}
//		}
//	}
//};
//
//class kvadrat: public pryamokutnik
//{
//	double a;
//	void set_size() {
//		double w;
//		cout << "set a: ";
//		cin >> w;
//		if (w <= 0)
//		{
//			cout << "can`t be\n";
//		}
//		else
//		{
//			a = w;
//		}
//	}
//	void S() {
//		cout << pow(a, 2) << endl;
//	}
//	void P() {
//		cout << 4 * a << endl;
//	}
//	void d() {
//		cout << a * sqrt(2) << endl;
//	}
//	void R() {
//		cout << a * (sqrt(2) / 2) << endl;
//	}
//public:
//	/*kvadrat(double a) {
//		this->a = a;
//	}*/
//	void menu() {
//		int ch = -1;
//		while (ch != 0) {
//			cout
//				<< "\n����:\n"
//				<< "1 - resize\n"
//				<< "2 - seek S\n"
//				<< "3 - seek P\n"
//				<< "4 - seek d\n"
//				<< "5 - seek R\n"
//				<< "0 - �����\n"
//				<< "��� ����: ";
//			cin >> ch;
//			switch (ch)
//			{
//			case 1:
//				set_size();
//				break;
//			case 2:
//				S();
//				break;
//			case 3:
//				P();
//				break;
//			case 4:
//				d();
//				break;
//			case 5:
//				R();
//				break;
//			case 0:
//				cout << "�����\n";
//				break;
//			default:
//				cout << "������� ����\n";
//				break;
//			}
//		}
//	}
//};
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	pryamokutnik p1(10, 5.1);
//	p1.menu();
//	pryamokutnik p1();
//	p1.menu();
//}

//class Car
//{
//	string color;
//	string transmission;
//	int HP;
//	int wheel_count;
//public:
//	Car() {
//		color = "undefined";
//		transmission = "undefined";
//		HP = 0;
//		wheel_count = 0;
//	}
//	Car(string color, string transmission, int HP, int wheel_count) {
//		this->color = color;
//		this->transmission = transmission;
//		this->HP = HP;
//		this->wheel_count = wheel_count;
//	}
//	void ride() {
//		cout << "Riding...\n";
//	}
//	void set_color() {
//		cout << "set color: ";
//		cin >> color;
//	}
//	void get_color() {
//		cout << color;
//	}
//	void set_transmission() {
//		cout << "set transmission: ";
//		cin >> transmission;
//	}
//	void get_transmission() {
//		cout << transmission;
//	}
//	void set_HP() {
//		cout << "set HP: ";
//		cin >> HP;
//	}
//	void get_HP() {
//		cout << HP;
//	}
//	void set_wheel_count() {
//		cout << "set wheel_count: ";
//		cin >> wheel_count;
//	}
//	void get_wheel_count() {
//		cout << wheel_count;
//	}
//	void display() {
//		cout
//			<< "color: " << color << endl
//			<< "transmission: " << transmission << endl
//			<< "HP: " << HP << endl
//			<< "whell count: " << wheel_count << endl;
//	}
//	virtual void from_a_to_b() {}
//};
//
//class Sedan : public Car
//{
//public:
//	using Car::Car;
//	Sedan() : Car("undefined", "undefined", 0, 4) {}
//	Sedan(string color, string transmission, int HP) : Car(color, transmission, HP, 4) {}
//	void from_a_to_b() override {
//		string a, b;
//		cout << "enter first place: ";
//		cin >> a;
//		cout << "enter second place: ";
//		cin >> b;
//		cout << "start from " << a << endl;
//		ride();
//		cout << "enter to " << b << endl;
//
//	}
//};
//
//class Truck : public Car
//{
//	int cargo_weight;
//public:
//	using Car::Car;
//	Truck() : Car("undefined", "undefined", 0, 6), cargo_weight(0) {}
//	Truck(string color, string transmission, int HP) : Car(color, transmission, HP, 6), cargo_weight(0) {}
//	void set_cargo_weight() {
//		cout << "set cargo_weight: ";
//		cin >> cargo_weight;
//	}
//	void get_cargo_weight() {
//		cout << cargo_weight;
//	}
//	void from_a_to_b() override {
//		string a, b;
//		cout << "enter first place: ";
//		cin >> a;
//		cout << "enter second place: ";
//		cin >> b;
//		cout << "enter to the " << a << endl;
//		cout << "take cargo (" << a << ")" << endl;
//		cout << "start from " << a << endl;
//		ride();
//		cout << "enter to " << b << endl;
//		cout << "unhook cargo" << endl;
//	}
//};
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	cout << "Sedan:\n";
//	Sedan s1("red", "manual", 130);
//	s1.from_a_to_b();
//	s1.display();
//	cout << "\n\n";
//	cout << "Truck:\n";
//	Truck t1("black", "auto", 630);
//	t1.set_cargo_weight();
//	t1.from_a_to_b();
//	t1.display();
//}