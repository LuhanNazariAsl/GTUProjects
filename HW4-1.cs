using System;

namespace HW4
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatMax = 0, floatMin = 20, floatSum = 0, floatTemp, floatDifference;
            for(int i = 1; i <= 15; i++)
            {
                Console.WriteLine("give me {0} score: ", i);
                floatTemp = float.Parse(Console.ReadLine());
                if (floatTemp > floatMax)
                {
                    floatMax = floatTemp;
                }
                if (floatTemp < floatMin)
                {
                    floatMin = floatTemp;
                }
                floatSum = floatSum + floatTemp;

            }
            Console.WriteLine("the lowest grade : {0}  , highest grade: {1}", floatMin, floatMax);
            floatDifference = floatMax - floatMin;
            Console.WriteLine("the sum of grade : {0}  , subtraction: {1}", floatSum, floatDifference);
            floatSum =(floatSum / 15);
            Console.WriteLine("the  average grade : {0}  ", floatSum);

        }
    }
}
