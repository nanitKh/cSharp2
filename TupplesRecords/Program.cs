//Tupples
var ms = (X: 1, Y: 2);
Console.WriteLine($" Points are : X: {ms.X}, Y: {ms.Y}");

ms.X = ms.X + 5;
Console.WriteLine($" Points are : X: {ms.X}, Y: {ms.Y}");

// Records
public record Point(int X, int Y);

public static void Main()
{
    Point pt = new Point(1, 1);
    var pt2 = pt with { Y = 10 };
    Console.WriteLine($"The two points are {pt} and {pt2}");
}