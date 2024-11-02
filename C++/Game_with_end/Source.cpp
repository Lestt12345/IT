#include <iostream>
#include <windows.h>
#include <cmath>
using namespace std;

class Character
{
	string name;
	int lvl = 1;
	int money = 10;
	int damage = 1;
	int health = 10;
	int upgrade_damage_cost = 5;
	int upgrade_health_cost = 2;
	int travels = 0;
	int damage_requirement = 5;
	int health_requirement = 15;
	int steel_count = 0;
	int luckySharik_count = 0;
	float lucky_aura = 1.0;
	int luckyItem_count = 0;

	void victory() {
		for (int i = 0; i < 100; i++)
		{
			cout << endl;
		}
		cout << "E";
		Sleep(200);
		cout << "m";
		Sleep(200);
		cout << "m";
		Sleep(200);
		cout << ".";
		Sleep(200);
		cout << ".";
		Sleep(200);
		cout << ".";
		Sleep(3000);
		cout << " Y";
		Sleep(200);
		cout << "o";
		Sleep(200);
		cout << "u";
		Sleep(200);
		cout << " a";
		Sleep(200);
		cout << "r";
		Sleep(200);
		cout << "e";
		Sleep(200);
		cout << " w";
		Sleep(200);
		cout << "i";
		Sleep(200);
		cout << "n";
		Sleep(200);
		cout << "!";
		Sleep(2000);
		cout << "   G";
		Sleep(200);
		cout << "O";
		Sleep(200);
		cout << "O";
		Sleep(200);
		cout << "D";
		Sleep(200);
		cout << "B";
		Sleep(200);
		cout << "Y";
		Sleep(200);
		cout << "E";
		Sleep(200);
		cout << " " << name;
		Sleep(200);
		cout << "!";
		Sleep(200);
		cout << "!";
		Sleep(200);
		cout << "!";
		Sleep(200);
		exit(1);
	}
	int travel() {
		cout << "Travelling.";
		for (int i = 0; i < 3; i++)
		{
			Sleep(500);
			cout << ".";
			Sleep(500);
			cout << ".";
			Sleep(500);
			cout << "\b\b  \b\b";
		}
		system("cls");
		cout << "Reterning to home.";
		for (int i = 0; i < 3; i++)
		{
			Sleep(500);
			cout << ".";
			Sleep(500);
			cout << ".";
			Sleep(500);
			cout << "\b\b  \b\b";
		}
		system("cls");
		cout << "Now at home!";
		Sleep(2000);
		travels++;
		cout << "\nTravel #" << travels << endl;
		Sleep(2000);
		int a = rand() % 11;
		while (a == 0)
		{
			a = rand() % 11;
		}
		int rand_item = rand() % 5;
		if (rand_item == 2)
		{
			steel_count++;
		}
		else if (rand_item == 3)
		{
			steel_count++;
		}
		else if (rand_item == 4)
		{
			luckySharik_count++;
		}
		return round((a * lvl) * lucky_aura);
	}
	void lvl_up() {
		if (damage >= damage_requirement && health >= health_requirement)
		{
			if (lvl == 5)
			{
				victory();
			}
			upgrade_damage_cost *= 2;
			upgrade_health_cost *= 2;
			damage_requirement += 3 * lvl;
			health_requirement = 5 * lvl;
			lvl++;
		}
		else
		{
			cout << "No enough requirements :(\n";
		}
	}
	void craft_luckyItem() {
		if (steel_count < 3 || luckySharik_count < 1)
		{
			cout << "No enough requirements :(\n";
		}
		else
		{
			steel_count -= 3;
			luckySharik_count--;
			luckyItem_count++;
			cout << "craft successful\n";
		}
	}
	void use_luckyItem() {
		if (luckyItem_count < 1)
		{
			cout << "Where your forse of lucky? You haven`t :(\n";
		}
		else
		{
			luckyItem_count--;
			cout << "You became more lucky\n";
			lucky_aura += 0.2 + (lvl / 10.0);
		}
	}
	void damage_up() {
		if (money >= upgrade_damage_cost)
		{
			damage += lvl;
			money -= upgrade_damage_cost;
		}
		else
		{
			cout << "No enough money :(\n";
		}
	}
	void health_up() {
		if (money >= upgrade_health_cost)
		{
			health += 2 * lvl;
			money -= upgrade_health_cost;
		}
		else
		{
			cout << "No enough money :(\n";
		}
	}
public:
	Character(string name) : name(name) {}
	void menu() {
		int choice = -1;
		while (choice != 0)
		{
			cout << "\n\nMenu:\n"
				<< "Current level: " << lvl << endl
				<< "Money: " << money << endl
				<< "Lucky items: ||" << luckyItem_count << "||\n"
				<< "Current damage: " << damage << endl
				<< "Current health: " << health << endl
				<< endl
				<< "1 - Go to travel (@#" << lucky_aura << "#& LA)\n"
				<< "2 - Craft lucky item (requirements: steel " << steel_count << "/4, lucky sharik " << luckySharik_count << "/1)\n"
				<< "3 - Upgrade damage (cost: " << upgrade_damage_cost << ")\n"
				<< "4 - Upgrade health (cost: " << upgrade_health_cost << ")\n"
				<< "5 - Use lucky item ||@#?#&||\n"
				<< "6 - Go to the next level (requirements: damage " << damage_requirement << ", health " << health_requirement << ")\n"
				<< "0 - Exit game\n"
				<< "Choose: ";
			cin >> choice;
			system("cls");
			switch (choice)
			{
			case 1:
				money += travel();
				break;
			case 2:
				craft_luckyItem();
				break;
			case 3:
				damage_up();
				break;
			case 4:
				health_up();
				break;
			case 5:
				use_luckyItem();
				break;
			case 6:
				lvl_up();
				break;
			case 0:
				exit(1);
				break;
			case 404:
				victory();
				break;
			case 808:
				luckySharik_count = 10;
				steel_count = 40;
				break;
			default:
				cout << "invalid input\n";
			}
		}
	}
};

int main() {
	srand(time(NULL));
	string name;
	cout << "Choose name: ";
	cin >> name;
	cin.ignore();
	system("cls");
	Character ch1(name);
	ch1.menu();
}