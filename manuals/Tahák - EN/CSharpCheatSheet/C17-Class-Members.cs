namespace CSharpCheatSheet;

internal class C17_Class_Members
{
    // Class Members

    // Fields and methods inside classes are often referred to as "Class Members":
    // Create a Car class with three class members : two fields and one method.

    // The class
    public class MyClass
    {
        // Class members
        public string Color = "red";    // field
        public int MaxSpeed = 200;      // field
        public void FullThrottle()      // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    // Fields ---------------------------------

    // In the previous chapter, you learned that variables inside a class are called fields,
    // and that you can access them by creating an object of the class, and by using the dot syntax(.).
    // The following example will create an object of the Car class, with the name myObject.
    // Then we print the value of the fields color and maxSpeed:

    public class Car1
    {
        public string Color = "red";
        public int MaxSpeed = 200;

        public static void CreatingACarAndAccessingTheFields()
        {
            Car1 myObject = new Car1();
            Console.WriteLine(myObject.Color);
            Console.WriteLine(myObject.MaxSpeed);
        }
    }

    // You can also leave the fields blank, and modify them when creating the object
    // This is especially useful when creating multiple objects of one class:

    public class Car2
    {
        public string Model;
        public string Color;
        public int Year;

        public static void CreatingACarAndModifyingTheFields()
        {
            Car2 ford = new Car2();
            ford.Model = "Mustang";
            ford.Color = "red";
            ford.Year = 1969;

            Car2 opel = new Car2();
            opel.Model = "Astra";
            opel.Color = "white";
            opel.Year = 2005;

            Console.WriteLine(ford.Model);
            Console.WriteLine(opel.Model);
        }
    }

    // Object Methods

    // You learned from the C# Methods chapter that methods are used to perform certain actions.
    // Methods normally belongs to a class, and they define how an object of a class behaves.
    // Just like with fields, you can access methods with the dot syntax.However, note that the method must be public.
    // And remember that we use the name of the method followed by two parantheses() and a semicolon ; to call(execute) the method:

    public class Car3
    {
        public string Color;            // field
        public int MaxSpeed;            // field
        public void FullThrottle()      // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        public static void CreatingACarAndCallingItsMethod()
        {
            Car3 myObj = new Car3();
            myObj.FullThrottle();  // Call the method
        }
    }

    // Why did we declare the method as public, and not static?
    // The reason is simple: a static method can be accessed without creating an object of the class, while public methods can only be accessed by objects.

    // Use Multiple Classes
    // Remember from the last chapter, that we can use multiple classes for better organization(one for fields and methods, and another one for execution). This is recommended:


    // Pretend the next two classes are in different files:
    public class Car4
    {
        public string Model;
        public string Color;
        public int Year;
        public void FullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    public class Program
    {
        public static void UsingAClassFromDifferentFile()
        {
            Car4 ford = new Car4();
            ford.Model = "Mustang";
            ford.Color = "red";
            ford.Year = 1969;

            Car4 opel = new Car4();
            opel.Model = "Astra";
            opel.Color = "white";
            opel.Year = 2005;

            Console.WriteLine(ford.Model);
            Console.WriteLine(opel.Model);
        }
    }
    // The "public" keyword is called an access modifier, which specifies that the fields of Car are accessible for other classes as well, such as Program.
    // More on access modifiers on Access-Modifiers page.
}
