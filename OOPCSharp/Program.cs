// See https://aka.ms/new-console-template for more information
using OOPCSharp;

string newLine = "//////////////////////////////////////////";

Console.WriteLine("Interfaces");

Dog myDog = new();
myDog.DogBarking();

IDogWalker otherDog = new Dog();
otherDog.WalkToThePark();

Console.WriteLine(newLine);

//////////////////////////////////
