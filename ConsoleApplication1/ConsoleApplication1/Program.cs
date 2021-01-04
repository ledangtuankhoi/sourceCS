using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int multiply = 1;
            while (b > 0)
            {
                b--;
                multiply *= a;
            }
            Console.WriteLine(multiply);
            Console.ReadKey();
        }
    }
}