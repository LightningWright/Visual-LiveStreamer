/*
* Visual Livestreamer port from chrippa's Program
*      Author: Victor Prieto Laso
*/

#include<stdlib.h>
#include<stdio.h>
#include<iostream>
#include<string>
#include<sstream>
#include "Logo.h"
#include "Exception.h"
#include "Services.h"


using namespace std;

int svcNum; // Service number var
int qtyNum;

int main() {

	//Clean current lines if launched on console
	system("cls");

	// Service Detection System
	logo();
	cout << "Available Stream Services\n";
	cout << "[1] Twitch, [2] YouTube\n";
	
	
	//
	string in_web = ""; // Input Video Quality
	getline(cin, in_web);

	if (in_web == "Twitch") {
		svcNum = 1;
	}
	else if (in_web == "twitch") {
		svcNum = 1;
	}
	else if (in_web == "TWITCH") {
		svcNum = 1;
	}
	else if (in_web == "1") {
		svcNum = 1;
	}
	else if (in_web == "YouTube") {
		svcNum = 2;
	}
	else if (in_web == "youtube") {
		svcNum = 2;
	}
	else if (in_web == "Youtube") {
		svcNum = 2;
	}
	else if (in_web == "YOUTUBE") {
		svcNum = 2;
	}
	else if (in_web == "2") {
		svcNum = 2;
	}
	else { //Exception #1
		ex1();
	}
	//
	
	if (svcNum == 1){
		twitch();
	}
	else if (svcNum == 2) {
		youtube();
	}
	else{
		return 0;
	}
	return 0;
	system("cls");	//END
	
}


//TODO
/*
*	Hacer un plugin para los comentarios
*	Hacer un sistema de excepciones
*	
*/
