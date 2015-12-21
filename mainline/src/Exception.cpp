#include "Exception.h"
#include<string>
#include<sstream>

using namespace std;



void ex1(){
	string exception; 

	system("cls");
	system("color F4");
	cout << "[Exception 1]  Not Supported Service\n\n";
	cout << "  Press ANY key to close\n\n";
	getline(cin, exception);
	system("color F0");
	system("cls");
	return;
}
void ex2(){
	string exception; 

	system("cls");
	system("color F4");
	cout << "[Exception 2]  Not Supported Quality\n\n";
	cout << "  Press ANY key to close\n\n";
	getline(cin, exception);
	system("color F0");
	system("cls");
	return;
}