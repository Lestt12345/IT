//#include <iostream>
//#include <thread>
//#include <chrono>
//#include <fstream>
//#include <string>
//using namespace std;
//
//class Fraction {
//    int numerator;
//    int denominator;
//    int gcd(int a, int b) const {
//        while (b != 0) {
//            int t = b;
//            b = a % b;
//            a = t;
//        }
//        return a;
//    }
//    int lcm(int a, int b) const {
//        return (a / gcd(a, b)) * b;
//    }
//    void simplify() {
//        int gcd_val = gcd(numerator, denominator);
//        numerator /= gcd_val;
//        denominator /= gcd_val;
//        if (denominator < 0) {
//            numerator = -numerator;
//            denominator = -denominator;
//        }
//    }
//public:
//    Fraction(int num = 0, int denom = 1) : numerator(num), denominator(denom) {
//        if (denom == 0) {
//            cout << "Error: Denominator cannot be zero!" << endl;
//            numerator = 0;
//            denominator = 1;
//        }
//        else {
//            simplify();
//        }
//    }
//    Fraction operator+(const Fraction& other) const {
//        int common_denom = lcm(denominator, other.denominator);
//        int num = numerator * (common_denom / denominator) + other.numerator * (common_denom / other.denominator);
//        return Fraction(num, common_denom);
//    }
//    Fraction operator-(const Fraction& other) const {
//        int common_denom = lcm(denominator, other.denominator);
//        int num = numerator * (common_denom / denominator) - other.numerator * (common_denom / other.denominator);
//        return Fraction(num, common_denom);
//    }
//    Fraction operator*(const Fraction& other) const {
//        int num = numerator * other.numerator;
//        int denom = denominator * other.denominator;
//        return Fraction(num, denom);
//    }
//    Fraction operator/(const Fraction& other) const {
//        if (other.numerator == 0) {
//            cout << "Error: Cannot divide by zero!" << endl;
//            return Fraction(0, 1);
//        }
//        int num = numerator * other.denominator;
//        int denom = denominator * other.numerator;
//        return Fraction(num, denom);
//    }
//    void print() const {
//        cout << numerator << "/" << denominator;
//    }
//    void save_info_log(const string& filename) { // дроби не нужно сохранять, ведь мы их сами задаем в файле { случилось нечто!!! тоесть я впервые за 100 лет написал комент))) }
//        ofstream save_file(filename, ios::app);
//        if (save_file.is_open())
//        {
//            save_file << numerator << "/" << denominator << endl;
//            save_file.close();
//            cout << "Saved result to " << filename << endl;
//        }
//        else
//        {
//            cout << "error save\n";
//        }
//    }
//    void open_info(const string& filename) {
//        ifstream info_file(filename);
//        if (info_file.is_open())
//        {
//            info_file >> numerator;
//            info_file >> denominator;
//            cout << "Opened from " << filename << "\n";
//        }
//        else
//        {
//            cout << "error open\n";
//        }
//    }
//};
//
//int main() {
//    Fraction f1(3, 4);
//    Fraction f2(2, 5);
//    thread load_thread1(&Fraction::open_info, &f1, "f1_data.txt");
//    thread load_thread2(&Fraction::open_info, &f2, "f2_data.txt");
//    load_thread1.join();
//    load_thread2.join();
//
//    Fraction sum = f1 + f2;
//    Fraction diff = f1 - f2;
//    Fraction product = f1 * f2;
//    Fraction quotient = f1 / f2;
//    cout << "1: "; f1.print(); cout << "      2: "; f2.print(); cout << endl;
//    cout << "Sum: "; sum.print(); cout << endl;
//    sum.save_info_log("log.txt");
//    cout << "Difference: "; diff.print(); cout << endl;
//    diff.save_info_log("log.txt");
//    cout << "Product: "; product.print(); cout << endl;
//    product.save_info_log("log.txt");
//    cout << "Quotient: "; quotient.print(); cout << endl;
//    quotient.save_info_log("log.txt");
//    ofstream save_file("log.txt", ios::app);
//    if (save_file.is_open())
//    {
//        save_file << "___________________________\n\n";
//        save_file.close();
//    }
//}