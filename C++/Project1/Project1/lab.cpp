#include <iostream>
#include <windows.h>
using namespace std;

int main() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	srand(time(NULL));
//1
	/*int** arr;
	int r = 0;
	int s = 0;
	cout << "������� ����� ����� � ��������: ";
	cin >> r >> s;
	arr = (int**)malloc(r * sizeof(int*));
	for (int i = 0; i < r; i++)
	{
		arr[i] = (int*)malloc(s * sizeof(int));
	}
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			arr[i][j] = rand() % 10;
		}
	}
	cout << "��� ���: ";
	cout << "\n";
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			cout << arr[i][j] << " ";
		}
		cout << "\n";
	}
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			if (arr[i][j] == 0)
			{
				delete arr[i];
			}
		}
	}
	cout << endl;
	bool skip = false;
	cout << "��� ����: ";
	cout << "\n";
	for (int i = 0; i < r; i++)
	{
	skip = false;
	for (int j = 0; j < s; j++)
	{
		if (arr[i][j] < 0)
		{
			skip = true;
			continue;
		}
		cout << arr[i][j] << " ";
	}
	if (skip)
	{
		continue;
	}
	cout << "\n";
	}*/
//2
	/*int** arr_f;
	int** arr_s;
	int** arr_th;
	int r, s;


	cout << "������� ����� ����� � �������� �������: ";
	cin >> r >> s;


	arr_f = (int**)malloc(r * sizeof(int*));
	for (int i = 0; i < r; i++)
	{
		arr_f[i] = (int*)malloc(s * sizeof(int));
	}

	arr_s = (int**)malloc(r * sizeof(int*));
	for (int i = 0; i < r; i++)
	{
		arr_s[i] = (int*)malloc(s * sizeof(int));
	}

	arr_th = (int**)malloc(r * sizeof(int*));
	for (int i = 0; i < r; i++)
	{
		arr_th[i] = (int*)malloc(s * sizeof(int));
	}


	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			arr_f[i][j] = rand() % 10;
		}
	}

	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			arr_s[i][j] = rand() % 10;
		}
	}


	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			arr_th[i][j] = arr_f[i][j] + arr_s[i][j];
		}
	}


	cout << "������ ������: ";
	cout << "\n";
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			cout << arr_f[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "������ ������: ";
	cout << "\n";
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			cout << arr_s[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "���� �������: ";
	cout << "\n";
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			cout << arr_th[i][j] << " ";
		}
		cout << "\n";
	}*/
//3
	/*int** arr_f;
	int** arr_s;
	int** arr_th;
	int n, m, b, k;


	cout << "������� ����� ����� � �������� �������: ";
	cin >> n >> m;
	cout << "������� ����� ����� � �������� �������: ";
	cin >> b >> k;


	if (n!=k || m!=b)
	{
		cout << "\noops...   Error :(\n����� ����� ������� ������� ������� ���������� ����� �������� ������� �������,\n� ����� �������� ������� ������� ������� ���������� ����� ����� ������� �������.\n\n";
		return NULL;
	}


	arr_f = (int**)malloc(n * sizeof(int*));
	for (int i = 0; i < n; i++)
	{
		arr_f[i] = (int*)malloc(m * sizeof(int));
	}

	arr_s = (int**)malloc(b * sizeof(int*));
	for (int i = 0; i < b; i++)
	{
		arr_s[i] = (int*)malloc(k * sizeof(int));
	}

	arr_th = (int**)malloc(n * sizeof(int*));
	for (int i = 0; i < n; i++)
	{
		arr_th[i] = (int*)malloc(k * sizeof(int));
	}


	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			arr_f[i][j] = rand() % 10;
		}
	}

	for (int i = 0; i < b; i++)
	{
		for (int j = 0; j < k; j++)
		{
			arr_s[i][j] = rand() % 10;
		}
	}

	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < k; j++)
		{
			arr_th[i][j] = 0;
		}
	}


	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < k; j++)
		{
			for (int c = 0; c < m; c++)
			{
				arr_th[i][j] += arr_f[i][c] * arr_s[c][j];
			}
		}
	}


	cout << "������ ������: ";
	cout << "\n";
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			cout << arr_f[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "������ ������: ";
	cout << "\n";
	for (int i = 0; i < b; i++)
	{
		for (int j = 0; j < k; j++)
		{
			cout << arr_s[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "���� �������: ";
	cout << "\n";
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < k; j++)
		{
			cout << arr_th[i][j] << " ";
		}
		cout << "\n";
	}*/
}