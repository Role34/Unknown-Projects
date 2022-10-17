using System;

class Math
{
    static void Main(string[] Args)
    {
        int x;

        for (x = 0; x <= 20; x++)
        {
            if (x == 0)
            {
                Console.WriteLine($"{x} is even");
            } else
            if (x % 2 == 0)
            {
                Console.WriteLine($"{x} is even");
            } else
            {
                Console.WriteLine($"{x} is odd");
            }
        }

        Console.WriteLine("Created by https://github.com/Role34");
    }
}
