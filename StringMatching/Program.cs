int a = 10;

if(a is > 5)
{
    Console.WriteLine("Greater than 5");
}


int? maybe = null;
if (maybe is int number)
{
    Console.WriteLine(number);
}

else
{
    Console.WriteLine("No value");  
}


int? maybe2 = 10;
if (maybe2 is int number2)
{
    Console.WriteLine(number2);
}
else
{
    Console.WriteLine("No value");
}