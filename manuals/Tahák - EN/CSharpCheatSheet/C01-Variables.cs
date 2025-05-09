﻿namespace CSharpCheatSheet;

internal class C01_Variables
{
    public void Variables()
    {
        /*
         C# Variables
         Variables are containers for storing data values.

         In C#, there are different types of variables (defined with different keywords), for example:
             int - stores integers(whole numbers), without decimals, such as 123 or -123
             double - stores floating point numbers, with decimals, such as 19.99 or -19.99
             char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes
             string - stores text, such as "Hello World". String values are surrounded by double quotes
             bool - stores values with two states: true or false

         Declaring (Creating) Variables
         To create a variable, you must specify the type and assign it a value:
             type variableName = value;
             int newVariable = 10;

         */

        // Create a variable called name of type string and assign it the value "John":
        string name = "John";
        Console.WriteLine(name);

        // Create a variable called myNum of type int and assign it the value 15:
        int myNum = 15;
        Console.WriteLine(myNum);

        // You can also declare a variable without assigning the value, and assign the value later:
        int myNum2;
        myNum2 = 15;
        Console.WriteLine(myNum2);

        // Note that if you assign a new value to an existing variable, it will overwrite the previous value:
        // Change the value of myNum to 20:
        int myNum3 = 15;
        myNum3 = 20; // myNum3 is now 20
        Console.WriteLine(myNum3);

        // A demonstration of how to declare variables of other types:
        int myNum4 = 5;
        double myDoubleNum = 5.99D;
        char myLetter = 'D';
        bool myBool = true;
        string myText = "Hello";

        // -------------------------------------------------------------------------------------------------------------

        // Constants

        // If you don't want others (or yourself) to overwrite existing values, you can add the const keyword in front of the variable type.
        // This will declare the variable as "constant", which means unchangeable and read - only:

        const int myNum5 = 15;
        //TRYME// myNum5 = 20; // error

        // -------------------------------------------------------------------------------------------------------------

        // Display Variables

        //The WriteLine() method is often used to display variable values to the console window.
        //To combine both text and a variable, use the +character:

        string newName = "John";
        Console.WriteLine("Hello " + newName);

        // You can also use the + character to add a variable to another variable:
        string firstName = "John ";
        string lastName = "Doe";
        string fullName = firstName + lastName;
        Console.WriteLine(fullName);

        // For numeric values, the + character works as a mathematical operator (notice that we use int(integer) variables here):
        int x = 5;
        int y = 6;
        Console.WriteLine(x + y); // 11 - Print the value of x + y

        // -------------------------------------------------------------------------------------------------------------

        // Declare Many Variables

        // To declare more than one variable of the same type, use a comma-separated list:

        int x1 = 5, y1 = 6, z1 = 50;
        Console.WriteLine(x1 + y1 + z1);

        // You can also assign the same value to multiple variables in one line:

        int x2, y2, z2;
        x2 = y2 = z2 = 50;
        Console.WriteLine(x2 + y2 + z2);

        // -------------------------------------------------------------------------------------------------------------

        // Data Types
        // A variable in C# must be a specified data type:

        // int myNum = 5;               // Integer (whole number)   // Stores whole numbers from -2,147,483,648 to 2,147,483,647
        // double myDoubleNum = 5.99D;  // Floating point number    // Stores fractional numbers. Sufficient for storing 15 decimal digits
        // char myLetter = 'D';         // Character                // Stores a single character/letter, surrounded by single quotes
        // bool myBool = true;          // Boolean                  // Stores true or false values
        // string myText = "Hello";     // String                   // Stores a sequence of characters, surrounded by double quotes

        // -------------------------------------------------------------------------------------------------------------

        // Type Casting

        // Type casting is when you assign a value of one data type to another type.
        // In C#, there are two types of casting:

        // Implicit Casting(automatically) -converting a smaller type to a larger type size
        // char -> int -> long -> float -> double

        // Explicit Casting(manually) - converting a larger type to a smaller size type
        // double -> float -> long -> int -> char

        // Implicit Casting is done automatically when passing a smaller size type to a larger size type:

        int myInt = 9;
        double myDouble = myInt;       // Automatic casting: int to double

        Console.WriteLine(myInt);      // Outputs 9
        Console.WriteLine(myDouble);   // Outputs 9

        // Explicit Casting must be done manually by placing the type in parentheses in front of the value:

        double myNewDouble = 9.78;
        int myNewInt = (int)myNewDouble;    // Manual casting: double to int

        Console.WriteLine(myNewDouble);   // Outputs 9.78
        Console.WriteLine(myNewInt);      // Outputs 9

        // Type Conversion Methods
        // It is also possible to convert data types explicitly by using built-in methods, such as Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32(int) and Convert.ToInt64(long):

        int myIntVariable = 10;
        double myDoubleVariable = 5.25;
        bool myBoolVariable = true;

        Console.WriteLine(Convert.ToString(myIntVariable));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myIntVariable));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDoubleVariable));  // convert double to int
        Console.WriteLine(Convert.ToString(myBoolVariable));   // convert bool to string

        // -------------------------------------------------------------------------------------------------------------

        // Get User Input
        // You have already learned that Console.WriteLine() is used to output(print) values.Now we will use Console.ReadLine() to get user input.
        // In the following example, the user can input his or hers username, which is stored in the variable userName.Then we print the value of userName:

        // Type your username and press enter
        Console.WriteLine("Enter username:");

        // Create a string variable and get user input from the keyboard and store it in the variable
        string userName = Console.ReadLine();

        // Print the value of the variable (userName), which will display the input value
        Console.WriteLine("Username is: " + userName);

        // The Console.ReadLine() method returns a string.
        // Therefore, you cannot get information from another data type, such as int
        // Cannot implicitly convert type 'string' to 'int'

        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
    }
}
