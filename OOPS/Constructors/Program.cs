using System;

public class DemoConstructors
{
    // Default Constructor
    public DemoConstructors()
    {
        Console.WriteLine("Default Constructor Called");
    }

    // Parameterized Constructor
    public DemoConstructors(int value)
    {
        Console.WriteLine($"Parameterized Constructor Called with value: {value}");
    }

    // Copy Constructor
    public DemoConstructors(DemoConstructors other)
    {
        Console.WriteLine("Copy Constructor Called");
    }

    // Static Constructor
    static DemoConstructors()
    {
        Console.WriteLine("Static Constructor Called");
    }

    // Private Constructor
    private DemoConstructors(string message)
    {
        Console.WriteLine($"Private Constructor Called with message: {message}");
    }

    // Method to demonstrate calling the private constructor from within the class
    public static void CallPrivateConstructor()
    {
        var obj = new DemoConstructors("Hello from private constructor");
    }

    public static void Main(string[] args)
    {
        

        DemoConstructors d1 = new DemoConstructors();           // Default Constructor
        DemoConstructors d2 = new DemoConstructors(42);         // Parameterized Constructor
        DemoConstructors d3 = new DemoConstructors(d1);         // Copy Constructor
        CallPrivateConstructor();                               // Private Constructor (called from within the class)
    }
}
