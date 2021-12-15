using System;

namespace HW5_CH6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] HistoryCheck = new int[12];
            string[] MonthsOfYear = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("let's check your history:");
            for(int i = 0; i < 12; i++)
            {
                Console.WriteLine("when did you pay your bill in {0} ?", MonthsOfYear[i]);
                HistoryCheck[i] = int.Parse(Console.ReadLine());
                if (HistoryCheck[i] < 20)
                {
                    HistoryCheck[i] = 1;
                }
                else
                {
                    HistoryCheck[i] = 0;
                }
                    
            }
            int sum = 0;
            for(int j = 0; j < 12; j++)
            {
                sum = sum + HistoryCheck[j];
            }
            if (sum >= 6)
                Console.WriteLine("You qualify for a free package");
            else
                Console.WriteLine("sorry, you don't qualify");

        }
    }
}