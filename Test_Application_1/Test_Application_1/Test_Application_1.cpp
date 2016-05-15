// Test_Application_1.cpp : main project file.

#include "stdafx.h"
#include <iostream>
#include <string>

using namespace System;

int main(array<System::String ^> ^args)		// Main function, the array is any command line arguments passed to the application
											// This will also work simple as main(),
											// Shown is the default Microsoft way, I use a standard C++ alteration.
{
	printf("Hello World\n\n");				// Standard C++ Version
    Console::WriteLine(L"Hello World");		// Microsoft Version
	std::string input;						// String to contain our input
	std::getline(std::cin, input);			// C++ getline, using C cin as its stream, this is just to keep the dialog from closing.
    return 0;
}
