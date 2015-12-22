#include "Services.h"
#include "Logo.h"
#include<string>
#include<sstream>

using namespace std;

extern int svcNum;

void twitch(){
	system("cls");
	
	//String Declaration
	string in_qlty = "";
	string quality = "";
	string channel = "";
	
	//Channel
	logo();
	cout << "Type the channel name:\n>";
	getline(cin, channel);
	system("cls");
	
	//Quality
	logo();	
	cout << "Twitch Qualities: Source, High, Medium, Low, Audio.\n";
	cout << "Select desired quality:\n\n>";
	
	getline(cin, in_qlty);
	
	if (in_qlty == "Source") {
		quality = "source";
	}
	else if (in_qlty == "source") {
		quality = "source";
	}
	else if (in_qlty == "High") {
		quality = "high";
	}
	else if (in_qlty == "high") {
		quality = "high";
	}
	else if (in_qlty == "Medium") {
		quality = "medium";
	}
	else if (in_qlty == "medium") {
		quality = "medium";
	}
	else if (in_qlty == "Low") {
		quality = "low";
	}
	else if (in_qlty == "low") {
		quality = "low";
	}
	else if (in_qlty == "Audio") {
		quality = "audio";
	}
	else if (in_qlty == "audio") {
		quality = "audio";
	}
	else {
		return;
	}
	
	system("color FA");
	system(("bin\\livestreamer-core.exe --hds-live-edge 1 http://twitch.tv/"+ channel + " " + quality +" --config ./cfg/config.cfg").c_str());
	system("color F0");
	return;
}

void youtube(){
	//Clean
	system("cls");
	
	//String Declaration
	string in_qlty = "";
	string quality = "";
	string video = "";
	
	logo(); 
	cout << "Type the video link <watch?v=xyz> :\n>";
	getline(cin, video);
	system("cls");
	
	logo();	//Decoration
	cout << "YouTube Qualities: High (720p), Medium (360p), Low (240p), Audio.\n";
	cout << "Select desired quality:\n\n>";
	
	getline(cin, in_qlty);

	if (in_qlty == "High") {
		quality = "best";
	}
	else if (in_qlty == "high") {
		quality = "best";
	}
	else if (in_qlty == "Medium") {
		quality = "360p";
	}
	else if (in_qlty == "medium") {
		quality = "360p";
	}
	else if (in_qlty == "Low") {
		quality = "worst";
	}
	else if (in_qlty == "low") {
		quality = "worst";
	}
	else if (in_qlty == "Audio") {
		quality = "audio_mp4";
	}
	else if (in_qlty == "audio") {
		quality = "audio_mp4";
	}
	else {
		return;
	}
	
	system("color FA");
	system(("bin\\livestreamer-core.exe --hds-live-edge 1 http://youtube.com/"+ video + " " + quality +" --config ./cfg/config.cfg").c_str());
	system("color F0");
	return;
}

