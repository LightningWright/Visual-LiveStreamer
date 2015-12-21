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
	
	cout << "Available Stream Services\n";
	cout << "[1] Twitch, [2] YouTube\n";
	
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
	
	if (svcNum == 1){
		twitch();
		if (qtyNum == 11){
			quality = "source";
		}
		else if (qtyNum == 12) {
			quality = "high";
		}
		else if (qtyNum == 13) {
			quality = "medium";
		}
		else if (qtyNum == 14) {
			quality = "low";
		}
		else if (qtyNum == 15) {
			quality = "audio";
		}
		else {
			ex2();
		}
	}
	else if (svcNum == 2){
		youtube();
		
		if (qtyNum == 21) {		// 2x YouTube
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
			ex2();
		}
	}
	else{
		ex1();
		return 0;
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
