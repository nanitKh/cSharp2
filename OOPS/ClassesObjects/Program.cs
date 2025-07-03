/*using System;

public class Program
{
    public static void display()
    {
        Console.WriteLine("Dsiplay method called");
    }
    public static void Main(String[] args)
    {
        display();
    }
}*/



using System;


public class Dog
{

    public string Name { get; set; }
    public string Breed { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    public Dog(string name, string breed, int age, string color)
    {
        Name = name;
        Breed = breed;
        Age = age;
        Color = color;
    }

    public override string ToString()
    {
        return $"My name is: {Name}\nMy breed is: {Breed}\nMy age is: {Age}\nAnd my colour is {Color}";
    }

    public static void Main(string[] args)
    {
        Dog tuffy = new Dog("Tuffy", "Papillon", 5, "White");
        Console.WriteLine(tuffy.ToString());
    }
}

