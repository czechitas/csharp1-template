namespace CSharpCheatSheet;

internal class C18_Constructors
{
    // C# Constructors

    // A constructor is a special method that is used to initialize objects.
    // The advantage of a constructor, is that it is called when an object of a class is created.It can be used to set initial values for fields:


    // Create a constructor:

    // Create a Car class
    public class Car
    {
        public string Model;  // Create a field

        // Create a class constructor for the Car class
        public Car()
        {
            Model = "Mustang"; // Set the initial value for model
        }

        public void CreatingAnObjectUsingConstructor()
        {
            Car Ford = new Car();  // Create an object of the Car Class (this will call the constructor)
            Console.WriteLine(Ford.Model);  // Print the value of model
        }
    }
    // Outputs "Mustang"


    // Note that the constructor name must match the class name, and it cannot have a return type(like void or int).
    // Also note that the constructor is called when the object is created.
    // All classes have constructors by default: if you do not create a class constructor yourself, C# creates one for you. However, then you are not able to set initial values for fields.


    // Constructor Parameters

    // Constructors can also take parameters, which is used to initialize fields.
    // The following example adds a string modelName parameter to the constructor.
    // Inside the constructor we set model to modelName (model = modelName).
    // When we call the constructor, we pass a parameter to the constructor("Mustang"), which will set the value of model to "Mustang":


    public class Car2
    {
        public string model;

        // Create a class constructor with a parameter
        public Car2(string modelName)
        {
            model = modelName;
        }

        public static void CreatingAnObjectUsingConstructorWithParameter()
        {
            Car2 Ford = new Car2("Mustang");
            Console.WriteLine(Ford.model);
        }
    }

    // Outputs "Mustang"

    // You can have as many parameters as you want:

    public class CarWithConstructor
    {
        public string Model;
        public string Color;
        public int Year;

        // Create a class constructor with multiple parameters
        public CarWithConstructor(string modelName, string modelColor, int modelYear)
        {
            Model = modelName;
            Color = modelColor;
            Year = modelYear;
        }

        static void CreatingAnObjectUsingConstructorWithMultipleParameters()
        {
            CarWithConstructor Ford = new CarWithConstructor("Mustang", "Red", 1969);
            Console.WriteLine(Ford.Color + " " + Ford.Year + " " + Ford.Model);
        }
    }
    // Outputs Red 1969 Mustang


    // Tip: Just like other methods, constructors can be overloaded by using different numbers of parameters.

    // Constructors Save Time
    // When you consider the example from the previous chapter, you will notice that constructors are very useful, as they help reducing the amount of code

    // Two examples of a class WITH constructor and WITHOUT constructor

    // WITHOUT CONSTRUCTOR
    public class CarWithNoConstructor
    {
        public string Model;
        public string Color;
        public int Year;
    }

    public class ProgramWithoutConstructor
    {
        public static void ClassTest()
        {
            CarWithNoConstructor ford = new CarWithNoConstructor();
            ford.Model = "Mustang";
            ford.Color = "red";
            ford.Year = 1969;

            CarWithNoConstructor opel = new CarWithNoConstructor();
            opel.Model = "Astra";
            opel.Color = "white";
            opel.Year = 2005;

            Console.WriteLine(ford.Model);
            Console.WriteLine(opel.Model);
        }
    }

    // WITH CONSTRUCTOR

    public class ProgramWithConstructor
    {
        static void RunningProgramWithConstructor()
        {
            CarWithConstructor ford = new CarWithConstructor("Mustang", "Red", 1969);
            CarWithConstructor opel = new CarWithConstructor("Astra", "White", 2005);

            Console.WriteLine(ford.Model);
            Console.WriteLine(opel.Model);
        }
    }
}

