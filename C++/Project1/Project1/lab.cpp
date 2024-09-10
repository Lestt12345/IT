//#include <iostream>
//
//using namespace std;
//
//class Car
//{
//	string color;
//	string transmission;
//	int HP;
//	int wheel_count;
//public:
//	Car() {
//		color = "undefined";
//		transmission = "undefined";
//		HP = 0;
//		wheel_count = 0;
//	}
//	Car(string color, string transmission, int HP, int wheel_count) {
//		this->color = color;
//		this->transmission = transmission;
//		this->HP = HP;
//		this->wheel_count = wheel_count;
//	}
//	void ride() {
//		cout << "Riding...\n";
//	}
//	void set_color() {
//		cout << "set color: ";
//		cin >> color;
//	}
//	void get_color() {
//		cout << color;
//	}
//	void set_transmission() {
//		cout << "set transmission: ";
//		cin >> transmission;
//	}
//	void get_transmission() {
//		cout << transmission;
//	}
//	void set_HP() {
//		cout << "set HP: ";
//		cin >> HP;
//	}
//	void get_HP() {
//		cout << HP;
//	}
//	void set_wheel_count() {
//		cout << "set wheel_count: ";
//		cin >> wheel_count;
//	}
//	void get_wheel_count() {
//		cout << wheel_count;
//	}
//	void display() {
//		cout
//			<< "color: " << color << endl
//			<< "transmission: " << transmission << endl
//			<< "HP: " << HP << endl
//			<< "whell count: " << wheel_count << endl;
//	}
//	virtual void from_a_to_b() {}
//};
//
//class Sedan : public Car
//{
//public:
//	using Car::Car;
//	Sedan() : Car("undefined", "undefined", 0, 4) {}
//	Sedan(string color, string transmission, int HP) : Car(color, transmission, HP, 4) {}
//	void from_a_to_b() override {
//		string a, b;
//		cout << "enter first place: ";
//		cin >> a;
//		cout << "enter second place: ";
//		cin >> b;
//		cout << "start from " << a << endl;
//		ride();
//		cout << "enter to " << b << endl;
//
//	}
//};
//
//class Truck : public Car
//{
//	int cargo_weight;
//public:
//	using Car::Car;
//	Truck() : Car("undefined", "undefined", 0, 6), cargo_weight(0) {}
//	Truck(string color, string transmission, int HP) : Car(color, transmission, HP, 6), cargo_weight(0) {}
//	void set_cargo_weight() {
//		cout << "set cargo_weight: ";
//		cin >> cargo_weight;
//	}
//	void get_cargo_weight() {
//		cout << cargo_weight;
//	}
//	void from_a_to_b() override {
//		string a, b;
//		cout << "enter first place: ";
//		cin >> a;
//		cout << "enter second place: ";
//		cin >> b;
//		cout << "enter to the " << a << endl;
//		cout << "take cargo (" << a << ")" << endl;
//		cout << "start from " << a << endl;
//		ride();
//		cout << "enter to " << b << endl;
//		cout << "unhook cargo" << endl;
//	}
//};
//
//int main() {
//	SetConsoleCP(1251);
//	SetConsoleOutputCP(1251);
//	cout << "Sedan:\n";
//	Sedan s1("red", "manual", 130);
//	s1.from_a_to_b();
//	s1.display();
//	cout << "\n\n";
//	cout << "Truck:\n";
//	Truck t1("black", "auto", 630);
//	t1.set_cargo_weight();
//	t1.from_a_to_b();
//	t1.display();
//}