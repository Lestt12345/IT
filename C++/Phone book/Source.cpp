#include "phone_book.h"
#include <windows.h>

using namespace std;

void display_menu() {
    cout << "����:" << endl;
    cout << "1. ������ �������" << endl;
    cout << "2. �������� �������" << endl;
    cout << "3. ����� ��������" << endl;
    cout << "4. ����������� �� ��������" << endl;
    cout << "5. �������� �������� � ����" << endl;
    cout << "6. ����������� �������� � �����" << endl;
    cout << "7. �����" << endl;
}

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    PhoneBook phone_book;
    int choice;
    string name;
    int home_phone, work_phone, mobile_phone;
    string additional_info;
    string filename;

    while (true) {
        display_menu();
        cout << "������� �����: ";
        cin >> choice;
        cin.ignore();

        if (choice == 1) {
            cout << "������ ��'� ��������: ";
            getline(cin, name);
            cout << "������ ������� �������: ";
            cin >> home_phone;
            cout << "������ ������� �������: ";
            cin >> work_phone;
            cout << "������ �������� �������: ";
            cin >> mobile_phone;
            cin.ignore();
            cout << "������ ��������� ����������: ";
            getline(cin, additional_info);
            phone_book.add_contact(Contact(name, home_phone, work_phone, mobile_phone, additional_info));
            cout << "������� ������!" << endl;
        }
        else if (choice == 2) {
            cout << "������ ��'� �������� ��� ���������: ";
            getline(cin, name);
            phone_book.remove_contact(name);
        }
        else if (choice == 3) {
            cout << "������ ��'� �������� ��� ������: ";
            getline(cin, name);
            phone_book.search_contact(name);
        }
        else if (choice == 4) {
            phone_book.display_all_contacts();
        }
        else if (choice == 5) {
            cout << "������ ��'� ����� ��� ����������: ";
            getline(cin, filename);
            phone_book.save_to_file(filename);
            cout << "�������� ��������� � ����!" << endl;
        }
        else if (choice == 6) {
            cout << "������ ��'� ����� ��� ������������: ";
            getline(cin, filename);
            phone_book.load_from_file(filename);
            cout << "�������� ����������� � �����!" << endl;
        }
        else if (choice == 7) {
            cout << "����� � ��������." << endl;
            break;
        }
        else {
            cout << "������� ����. ��������� �� ���." << endl;
        }
    }
}
