#include "contact.h"

Contact::Contact(const string& name, int home_phone, int work_phone, int mobile_phone,
    const string& additional_info)
    : home_phone(home_phone), work_phone(work_phone), mobile_phone(mobile_phone),
    additional_info(additional_info) {
    this->name = new string(name);
}

Contact::~Contact() {
    delete name;
}

Contact::Contact(const Contact& other)
    : home_phone(other.home_phone), work_phone(other.work_phone),
    mobile_phone(other.mobile_phone), additional_info(other.additional_info) {
    name = new string(*other.name);
}

Contact& Contact::operator=(const Contact& other) {
    if (this == &other) {
        return *this;
    }
    delete name;
    name = new string(*other.name);
    home_phone = other.home_phone;
    work_phone = other.work_phone;
    mobile_phone = other.mobile_phone;
    additional_info = other.additional_info;
    return *this;
}

void Contact::display() const {
    cout << "Ім'я: " << *name << endl;
    cout << "Домашній телефон: " << home_phone << endl;
    cout << "Робочий телефон: " << work_phone << endl;
    cout << "Мобільний телефон: " << mobile_phone << endl;
    cout << "Додаткова інформація: " << additional_info << endl;
}

const string& Contact::get_name() const {
    return *name;
}

void Contact::save_to_file(ofstream& file) const {
    file << *name << endl;
    file << home_phone << endl;
    file << work_phone << endl;
    file << mobile_phone << endl;
    file << additional_info << endl;
}

void Contact::load_from_file(ifstream& file) {
    getline(file, *name);
    file >> home_phone;
    file >> work_phone;
    file >> mobile_phone;
    file.ignore();
    getline(file, additional_info);
}
