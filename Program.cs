using System;

namespace Perfect_Numbers
{
    public class Program
    {
        public static void Main()
        {
            int sum;
            Console.WriteLine("Enter Number 1");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            int Number2 = int.Parse(Console.ReadLine());
            for (int x = Number1; x <= Number2; x++)
            {
                sum = 0;
                for (int Number3 = 1; Number3 < x; Number3++)
                {
                    if (x % Number3 == 0)
                    {
                        sum += Number3;
                    }
                }
                if (sum == x)
                {
                    Console.WriteLine(x + "  is perefect");
                }
            }
        }
    }

}