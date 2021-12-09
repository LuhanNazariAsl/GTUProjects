using System;

namespace HW4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int intIndex;
            Console.WriteLine("gimme the index? ");
            intIndex = int.Parse(Console.ReadLine());
            int intSum = 0;
            if (intIndex <= 0)
                goto termination;
            Console.WriteLine("1 = 1");

            for (int i = 2; i <= intIndex; i++)
            {
                intSum = 0;
                for (int j = 1; j <= i; j++)
                {
                    intSum = intSum + j;
                    if (j != i)
                    {
                        Console.Write("{0} + ", j);
                    }else if (i == j)
                    {
                        Console.Write("{0} = {1}", j,intSum);
                    }
                    
                }
                Console.WriteLine();
            }
            termination: Console.ReadKey();
        }
    }
}
