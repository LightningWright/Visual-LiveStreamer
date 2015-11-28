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


using namespace std;


int main() {

	//Clean current lines if launched on console
	system("cls");

	//LiveStreamer Controlled Variables
	string exename = "livestreamer-core.exe"; //Core Name
	string rutaexe = "bin\\"; // Folder of LiveStreamer's Core	
	string channel = ""; //Input Channel
	string web = "";	// Web Service
	string in_web = ""; // Input Web Service
	string quality = ""; // Video Quality
	string in_quality = ""; // Input Video Quality
	string config = "--config ./cfg/config.cfg"; // Args of Core.exe
	string delay = "--hds-live-edge 1";	// Removes Stream Delay

	logo();

	// Service Detection System
	cout << "Available Stream Servers\n";
	cout << "YouTube, Twitch\n";
	getline(cin, in_web);

	if (in_web == "Twitch") {
		web = "twitch.tv/";
	}
	else if (in_web == "twitch") {
		web = "twitch.tv/";
	}
	else if (in_web == "twitchtv") {
		web = "twitch.tv/";
	}
	else if (in_web == "TWITCH") {
		web = "twitch.tv/";
	}
	else if (in_web == "YouTube") {
		web = "youtube.com/";
	}
	else if (in_web == "youtube") {
		web = "youtube.com/";
	}
	else if (in_web == "Youtube") {
		web = "youtube.com/";
	}
	else if (in_web == "YOUTUBE") {
		web = "youtube.com/";
	}
	else { //Exception #1
		ex1();
		return 0;

	}
	system("cls");

	logo();

	cout << "Introduce el nombre del canal que quieres ver:\n>";
	getline(cin, channel);
	system("cls");

	logo();

	cout << "Introduce la calidad a la que quieres ver el stream:\n>";
	cout << "Source , Alta , Media , Baja\n\n";
	getline(cin, in_quality);
	if (in_quality == "Source") {
		quality = "best";
	}
	else if (in_quality == "source") {
		quality = "best";
	}
	else if (in_quality == "Alta") {
		quality = "high";
	}
	else if (in_quality == "alta") {
		quality = "high";
	}
	else if (in_quality == "Media") {
		quality = "medium";
	}
	else if (in_quality == "media") {
		quality = "medium";
	}
	else if (in_quality == "Baja") {
		quality = "360p";
	}
	else if (in_quality == "baja") {
		quality = "low";
	}
	else {
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

// ERROR 0x298c VLC MP4 DECODER
// ERROR 0x1960 VLC MP3 DECODER
// ERROR 0x244 VLC HW ACCELERATION