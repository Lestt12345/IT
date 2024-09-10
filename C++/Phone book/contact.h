#include <string>
#include <fstream>
#include <iostream>

using namespace std;

class Contact {
private:
    string* name;
    int home_phone;
    int work_phone;
    int mobile_phone;
    string additional_info;

public:
    Contact(const string& name, int home_phone = 0, int work_phone = 0, int mobile_phone = 0,
        const string& additional_info = "");

    ~Contact();

    Contact(const Contact& other);

    Contact& operator=(const Contact& other);

    void display() const;

    const string& get_name() const;

    void save_to_file(ofstream& file) const;

    void load_from_file(ifstream& file);
};
