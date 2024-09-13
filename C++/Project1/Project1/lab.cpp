//#include <iostream>
//#include <string>
//using namespace std;
//
//class Contact {
//    string full_name;
//    int home_phone;
//    int work_phone;
//    int mobile_phone;
//    string add_info;
//public:
//    Contact() {
//        full_name = "undefined";
//        home_phone = 0;
//        work_phone = 0;
//        mobile_phone = 0;
//        add_info = "undefined";
//    }
//    Contact(string full_name, int home_phone, int work_phone, int mobile_phone, string add_info) {
//        this->full_name = full_name;
//        this->home_phone = home_phone;
//        this->work_phone = work_phone;
//        this->mobile_phone = mobile_phone;
//        this->add_info = add_info;
//    }
//    void display() {
//        cout << "Full Name: " << full_name << endl
//            << "Home Phone: " << home_phone << endl
//            << "Work Phone: " << work_phone << endl
//            << "Mobile Phone: " << mobile_phone << endl
//            << "Additional Info: " << add_info << endl;
//    }
//};
//
//Contact create_contact() {
//    string full_name, add_info;
//    int home_phone, work_phone, mobile_phone;
//    cin.ignore();
//    cout << "Enter full name: ";
//    getline(cin, full_name);
//    cout << "Enter home phone : ";
//    cin >> home_phone;
//    cout << "Enter work phone : ";
//    cin >> work_phone;
//    cout << "Enter mobile phone : ";
//    cin >> mobile_phone;
//    cout << "Enter additional info: ";
//    cin.ignore();
//    getline(cin, add_info);
//    return Contact(full_name, home_phone, work_phone, mobile_phone, add_info);
//}
//
//void phone_book_menu(Contact phone_book[], int& count) {
//    int choice = -1;
//    while (choice != 0) {
//        cout << "\nPhone Book Menu:\n"
//            << "1. Add new contact\n"
//            << "2. Display all contacts\n"
//            << "0. Exit\n"
//            << "Choose an option: ";
//        cin >> choice;
//        switch (choice)
//        {
//        case 1:
//            if (count < 100) {
//                phone_book[count] = create_contact();
//                count++;
//            }
//            else {
//                cout << "Phone book is full\n";
//            }
//            break;
//        case 2:
//            if (count == 0) {
//                cout << "Phone book is empty\n";
//            }
//            else {
//                for (int i = 0; i < count; ++i) {
//                    cout << "\nContact " << i + 1 << ":\n";
//                    phone_book[i].display();
//                }
//            }
//            break;
//        case 0:
//            cout << "bb\n\n";
//            break;
//        default:
//            cout << "Error, invalid input\n";
//        }
//    }
//}
//
//int main() {
//    Contact phone_book[100];
//    int count = 0;
//    phone_book_menu(phone_book, count);
//}