using System;

namespace HW4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intBank = 7, intPlayer1, intPlayer2;
            while (intBank != 0)
            {
                Console.WriteLine("how many do you want? remaining in the bank: {0}", intBank);
                Console.Write("player one's choice?");
                intPlayer1 = int.Parse(Console.ReadLine());
                if(intPlayer1==1 || intPlayer1==2 || intPlayer1 == 3)
                {
                    intBank = intBank - intPlayer1;
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                    break;
                }
                
                if (intBank == 0)
                {
                    Console.WriteLine("player 1 lost!");
                    break;

                }
                Console.WriteLine("how many do you want? remaining in the bank: {0}", intBank);
                Console.Write("player two's choice?");
                intPlayer2 = int.Parse(Console.ReadLine());
                if (intPlayer2 == 1 || intPlayer2 == 2 || intPlayer2 == 3)
                {
                    intBank = intBank - intPlayer2;
                }
                else
                {

                    Console.WriteLine("Invalid choice!");
                    break;
                }
                if (intBank == 0)
                {
                    Console.WriteLine("player 2 lost!");
                    break;

                }
            }
        }
    }
}
