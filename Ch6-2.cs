using System;

namespace HW5_CH6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many students in your class?");
            int num,maxindex=0,minindex=0;
            float min = 20, max = 0;
            num = int.Parse(Console.ReadLine());
            float[] scores = new float[num];
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("givd me the [{0}] th score: ", (i + 1));
                scores[i] = float.Parse(Console.ReadLine());
                if (scores[i]>= max)
                {
                    max = scores[i];
                    maxindex = i;
                }
                if (scores[i] <= min)
                {
                    min = scores[i];
                    minindex = i;
                }
            }
            Console.WriteLine("max: {0}, max rank: {1}", max, maxindex+1);
            Console.WriteLine("min: {0}, min rank: {1}", min, minindex+1);
        }
    }
}
