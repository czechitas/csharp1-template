﻿namespace CSharpCheatSheet;

internal class C24_Interface
{
    // Interfaces

    // Another way to achieve abstraction in C#, is with interfaces.
    // An interface is a completely "abstract class", which can only contain abstract methods and properties(with empty bodies) :

    // interface
    public interface AnimalExample
    {
        public void AnimalSound(); // interface method (does not have a body)
        public void Run(); // interface method (does not have a body)
    }

    // It is considered good practice to start with the letter "I" at the beginning of an interface,
    // as it makes it easier for yourself and others to remember that it is an interface and not a class.
    // By default, members of an interface are abstract and public.
    // Note: Interfaces can contain properties and methods, but not fields.

    // To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class.
    // To implement an interface, use the : symbol (just like with inheritance).
    // The body of the interface method is provided by the "implement" class.
    // Note that you do not have to use the override keyword when implementing an interface:

    // Interface
    public interface IAnimal
    {
        public void AnimalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    public class Pig : IAnimal
    {
        public void AnimalSound()
        {
            // The body of AnimalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public class UsingPigObject
    {
        public static void CreatingAPigObject()
        {
            Pig myPig = new Pig();  // Create a Pig object
            myPig.AnimalSound();
        }
    }

    // Notes on Interfaces:
    //      - Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
    //      - Interface methods do not have a body - the body is provided by the "implement" class
    //      - On implementation of an interface, you must override all of its methods
    //      - Interfaces can contain properties and methods, but not fields/variables
    //      - Interface members are by default abstract and public
    //      - An interface cannot contain a constructor(as it cannot be used to create objects)

    // Why And When To Use Interfaces?
    //  1) To achieve security - hide certain details and only show the important details of an object (interface).
    //  2) C# does not support "multiple inheritance" (a class can only inherit from one base class).
    //  However, it can be achieved with interfaces, because the class can implement multiple interfaces.
    //  Note: To implement multiple interfaces, separate them with a comma (see example below).


    // Multiple Interfaces
    // To implement multiple interfaces, separate them with a comma:

    public interface IFirstInterface
    {
        public void MyMethod(); // interface method
    }

    public interface ISecondInterface
    {
        public void MyOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    public class DemoClass : IFirstInterface, ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void MyOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    public class UsingDemoClass
    {
        static void CreatingADemoClass()
        {
            DemoClass myObject = new DemoClass();
            myObject.MyMethod();
            myObject.MyOtherMethod();
        }
    }
}
