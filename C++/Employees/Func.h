#pragma once
#include <iostream>
#include <windows.h>
using namespace std;

struct employee
{
	char last_name[51];
	char first_name[51];
	char third_name[51];
	int age;
	char group[51];
};

void out(employee* arr, int n) { //for debug
	for (size_t i = 0; i < n; i++)
	{
		cout << "\n" << i + 1 << ".\nϲ�: " << arr[i].last_name << " " << arr[i].first_name << " " << arr[i].third_name << endl
			<< "³�: " << arr[i].age << endl
			<< "������: " << arr[i].group << endl;
	}
}

employee* add(employee* arr, int n) {
	employee* arr_tmp = new employee[n + 1];
	if (n > 0)
	{
		for (int i = 0; i < n; i++) {
			strcpy(arr_tmp[i].last_name, arr[i].last_name);
			strcpy(arr_tmp[i].first_name, arr[i].first_name);
			strcpy(arr_tmp[i].third_name, arr[i].third_name);
			arr_tmp[i].age = arr[i].age;
			strcpy(arr_tmp[i].group, arr[i].group);
		}
	}
	cout << "\n��������:\n" 
		<< "�������: ";
	cin >> arr_tmp[n].last_name;
	cout << "��`�: ";
	cin >> arr_tmp[n].first_name;
	cout << "���������: ";
	cin >> arr_tmp[n].third_name;
	cout << "³�: ";
	cin >> arr_tmp[n].age;
	cout << "������: ";
	cin >> arr_tmp[n].group;
	cout << "\n����!\n";
	delete arr;
	return arr_tmp;
}

void edit(employee* arr, int n) {
	for (size_t i = 0; i < n; i++)
	{
		cout << "\n" << i + 1 << ".\nϲ�: " << arr[i].last_name << " " << arr[i].first_name << " " << arr[i].third_name << endl
			<< "³�: " << arr[i].age << endl
			<< "������: " << arr[i].group << endl;
	}
	int n_;
	cout << "\n������ ����� ����������� ��� ���� ��� ������: ";
	cin >> n_;
	bool correct_choice = true;
	while (correct_choice)
	{
		if (n_ == 0)
		{
			cout << "\n³����\n";
			return;
		}
		else if (n_<1 || n_>n)
		{
			cout << "������ ������� ������ ����...\n\n������ ����� ����������� ��� ���� ��� ������: ";
			cin >> n_;
		}
		else
		{
			correct_choice = false;
			bool correct_choice_ = true;
			int choice;
			cout << "\n������� ������:\n1 - ϲ�\n2 - ³�\n3 - ������\n4 - ��� ������\n��� ����: ";
			cin >> choice;
			while (correct_choice_)
			{
				if (choice < 1 || choice>4)
				{
					cout << "\n������ ������� ������ ����...\n��� ����: ";
					cin >> choice;
				}
				else if (choice == 1)
				{
					cout << "\n�����������:\n"
						<< "�������: ";
					cin >> arr[n_].last_name;
					cout << "��`�: ";
					cin >> arr[n_].first_name;
					cout << "���������: ";
					cin >> arr[n_].third_name;
					correct_choice_ = false;
					cout << "\n����!\n";
				}
				else if (choice == 2)
				{
					cout << "\n�����������:\n"
						<< "³�: ";
					cin >> arr[n_].age;
					correct_choice_ = false;
					cout << "\n����!\n";
				}
				else if (choice == 3)
				{
					cout << "\n�����������:\n"
						<< "������: ";
					cin >> arr[n_].group;
					correct_choice_ = false;
					cout << "\n����!\n";
				}
				else if (choice == 4)
				{
					cout << "\n�����������:\n"
						<< "�������: ";
					cin >> arr[n_ - 1].last_name;
					cout << "��`�: ";
					cin >> arr[n_ - 1].first_name;
					cout << "���������: ";
					cin >> arr[n_ - 1].third_name;
					cout << "³�: ";
					cin >> arr[n_ - 1].age;
					cout << "������: ";
					cin >> arr[n_ - 1].group;
					correct_choice_ = false;
					cout << "\n����!\n";
				}
			}
		}
	}
}

employee* del(employee* arr, int n) {
	if (n == 1)
	{
		return NULL;
	}
	employee* arr_tmp = new employee[n - 1];
	for (size_t i = 0; i < n; i++)
	{
		cout << "\n" << i + 1 << ".\nϲ�: " << arr[i].last_name << " " << arr[i].first_name << " " << arr[i].third_name << endl
			<< "³�: " << arr[i].age << endl
			<< "������: " << arr[i].group << endl;
	}
	int n_;
	cout << "\n������ ����� ����������� ��� ���� ��� ������: ";
	cin >> n_;
	bool correct_choice = true;
	while (correct_choice)
	{
		if (n_ == 0)
		{
			correct_choice = false;
			cout << "\n³����...\n";
		}
		else if (n_<1 || n_>n)
		{
			cout << "������ ������� ������ ����...\n\n������ ����� ����������� ��� ���� ��� ������: ";
			cin >> n_;
		}
		else
		{
			correct_choice = false;
			int j = 0;
			for (int i = 0; i < n; ++i) {
				if (i != n_ - 1) {
					strcpy(arr_tmp[j].last_name, arr[i].last_name);
					strcpy(arr_tmp[j].first_name, arr[i].first_name);
					strcpy(arr_tmp[j].third_name, arr[i].third_name);
					arr_tmp[j].age = arr[i].age;
					strcpy(arr_tmp[j].group, arr[i].group);
					++j;
				}
			}
			cout << "\n����!\n";
			delete arr;
			return arr_tmp;
		}
	}
}

employee* search(employee* arr, int n, int* srch_n, char* path_srch) {
	employee* arr_s;
	char tmp_last_name[51];
	cout << "\n������ ������� �����������: ";
	cin >> tmp_last_name;
	for (int i = 0; i < n; i++)
	{
		if (strcmp(arr[i].last_name, tmp_last_name) == 0)
		{
			(*srch_n)++;
		}
	}
	cout << "\n�������� " << *srch_n << " ��������\n";
	if (*srch_n != 0)
	{
		arr_s = new employee[*srch_n];
		int j = 0;
		for (int i = 0; i < n; i++)
		{
			if (strcmp(arr[i].last_name, tmp_last_name) == 0)
			{
				strcpy(arr_s[j].last_name, arr[i].last_name);
				strcpy(arr_s[j].first_name, arr[i].first_name);
				strcpy(arr_s[j].third_name, arr[i].third_name);
				arr_s[j].age = arr[i].age;
				strcpy(arr_s[j].group, arr[i].group);
				++j;
			}
		}
		return arr_s;
	}
}

void out_with_this_age(employee* arr, int n) {
	int tmp_age;
	int with_this_age_n = 0;
	cout << "\n������ ��: ";
	cin >> tmp_age;
	for (int i = 0; i < n; i++)
	{
		if (arr[i].age == tmp_age)
		{
			with_this_age_n++;
			cout << "\n" << with_this_age_n << ".\nϲ�: " << arr[i].last_name << " " << arr[i].first_name << " " << arr[i].third_name << endl
				<< "³�: " << arr[i].age << endl
				<< "������: " << arr[i].group << endl;
		}
	}
	if (with_this_age_n == 0)
	{
		cout << "\nͳ���� �� ��������...\n";
	}
}

void out_with_firstL_last_name(employee* arr, int n) {
	char firstL_last_name;
	int with_firstL_last_name_n = 0;
	cout << "\n������ ����� ����� �������: ";
	cin >> firstL_last_name;
	for (int i = 0; i < n; i++)
	{
		if (arr[i].last_name[0] == firstL_last_name)
		{
			with_firstL_last_name_n++;
			cout << "\n" << with_firstL_last_name_n << ".\nϲ�: " << arr[i].last_name << " " << arr[i].first_name << " " << arr[i].third_name << endl
				<< "³�: " << arr[i].age << endl
				<< "������: " << arr[i].group << endl;
		}
	}
	if (with_firstL_last_name_n == 0)
	{
		cout << "\nͳ���� �� ��������...\n";
	}
}