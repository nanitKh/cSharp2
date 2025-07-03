

using System;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}


/*
int[] scores = [97, 92, 81, 60];

IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}
 */