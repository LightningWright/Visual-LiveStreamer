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

int svcNum;
int qtyNum;

int main() {

	//Clean current lines if launched on console
	system("cls");

	//LiveStreamer Controlled Variables
	string exename = "livestreamer-core.exe"; //Core Name
	string rutaexe = "bin\\"; // Folder of LiveStreamer's Core	
	string channel = ""; //Input Channel
	string web = "";	// Web Service
	string quality = ""; // Video Quality
	string config = "--config ./cfg/config.cfg"; // Args of Core.exe
	string delay = "--hds-live-edge 1";	// Removes Stream Delay

	// Service Detection System
	logo();
	
	cout << "Available Stream Servers\n";
	cout << "YouTube, Twitch\n";
	
	svc();
	if (svcNum == 1){
		web = "twitch.tv/";
	}
	else if (svcNum == 2) {
		web = "youtube.com/";
	}
	else{
		ex1();
		return 0;
	}
	system("cls");	//END
	
	// Channel Detection System
	logo();	
	
	cout << "Introduce el nombre del canal que quieres ver:\n>";
	
	getline(cin, channel);
	system("cls");
	// Quality Detection System
	logo();

	cout << "Introduce la calidad a la que quieres ver el stream:\n>";
	cout << "Source , High , Medium , Low , Audio\n\n";
	
	if (svcNum == 1){
		twitch();
	}
	else if (svcNum == 2){
		youtube();
	}
	else{
		ex1();
		return 0;
	}
	
	if (qtyNum == 11){     // 1x Twitch
		quality = "best";
	}
	else if (qtyNum == 12) {
		quality = "medium";
	}
	else if (qtyNum == 21) {		// 2x YouTube
		quality = "best";
	}
	else if (qtyNum == 22) {
		quality = "360p";
	}
	else if (qtyNum == 23) {
		quality = "240p";
	}
	else if (qtyNum == 24) {
		quality = "audio_mp4";
	}	
	else{
		quality = "best";
	}
	

	system("color FA");
	system((rutaexe + exename + " " + delay + " " + web + channel + " " + quality + " " + config).c_str());
	system("color F0");
	return 0;
}
//TODO
/*
*	Hacer un plugin para los comentarios
*	Hacer un sistema de excepciones
*	
*/
