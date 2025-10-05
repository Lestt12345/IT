#include "phone_book.h"

PhoneBook::PhoneBook() : contacts(nullptr), size(0) {}

PhoneBook::~PhoneBook() {
    clear();
}

void PhoneBook::add_contact(const Contact& contact) {
    Contact** new_contacts = new Contact * [size + 1];
    for (size_t i = 0; i < size; i++) {
        new_contacts[i] = contacts[i];
    }
    new_contacts[size] = new Contact(contact);
    delete[] contacts;
    contacts = new_contacts;
    size++;
}

void PhoneBook::remove_contact(const string& name) {
    size_t index = size;
    for (size_t i = 0; i < size; i++) {
        if (contacts[i]->get_name() == name) {
            index = i;
            break;
        }
    }
    if (index == size) {
        cout << "Контакт не знайдено!" << endl;
        return;
    }
    delete contacts[index];
    for (size_t i = index; i < size - 1; i++) {
        contacts[i] = contacts[i + 1];
    }
    size--;
    Contact** new_contacts = new Contact * [size];
    for (size_t i = 0; i < size; i++) {
        new_contacts[i] = contacts[i];
    }
    delete[] contacts;
    contacts = new_contacts;
}

void PhoneBook::search_contact(const string& name) const {
    for (size_t i = 0; i < size; i++) {
        if (contacts[i]->get_name() == name) {
            contacts[i]->display();
            return;
        }
    }
    cout << "Контакт не знайдено!" << endl;
}

void PhoneBook::display_all_contacts() const {
    if (size == 0) {
        cout << "Немає контактів у телефонній книзі." << endl;
        return;
    }
    for (size_t i = 0; i < size; i++) {
        contacts[i]->display();
        cout << "------------------------" << endl;
    }
}

void PhoneBook::save_to_file(const string& filename) const {
    ofstream file(filename);
    if (!file) {
        cout << "Помилка відкриття файлу для запису!" << endl;
        return;
    }
    file << size << endl;
    for (size_t i = 0; i < size; i++) {
        contacts[i]->save_to_file(file);
    }
    file.close();
}

void PhoneBook::load_from_file(const string& filename) {
    ifstream file(filename);
    if (!file) {
        cout << "Помилка відкриття файлу для читання!" << endl;
        return;
    }
    clear();
    file >> size;
    file.ignore();
    contacts = new Contact * [size];
    for (size_t i = 0; i < size; i++) {
        contacts[i] = new Contact("", 0, 0, 0, "");
        contacts[i]->load_from_file(file);
    }
    file.close();
}

void PhoneBook::clear() {
    if (contacts != nullptr) {
        for (size_t i = 0; i < size; i++) {
            delete contacts[i];
        }
        delete[] contacts;
        contacts = nullptr;
        size = 0;
    }
}
