using System;
namespace HW5_CH6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] WorkerKidsData = new int[18];
            for(int i = 0; i < 18; i++)
            {
                Console.WriteLine("How many kids does your {0} th worker have?",i+1);
                WorkerKidsData[i] = int.Parse(Console.ReadLine());
                if (WorkerKidsData[i] > 3)
                {
                    WorkerKidsData[i] = 1;
                }
                else
                {
                    WorkerKidsData[i] = 0;
                }
            }
            int sum = 0;
            for(int j = 0; j < 18; j++)
            {
                sum = sum + WorkerKidsData[j];
            }
            Console.WriteLine("number of qualified workers: {0}", sum);
            Console.WriteLine("money needed: {0}", sum * 300000);

        }
    }
}
