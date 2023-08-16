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

Console.WriteLine("Abstract Classes");

PingIPV6 pingIPV6 = new();
Console.WriteLine(pingIPV6.Init());
Console.WriteLine(pingIPV6.SendPing());

PingIPV4 pingIPV4 = new();
Console.WriteLine(pingIPV4.Init());
Console.WriteLine(pingIPV4.SendPing());

Console.WriteLine(newLine);

//////////////////////////////////

Console.WriteLine("Polymorphism");

// Many forms - Type

class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Turtle : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("Turtle noise");
    }
}

