#define _CRT_SECURE_NO_WARNINGS
#include <io.h>
#include <iostream>
#include <windows.h>
#include <fstream>
#include "Func.h"
using namespace std;

int main() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	FILE* company_file;
	FILE* search_file;
	employee* company;
	employee* search_res;
	int employee_count = 0;
	struct _finddata_t finf;
	struct _finddata_t finf_s;
	char path[255];
	char path_srch[255];
	char name[255];

	cout << "Введіть шлях: ";
	cin >> path;

	while (true)
	{
		cout << "Введіть назву компанії: ";
		cin >> name;
		if (strcmp(name, "search") != 0)
		{
			break;
		}
		else
		{
			cout << "\nПомилка...\tНе можливо створити компанію з назвою 'search'\n\n";
		}
	}
	strcat_s(name, sizeof(name), ".txt");

	strcat_s(path, sizeof(path), "\\");
	strcpy_s(path_srch, sizeof(path), path);
	strcat_s(path, sizeof(path), name);
	strcat_s(path_srch, sizeof(path_srch), "search_");
	strcat_s(path_srch, sizeof(path_srch), name);

	long done = _findfirst(path, &finf);
	if (done != -1)
	{
		fopen_s(&company_file, path, "r");
		char c;
		while ((c = fgetc(company_file)) != EOF) {
			if (c == '\n') {
				employee_count++;
			}
		}
		company = new employee[employee_count];
		int i = 0;
		fseek(company_file, 0, SEEK_SET);
		while (!feof(company_file))
		{
			fscanf(company_file, "%s", company[i].last_name);
			fscanf(company_file, "%s", company[i].first_name);
			fscanf(company_file, "%s", company[i].third_name);
			fscanf(company_file, "%d", &company[i].age);
			fscanf(company_file, "%s", company[i].group);
			i++;
		}
		fclose(company_file);
		cout << "\nУспіх";
	}
	else
	{
		int choice_create;
		cout << "\nПомилка (компанію не знайдено)";
		cout << "\nХочете створити нову?\n1 - Так\n2 - Ні\nВаш вибір: ";
		cin >> choice_create;
		if (choice_create == 1)
		{
			fopen_s(&company_file, path, "w");
			fclose(company_file);
			company = new employee[1];
			cout << "\nКомпанію створено!";
		}
		else
		{
			exit(1);
		}
	}

	long done_s = _findfirst(path_srch, &finf_s);
	if (done_s == -1)
	{
		fopen_s(&search_file, path_srch, "w");
		fprintf(search_file, "______________________________________\n\n");
		fclose(search_file);
	}

	int search_res_save = 0;
	bool search_res_save_answ;

	int ch = -1;
	while (ch != 0)
	{
		cout << "\n\n\nМеню:\n"
			<< "1 - Введення даних (додати співробітника)\n"
			<< "2 - Редагування даних співробітника\n"
			<< "3 - Видалення співробітника\n"
			<< "4 - Пошук співробітника за прізвищем\n"
			<< "5 - Виведення інформації про всіх співробітників зазначеного віку\n"
			<< "6 - Виведення інформації про всіх співробітників прізвище яких починається на зазначену букву\n"
			<< "7 - Збереження інформації у файл\n"
			<< "0 - Завершення програми\n"
			<< "Вибір: ";
		cin >> ch;
		if (ch == 1)
		{
			company = add(company, employee_count);
			employee_count++;
		}
		else if (ch == 2)
		{
			if (employee_count == 0)
			{
				cout << "У базі данних немає робітників, тому редагувати нічого...\n";
			}
			else
			{
				edit(company, employee_count);
			}
		}
		else if (ch == 3)
		{
			if (employee_count == 0)
			{
				cout << "У базі данних немає робітників, тому видаляти нічого...\n";
			}
			else
			{
				company = del(company, employee_count);
				employee_count--;
			}
		}
		else if (ch == 4)
		{
			if (employee_count == 0)
			{
				cout << "У базі данних немає робітників, тому шукати нічого...\n";
			}
			else
			{
				int* search_count;
				search_count = new int;
				*search_count = 0;
				search_res_save_answ = false;
				search_res = search(company, employee_count, search_count, path_srch);
				if (*search_count != 0)
				{
					while (!search_res_save_answ)
					{
						cout << "\nЗберегти результати пошуку в окремий файл?\n' " << path_srch
							<< " '\n1 - Так\n2 - Ні\nВибір: ";
						cin >> search_res_save;
						if (search_res_save == 1)
						{
							search_res_save_answ = true;
							fopen_s(&search_file, path_srch, "a");
							for (int i = 0; i < *search_count; i++)
							{
								fprintf(search_file, "%s %s %s %d %s\n", search_res[i].last_name, search_res[i].first_name, search_res[i].third_name, search_res[i].age, search_res[i].group);
							}
							fprintf(search_file, "\n______________________________________\n\n");
							fclose(search_file);
							cout << "\nРезультати пошуку збережено.\n";
						}
						else if (search_res_save == 2)
						{
							search_res_save_answ = true;
							cout << endl;
							break;
						}
						else
						{
							cout << "\nТакого варіанту немає\n";
						}
					}
				}
				delete search_count;
			}
		}
		else if (ch == 5)
		{
			if (employee_count == 0)
			{
				cout << "У базі данних немає робітників, тому виводити нічого...\n";
			}
			else
			{
				out_with_this_age(company, employee_count);
			}
		}
		else if (ch == 6)
		{
			if (employee_count == 0)
			{
				cout << "У базі данних немає робітників, тому виводити нічого...\n";
			}
			else
			{
				out_with_firstL_last_name(company, employee_count);
			}
		}
		else if (ch == 7)
		{
			fopen_s(&company_file, path, "w");
			for (int i = 0; i < employee_count; i++)
			{
				fprintf(company_file, "%s %s %s %d %s\n", company[i].last_name, company[i].first_name, company[i].third_name, company[i].age, company[i].group);
			}
			fclose(company_file);
			cout << "\nДанні збережено.\n";
		}
		else if (ch == 0)
		{
			fopen_s(&company_file, path, "w");
			for (int i = 0; i < employee_count; i++)
			{
				fprintf(company_file, "%s %s %s %d %s\n", company[i].last_name, company[i].first_name, company[i].third_name, company[i].age, company[i].group);
			}
			fclose(company_file);
			cout << "\nУсі данні автоматично збережені.\n\n";
			exit(1);
		}
		else if (ch == 404) //for debug
		{
			out(company, employee_count);
		}
		else
		{
			cout << "Помилка...\nТакого варіанту немає\n";
		}
	}
}