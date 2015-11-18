#include "Logo.h"

using namespace std;


void upleft() {
	printf("%c", 201);
}
void upright() {
	printf("%c", 187);
}
void downleft() {
	printf("%c", 200);
}
void downright() {
	printf("%c", 188);
}
void horizontal() {
	printf("%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c%c", 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205, 205);
}
void vertical() {
	printf("%c", 186);
}
void newline() {
	printf("\n");
}
void space() {
	printf("                                      ");
}
void up() {
	upleft();
	horizontal();
	horizontal();
	horizontal();
	horizontal();
	upright();
	newline();
}
void vert() {
	vertical();
	space();
	space();
	vertical();
	newline();
}
void down() {
	downleft();
	horizontal();
	horizontal();
	horizontal();
	horizontal();
	downright();
}
void logo() {
	system("color F0");
	up();
	vert();
	vert();
	down();
	newline();
}