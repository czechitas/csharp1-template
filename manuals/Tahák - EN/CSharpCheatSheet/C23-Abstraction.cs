namespace CSharpCheatSheet;

internal class C23_Abstraction
{
    // Abstract Classes and Methods

    // Data abstraction is the process of hiding certain details and showing only essential information to the user.
    // Abstraction can be achieved with either abstract classes or interfaces.

    // The abstract keyword is used for classes and methods:
    //      - Abstract class: is a restricted class that cannot be used to create objects(to access it, it must be inherited from another class).
    //      - Abstract method: can only be used in an abstract class, and it does not have a body.The body is provided by the derived class (inherited from).

    // An abstract class can have both abstract and regular methods:
    public abstract class AnimalExample
    {
        public abstract void AnimalSound();
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // From the example above, it is not possible to create an object of the Animal class:

    //AnimalExample myObj = new AnimalExample(); // Will generate an error (Cannot create an instance of the abstract class or interface 'Animal')

    // To access the abstract class, it must be inherited from another class.
    // Let's convert the Animal class we used in the Polymorphism chapter to an abstract class.
    // Remember from Inheritance that we use the : symbol to inherit from a class, and that we use the override keyword to override the base class method.

    // Abstract class
    public abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void AnimalSound();
        // Regular method
        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    // Derived class (inherit from Animal)
    public class Pig : Animal
    {
        public override void AnimalSound()
        {
            // The body of AnimalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    public class UsingClassDerivedFromAbstractClass
    {
        public static void CreatingAPigClass()
        {
            Pig myPig = new Pig(); // Create a Pig object
            myPig.AnimalSound();  // Call the abstract method
            myPig.Sleep();  // Call the regular method
        }
    }

    // Why And When To Use Abstract Classes and Methods?
    // To achieve security - hide certain details and only show the important details of an object.
    // Note: Abstraction can also be achieved with Interfaces
}
