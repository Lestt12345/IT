#include "phone_book.h"
#include <windows.h>

using namespace std;

void display_menu() {
    cout << "Меню:" << endl;
    cout << "1. Додати контакт" << endl;
    cout << "2. Видалити контакт" << endl;
    cout << "3. Пошук контакту" << endl;
    cout << "4. Переглянути всі контакти" << endl;
    cout << "5. Зберегти контакти у файл" << endl;
    cout << "6. Завантажити контакти з файлу" << endl;
    cout << "7. Вийти" << endl;
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
        cout << "Виберіть опцію: ";
        cin >> choice;
        cin.ignore();

        if (choice == 1) {
            cout << "Введіть ім'я контакту: ";
            getline(cin, name);
            cout << "Введіть домашній телефон: ";
            cin >> home_phone;
            cout << "Введіть робочий телефон: ";
            cin >> work_phone;
            cout << "Введіть мобільний телефон: ";
            cin >> mobile_phone;
            cin.ignore();
            cout << "Введіть додаткову інформацію: ";
            getline(cin, additional_info);
            phone_book.add_contact(Contact(name, home_phone, work_phone, mobile_phone, additional_info));
            cout << "Контакт додано!" << endl;
        }
        else if (choice == 2) {
            cout << "Введіть ім'я контакту для видалення: ";
            getline(cin, name);
            phone_book.remove_contact(name);
        }
        else if (choice == 3) {
            cout << "Введіть ім'я контакту для пошуку: ";
            getline(cin, name);
            phone_book.search_contact(name);
        }
        else if (choice == 4) {
            phone_book.display_all_contacts();
        }
        else if (choice == 5) {
            cout << "Введіть ім'я файлу для збереження: ";
            getline(cin, filename);
            phone_book.save_to_file(filename);
            cout << "Контакти збережено у файл!" << endl;
        }
        else if (choice == 6) {
            cout << "Введіть ім'я файлу для завантаження: ";
            getline(cin, filename);
            phone_book.load_from_file(filename);
            cout << "Контакти завантажено з файлу!" << endl;
        }
        else if (choice == 7) {
            cout << "Вихід з програми." << endl;
            break;
        }
        else {
            cout << "Невірний вибір. Спробуйте ще раз." << endl;
        }
    }
}
