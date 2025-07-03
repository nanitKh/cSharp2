
using System;

namespace DATATYPES
{
    class Program
    {


        static void Main()
        {
            //Character
            char a = 'G';

            //INTEGER
            int i = 89;

            //SHORT
            short s = 56;

            // LONG
            long l = 4564;

            //UNSIGNED INTEGER
            uint ui = 95;

            //DOUBLE
            double d = 8.358674532;

            // FLOAT
            float f = 3.7330645f;

            // DECIMAL
            decimal dec = 389.5m;

            //BOOLEAN
            bool b = true;

            if (b == true)
                Console.WriteLine("Hi");
    

                Console.WriteLine("char: " + a);
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("Unsinged integer: " + ui);


        }
    }
}