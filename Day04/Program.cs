using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hello World");

            int a = 0;
            int b = 0;

            string input = Console.ReadLine();
            a = int.Parse(input);

            string input2 = Console.ReadLine();
            b = int.Parse(input2);

            Console.WriteLine(Add(a, b));

        }

        static int Add(int a, int b)
        {
            int c = 0;

            c = a + b;

            return c;
        }
    }
}
