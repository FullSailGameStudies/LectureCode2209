// Day11CPP.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include "Day11CPP.h"
#include <vector>
using namespace std;//generally considered to be bad! to do this

typedef long long Batman;

enum Superpower
{
	Money, Hair, Strength, Speed, FishWhisperer, ShapeShifting
};
//GLOBAL NAMESPACE

//forward declaration
void PrintPowers(Superpower myPower);

int main()
{
	//std - standard namespace
	//::  - scope resolution operator
	//cout - console output stream
	//<< - insertion operator
	std::cout << "Hello Gotham!\n" << 5 << "\n" << "Batman";

	int age = 12;
	bool isBatmanTheBest = true;
	float batmansIQ = 300.5F;
	char b = 'B';

	cout << sizeof(age) << " bytes\n";
	cout << sizeof(char) << " bytes\n";

	char best[] = "Batman";//adds a \0 (null terminator)
	char meh[] = { 'A','q','u','a','m','a','n' };

	cout << best << "\n";
	cout << meh << "\n";

	for (int i = 0; i < sizeof(best)/sizeof(char); i++)
	{
		cout << best[i];
	}

	srand(time(NULL));
	int rando = rand();//0-RAND_MAX
	rando = rand() % 101;//0-100

	Superpower power = Superpower::ShapeShifting;
	PrintPowers(power);

	vector<int> scores;// stack variable
	scores.push_back(rand());//same as Add method in C# List
	scores.push_back(rand());
	scores.push_back(rand());
	scores.push_back(rand());

	cout << "\nSCORES\n";
	for (size_t i = 0; i < scores.size(); i++)
	{
		cout << scores[i] << "\n";
	}
}

void PrintPowers(Superpower myPower)
{

	switch (myPower)
	{
	case Money:
		break;
	case Hair:
		break;
	case Strength:
		break;
	case Speed:
		break;
	case FishWhisperer:
		break;
	case ShapeShifting:
		cout << myPower;
		break;
	default:
		break;
	}
}