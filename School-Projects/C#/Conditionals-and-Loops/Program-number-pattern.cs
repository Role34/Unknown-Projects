using System;

class Program
{
    static void Main() {
        
        for(var x = 1; x <= 5; x++)
        {
            for(var y = 1; y <= x; y++)
            Console.Write(y.ToString());
            Console.WriteLine();
        }
    }
}
