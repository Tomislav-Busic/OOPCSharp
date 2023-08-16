// See https://aka.ms/new-console-template for more information
using OOPCSharp;

internal class Program
{
    private static void Main(string[] args)
    {
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

        Animal turtle = new();
        turtle.animalSound();

        // Better example

        TestData testPolymorphism = new();
        int add2 = testPolymorphism.Add(2, 6, 7);
        int add1 = testPolymorphism.Add(4, 6);

        Console.WriteLine($"Result1: {add1}, Result2: {add2}");

        Console.WriteLine(newLine);

        //////////////////////////////////

        Console.WriteLine("Pass By Reference");

        PassByReference passByRef = new();

        Console.WriteLine(passByRef);

        Console.WriteLine(newLine);

        //////////////////////////////////
        
        Console.WriteLine("NULL Conditional and Coalescing Operators");

        NullConditional nullCon = new();

        Console.WriteLine(nullCon);

        Console.WriteLine(newLine);

        //////////////////////////////////
        
        Console.WriteLine("Constructors");

        ConstructorExample conExe = new("Tomo");

        Console.WriteLine(conExe.Name);

        Console.WriteLine(newLine);

        //////////////////////////////////
    }
}

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

public class TestData
{
    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}

