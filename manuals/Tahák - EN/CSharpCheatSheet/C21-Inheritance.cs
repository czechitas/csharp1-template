namespace CSharpCheatSheet;

internal class C21_Inheritance
{
    // Inheritance (Derived and Base Class)

    // In C#, it is possible to inherit fields and methods from one class to another.
    // We group the "inheritance concept" into two categories:
    //      - Derived Class(child) - the class that inherits from another class
    //      - Base Class(parent) - the class being inherited from

    // To inherit from a class, use the : symbol.
    // In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):

    public class Vehicle  // base class (parent)
    {
        public string Brand = "Ford";  // Vehicle field
        public void Honk()             // Vehicle method
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    public class Car : Vehicle  // derived class (child)
    {
        public string ModelName = "Mustang";  // Car field
    }

    public class UsingDerivedClass
    {
        public static void CreatingADerivedClass()
        {
            // Create a myCar object
            Car myCar = new Car(); // (derived from Vehicle class)

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.Honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.Brand + " " + myCar.ModelName);
        }
    }

    // Why And When To Use "Inheritance"?
    //  - It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.

    //   Tip: Also take a look at the next chapter, Polymorphism, which uses inherited methods to perform different tasks.


}
