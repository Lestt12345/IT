//#include <iostream>
//#include <windows.h>
//#include <iomanip>
//using namespace std;

//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//    int total_seconds, hours, minutes, seconds;
//    cout << "������ ���: ";
//    cin >> total_seconds;
//    hours = total_seconds / 3600;
//    minutes = (total_seconds % 3600) / 60;
//    seconds = total_seconds % 60;
//    cout << "������: " << hours << "\t";
//    cout << "�������: " << minutes << "\t";
//    cout << "�������: " << seconds << "\t";
//}

//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int grn, kop;
//    double not_good_input;
//    cout << "������ ��������, (������ 00.00): ";
//    cin >> not_good_input;
//    grn = not_good_input;
//    kop = (not_good_input - grn) * 10;
//    if (kop<10)
//    {
//        kop *= 10;
//    }
//    cout << "�����: " << grn << "\t";
//    cout << "������: " << kop << "\t";
//}

//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    double  input_time, speed_kmph;
//    int time_minutes, time_seconds, total_time_seconds, distance_meters;
//    cout << "���������� �������� ���." << endl;
//    cout << "������ ������� ��������� (�����): ";
//    cin >> distance_meters;
//    cout << "������ ��� (��.���): ";
//    cin >> input_time;
//    time_minutes = input_time;
//    time_seconds = (input_time - time_minutes) * 100;
//    if (time_seconds>=60)
//    {
//        time_seconds -= 60;
//        time_minutes++;
//    }
//    total_time_seconds = time_minutes * 60 + time_seconds;
//    speed_kmph = (1.0 * distance_meters / 1000.0) / (1.0 * total_time_seconds / 3600.0);
//    cout << "���������: " << distance_meters << " �." << endl;
//    cout << "���: " << time_minutes << " �� " << time_seconds << " ��� = " << total_time_seconds << " ���." << endl;
//    cout << "�� ���� � �������� " << setprecision(4) << speed_kmph << " ��/���." << endl;
//}

//int main() {
//    SetConsoleCP(1251);
//    SetConsoleOutputCP(1251);
//    int days, weeks;
//    cout << "������ ������� ���: ";
//    cin >> days;
//    weeks = days / 7;
//    days = days - (weeks * 7);
//    cout << weeks << " ������\t" << days << " ���";
//}