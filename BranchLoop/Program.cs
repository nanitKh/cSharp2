//IF    
int a = 5;
int b = 6;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10.");

//IF ELSE
int a = 5;
int b = 3;
if (a + b > 10)
    Console.WriteLine("The answer is greater than 10");
else
    Console.WriteLine("The answer is not greater than 10");

//AND OR
int a = 5;
int b = 6;
int c = 3;
int d = 6;
if(a + b > 10 && c + d > 10)
    Console.WriteLine("Both conditions are true.");
else if (a + b > 10 || c + d > 10)
    Console.WriteLine("At least one condition is true.");
else
    Console.WriteLine("Neither condition is true.");


//WHILE LOOP
int i = 0;
while (i < 5)
{
    Console.WriteLine("i is: " + i);
    i++;
}

//DO WHILE LOOP
int j = 0;
do
{
    Console.WriteLine("j is: " + j);
    j++;
} while (j < 5);

//FOR LOOP
for (int i = 0; i < length; i++)
{
    Console.WriteLine(i);
}

//NESTED LOOP
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.WriteLine($"i: {i}, j: {j}");
    }
}


