//#include <iostream>
//using namespace std;
//
//#include <vector>
//int main() {
//    srand(time(NULL));
//    vector<int>arr;
//    int numb;
//    bool found = false;
//    int size = 10;
//    for (int i = 0; i < size; i++)
//    {
//        if (rand() % 2 == 0)
//        {
//            arr.push_back(rand() % 11);
//        }
//        else
//        {
//            arr.push_back(rand() % 11 * -1);
//        }
//    }
//    for (auto it = arr.begin(); it != arr.end(); it++)
//    {
//        cout << *it << " ";
//    }
//    cout << "\n\n";
//    cout << "Number?: ";
//    cin >> numb;
//    for (auto it = arr.begin(); it != arr.end(); it++)
//    {
//        if (numb == *it)
//        {
//            cout << "ind: " << it - arr.begin() + 1 << endl;
//            found = true;
//        }
//    }
//    if (!found)
//    {
//        cout << "nema takogo";
//    }
//}
//
//int main() {
//    srand(time(NULL));
//    vector<int>arr;
//    int numb;
//    bool found = false;
//    int size = 10;
//    for (int i = 0; i < size; i++)
//    {
//        if (rand() % 2 == 0)
//        {
//            arr.push_back(rand() % 11);
//        }
//        else
//        {
//            arr.push_back(rand() % 11 * -1);
//        }
//    }
//    for (int num : arr) cout << num << " ";
//    for (auto it = arr.begin(); it != arr.end();)
//    {
//        if (*it % 2 != 0)
//        {
//            it = arr.erase(it);
//        }
//        else
//        {
//            it++;
//        }
//    }
//    cout << "\n\n";
//    for (int num : arr) cout << num << " ";
//}