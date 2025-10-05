// username - student
// password - password
#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include <locale>

using namespace std;

struct User {
    string username;
    string password;
    bool isAuthenticated = false;
};

struct Assignment {
    int id;
    string title;
    string description;
    int grade = -1;
};

class HomeworkManager {
private:
    vector<Assignment> assignments;
    int nextId = 1;
    const string filename = "assignments.txt";

public:
    HomeworkManager() {
        loadAssignments();
    }

    ~HomeworkManager() {
        saveAssignments();
    }
    //���������� ������� 
    void addAssignment(const string& title, const string& description) {
        assignments.push_back({ nextId++, title, description });
        cout << "�������� ������� ���������.\n";
        saveAssignments();
    }

    void viewAssignments() {
        if (assignments.empty()) {
            cout << "��� �������� �������.\n";
            return;
        }
        for (const auto& assignment : assignments) {
            cout << "ID: " << assignment.id << " | "
                << "��������: " << assignment.title << " | "
                << "��������: " << assignment.description << " | "
                << "������: " << (assignment.grade == -1 ? "�� ����������" : to_string(assignment.grade))
                << '\n';
        }
    }
    // �������� ������� 
    void deleteAssignment(int id) {
        for (auto it = assignments.begin(); it != assignments.end(); ++it) {
            if (it->id == id) {
                assignments.erase(it);
                cout << "������� �������.\n";
                saveAssignments();
                return;
            }
        }
        cout << "������� �� �������.\n";
    }

    //���������� 
    void saveAssignments() {
        ofstream file(filename, ios::out | ios::trunc);
        if (file.is_open()) {
            for (const auto& assignment : assignments) {
                file << assignment.id << '\n'
                    << assignment.title << '\n'
                    << assignment.description << '\n'
                    << assignment.grade << '\n';
            }
            file.close();
        }
        else {
            cout << "������ ��� ���������� ������ � ����.\n";
        }
    }
    // ��������� ������ �� �����
    void loadAssignments() {
        ifstream file(filename);
        if (file.is_open()) {
            Assignment assignment;
            while (file >> assignment.id) {
                file.ignore();
                getline(file, assignment.title);
                getline(file, assignment.description);
                file >> assignment.grade;
                file.ignore();
                assignments.push_back(assignment);
                nextId = assignment.id + 1;
            }
            file.close();
        }
        else {
            cout << "���� � ��������� �� ������. ������ ����� ����.\n";
        }
    }
};
// ���� � ����� 
bool authenticate(User& user, const string& username, const string& password) {
    if (user.username == username && user.password == password) {
        user.isAuthenticated = true;
        cout << "���� �������� �������.\n";
        return true;
    }
    cout << "�������� ������.\n";
    return false;
}
// ����� �������� 
void showMenu() {
    cout << "\n����:\n";
    cout << "1. ���������� �������� �������\n";
    cout << "2. �������� �������� �������\n";
    cout << "3. ������� �������� �������\n";
    cout << "4. �����\n";
    cout << "�������� �����: ";
}

int main() {
    setlocale(LC_ALL, "rus");
    User user = { "qwe", "123" };
    HomeworkManager manager;
    string username, password;

    cout << "������� �����: ";
    cin >> username;
    cout << "������� ������: ";
    cin >> password;

    if (!authenticate(user, username, password)) {
        return 0;
    }
    // ������  ������ 
    int choice;
    while (user.isAuthenticated) {
        showMenu();
        cin >> choice;

        switch (choice) {
        case 1: {
            manager.viewAssignments();
            break;
        }
        case 2: {
            string title, description;
            cout << "������� �������� �������: ";
            cin.ignore();
            getline(cin, title);
            cout << "������� �������� �������: ";
            getline(cin, description);
            manager.addAssignment(title, description);
            break;
        }
        case 3: {
            int id;
            cout << "������� ID ������� ��� ��������: ";
            cin >> id;
            manager.deleteAssignment(id);
            break;
        }
        case 4: {
            cout << "����� �� �������.\n";
            user.isAuthenticated = false;
            break;
        }
        default:
            cout << "������������ �����.\n";
        }
    }

    return 0;
}

