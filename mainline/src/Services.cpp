#include "Services.h"
#include "Logo.h"
#include<string>
#include<sstream>

using namespace std;

extern int svcNum;
extern int qtyNum;

void svc(){
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
		return;
	}
}

void twitch(){
	
	logo();
	
	cout << "Twitch Qualities: Source, High, Medium, Low, Audio.\n";
	cout << "Select desired quality:\n\n>";
	
	string in_quality = "";
	
	getline(cin, in_quality);
	
	if (in_quality == "Source") {
		qtyNum = 11;
	}
	else if (in_quality == "source") {
		qtyNum = 11;
	}
	else if (in_quality == "High") {
		qtyNum = 12;
	}
	else if (in_quality == "high") {
		qtyNum = 12;
	}
	else if (in_quality == "Medium") {
		qtyNum = 13;
	}
	else if (in_quality == "medium") {
		qtyNum = 13;
	}
	else if (in_quality == "Low") {
		qtyNum = 14;
	}
	else if (in_quality == "low") {
		qtyNum = 14;
	}
	else if (in_quality == "Audio") {
		qtyNum = 15;
	}
	else if (in_quality == "audio") {
		qtyNum = 15;
	}
	else {
		return;
	}
}
void youtube(){
	
	logo();
	
	cout << "YouTube Qualities: High (720p), Medium (360p), Low (240p), Audio.\n";
	cout << "Select desired quality:\n\n>";
	
	string in_quality = "";
	
	getline(cin, in_quality);

	if (in_quality == "High") {
		qtyNum = 21;
	}
	else if (in_quality == "high") {
		qtyNum = 21;
	}
	else if (in_quality == "Medium") {
		qtyNum = 22;
	}
	else if (in_quality == "medium") {
		qtyNum = 22;
	}
	else if (in_quality == "Low") {
		qtyNum = 23;
	}
	else if (in_quality == "low") {
		qtyNum = 23;
	}
	else if (in_quality == "Audio") {
		qtyNum = 24;
	}
	else if (in_quality == "audio") {
		qtyNum = 24;
	}
	else {
		return;
	}
	
}

