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
	cout << "Впишіть число рядків і стовпців: ";
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
	cout << "Без змін: ";
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
	cout << "Без нулів: ";
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


	cout << "Впишіть число рядків і стовпців массиву: ";
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


	cout << "Перший массив: ";
	cout << "\n";
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			cout << arr_f[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "Другий массив: ";
	cout << "\n";
	for (int i = 0; i < r; i++)
	{
		for (int j = 0; j < s; j++)
		{
			cout << arr_s[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "Сума массивів: ";
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


	cout << "Впишіть число рядків і стовпців массиву: ";
	cin >> n >> m;
	cout << "Впишіть число рядків і стовпців массиву: ";
	cin >> b >> k;


	if (n!=k || m!=b)
	{
		cout << "\noops...   Error :(\nЧисло рядків першого массиву повинно дорівнювати числу стовпців другого массиву,\nа число стовпців першого массиву повинно дорівнювати числу рядків другого массиву.\n\n";
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


	cout << "Перший массив: ";
	cout << "\n";
	for (int i = 0; i < n; i++)
	{
		for (int j = 0; j < m; j++)
		{
			cout << arr_f[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "Другий массив: ";
	cout << "\n";
	for (int i = 0; i < b; i++)
	{
		for (int j = 0; j < k; j++)
		{
			cout << arr_s[i][j] << " ";
		}
		cout << "\n";
	}

	cout << "Сума массивів: ";
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