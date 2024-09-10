#include "contact.h"

class PhoneBook {
private:
    Contact** contacts;
    size_t size;

    void clear();

public:
    PhoneBook();

    ~PhoneBook();

    void add_contact(const Contact& contact);

    void remove_contact(const string& name);

    void search_contact(const string& name) const;

    void display_all_contacts() const;

    void save_to_file(const string& filename) const;

    void load_from_file(const string& filename);
};
