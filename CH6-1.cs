using System;

namespace HW5_CH6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] DaysOfTheWeek = new string[] { "saturday", "sunday", "monday", "tuesday", "wednesday", "thursday", "friday" };
            foreach(string i in DaysOfTheWeek)
            {
                Console.WriteLine(i);
            }
        }
    }
}
