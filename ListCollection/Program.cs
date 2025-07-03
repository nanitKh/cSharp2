List<string> names = ["Nanit", "Devyansh", "Mohit", "Yash" ];
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine();
names.Add("Kartik");
names.Add("Rohit");
names.Remove("Yash");
foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}



//SORTING IN LIST
names.Sort();

foreach (var name in names)
{
    Console.WriteLine($"Sorted Name: {name}");
}


//SEARCHING IN LIST
//WITH THE HELP OF INDEXOF KEYWORD

int index = names.IndexOf("Mohit");
if (index != -1)
{
    Console.WriteLine($"Found Mohit at index: {index}");
}
else
{
    Console.WriteLine("Mohit not found in the list.")
}