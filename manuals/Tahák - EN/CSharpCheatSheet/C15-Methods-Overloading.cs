namespace CSharpCheatSheet;

internal class C15Methods_Overloading
{
    // Method Overloading

    /* With method overloading, multiple methods can have the same name with different parameters:
        - int MyMethod(int x)
        - float MyMethod(float x)
        - double MyMethod(double x, double y)
    Consider the following example, which have two methods that add numbers of different type: */

    public static int PlusMethodInt(int x, int y)
    {
        return x + y;
    }

    public static double PlusMethodDouble(double x, double y)
    {
        return x + y;
    }

    public static void CallingSeparatePlusMethod()
    {
        int myNum1 = PlusMethodInt(8, 5);
        double myNum2 = PlusMethodDouble(4.3, 6.26);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }

    // Instead of defining two methods that should do the same thing, it is better to overload one.
    // In the example below, we overload the PlusMethod method to work for both int and double:
    public static int PlusMethod(int x, int y)
    {
        return x + y;
    }

    public static double PlusMethod(double x, double y)
    {
        return x + y;
    }

    public static void CallingOverloadedPlusMethod()
    {
        int myNum1 = PlusMethod(8, 5);
        double myNum2 = PlusMethod(4.3, 6.26);
        Console.WriteLine("Int: " + myNum1);
        Console.WriteLine("Double: " + myNum2);
    }
    // Note: Multiple methods can have the same name as long as the number and/or type of parameters are different.
}
