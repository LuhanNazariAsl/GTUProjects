///<summary>This method is designed to solve  limited examples of a puzzle  game known as "soda sort"
///<example> the first required example is:
///- using empty stack?
///no
///-how many colors in first stack?
///2
///-how many colors in second stack?
///2
///-how many colors in third stack?
///2
///-first color first stack?
///R
///-second color first stack?
///G
///-first color second stack?
///B
///-second color second stack?
///R
///-first color third stack?
///G
///-second color third stack?
///B
///sorts and gives the output : RR, BB, GG
///</example>
///<example> the second required example is:
///- using empty stack?
///yes
///-how many colors in first stack?
///3
///-how many colors in second stack?
///3
///-how many colors in third stack?
///3
///-first color first stack?
///R
///-second color first stack?
///R
///-third color first stack?
///G
///-first color second stack?
///B
///-second color second stack?
///R
///-third color second stack?
///B
///-first color third stack?
///B
///-second color third stack?
///G
///-third color third stack?
///G
///sorts and gives the output : RRR,  empty stack,  BBB, GGG
///</example>
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Soda_Sort
{
    class Program
    {
        static int PopPush(int i, int j)
        {

            return 0;
        }
        static void Main(string[] args)
        {

            int i, numOfColor1, numOfColor2, numOfColor3;
            Stack<char> Stack1 = new Stack<char>();
            Stack<char> Stack2 = new Stack<char>();
            Stack<char> Stack3 = new Stack<char>();

            // welcome page
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("▌                      ▐");
            Console.WriteLine("▌ WELCOME TO SODA SORT ▐");
            Console.WriteLine("▌                      ▐");
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.ResetColor();
            Console.Write("[Press any key to continue]");
            Console.ReadKey();
            Console.Clear();


            Console.Write("Are we allowed to use empty stack? ");
            string answer = Console.ReadLine();
            Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=");

            // In case we were allowed to use empty stack
            if (answer == "y" || answer == "yes" || answer == "Y")
            {               // second example

                Console.Write("How many colors are there in 1st stack? ");
                numOfColor1 = int.Parse(Console.ReadLine());
                Console.Write("How many colors are there in 2nd stack? ");
                numOfColor2 = int.Parse(Console.ReadLine());
                Console.Write("How many colors are there in 3rd stack? ");
                numOfColor3 = int.Parse(Console.ReadLine());
                Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=");


                for (i = 1; i <= numOfColor1; i++)
                {
                    Console.Write("Color {0} of stack 1:", i);
                    Stack1.Push(char.Parse(Console.ReadLine()));
                }
                Console.WriteLine("\n===================");
                for (i = 1; i <= numOfColor2; i++)
                {
                    Console.Write("Color {0} of stack 2:", i);
                    Stack2.Push(char.Parse(Console.ReadLine()));
                }
                Console.WriteLine("===================");
                for (i = 1; i <= numOfColor3; i++)
                {
                    Console.Write("Color {0} of stack 3:", i);
                    Stack3.Push(char.Parse(Console.ReadLine()));
                }
                Console.WriteLine("===================");
                //Console.Clear();



                Stack<char> Stack4 = new Stack<char>();
                Stack4.Push('a');
                Stack4.Pop();

                if (Stack1.Peek() == Stack2.Peek())
                {
                    Stack4.Push(Stack1.Pop());
                    Stack4.Push(Stack2.Pop());
                }
                else if (Stack1.Peek() == Stack3.Peek())
                {
                    Stack4.Push(Stack1.Pop());
                    Stack4.Push(Stack3.Pop());
                }
                else if (Stack2.Peek() == Stack3.Peek())
                {
                    Stack4.Push(Stack2.Pop());
                    Stack4.Push(Stack3.Pop());
                }
                else
                    Stack4.Push(Stack1.Pop());

                while (Stack4.Peek() == Stack1.Peek() || Stack4.Peek() == Stack2.Peek() || Stack4.Peek() == Stack3.Peek())
                {
                    if (Stack4.Peek() == Stack1.Peek())
                        Stack4.Push(Stack1.Pop());
                    else if (Stack4.Peek() == Stack2.Peek())
                        Stack4.Push(Stack2.Pop());
                    else if (Stack4.Peek() == Stack3.Peek())
                        Stack4.Push(Stack3.Pop());
                }


                while (Stack1.Peek() == Stack2.Peek() || Stack1.Peek() == Stack3.Peek() || Stack2.Peek() == Stack3.Peek())
                {
                    if (Stack1.Peek() == Stack2.Peek())
                    {
                        while (Stack1.Peek() == Stack2.Peek())
                            Stack1.Push(Stack2.Pop());
                    }
                    else if (Stack1.Peek() == Stack3.Peek())
                    {
                        while (Stack1.Peek() == Stack3.Peek())
                            Stack1.Push(Stack3.Pop());
                    }
                    else if (Stack3.Peek() == Stack2.Peek())
                    {
                        while (Stack3.Peek() == Stack2.Peek())
                        {
                            Stack3.Push(Stack2.Pop());
                            if (Stack2.Count() == 0)
                                Stack2.Push(' ');
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                Console.WriteLine("▌                      ▐");
                Console.WriteLine("▌   PUZZLE IS SOLVED   ▐");
                Console.WriteLine("▌                      ▐");
                Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                Console.ResetColor();

                Console.Write("Stack 1: ");
                foreach (var item in Stack1)
                    Console.Write(item + " ");
                Console.WriteLine(" ");
                Console.Write("Stack 2: ");
                foreach (var item in Stack2)
                    Console.Write(item + " ");
                Console.WriteLine(" ");
                Console.Write("Stack 3: ");
                foreach (var item in Stack3)
                    Console.Write(item + " ");
                Console.WriteLine(" ");
                Console.Write("Stack 4: ");
                foreach (var item in Stack4)
                    Console.Write(item + " ");

            }


            // We are not allowed to use empty stack
            else
            {
                // first example
                Console.Write("How many colors are there in 1st stack? ");
                numOfColor1 = int.Parse(Console.ReadLine());
                Console.Write("How many colors are there in 2nd stack? ");
                numOfColor2 = int.Parse(Console.ReadLine());
                Console.Write("How many colors are there in 3rd stack? ");
                numOfColor3 = int.Parse(Console.ReadLine());
                Console.WriteLine("+=+=+=+=+=+=+=+=+=+=+=");

                for (i = 1; i <= numOfColor1; i++)
                {
                    Console.Write("Color {0} of stack 1:", i);
                    Stack1.Push(char.Parse(Console.ReadLine()));
                }
                Console.WriteLine("\n===================");
                for (i = 1; i <= numOfColor2; i++)
                {
                    Console.Write("Color {0} of stack 2:", i);
                    Stack2.Push(char.Parse(Console.ReadLine()));
                }
                Console.WriteLine("===================");
                for (i = 1; i <= numOfColor3; i++)
                {
                    Console.Write("Color {0} of stack 3:", i);
                    Stack3.Push(char.Parse(Console.ReadLine()));
                }
                Console.WriteLine("===================");

                Stack2.Push(Stack1.Pop());
                if (Stack1.Peek() != Stack2.Peek() && Stack1.Peek() != Stack3.Peek() && Stack3.Peek() != Stack2.Peek())
                    Stack3.Push(Stack2.Pop());
                if (Stack1.Peek() == Stack2.Peek())
                {
                    Stack1.Push(Stack2.Pop());
                    Stack1.Push(Stack3.Pop());
                    Stack2.Push(Stack3.Pop());
                }
                else if (Stack1.Peek() == Stack3.Peek())
                {
                    Stack1.Push(Stack3.Pop());
                    Stack1.Push(Stack3.Pop());
                    Stack2.Push(Stack3.Pop());
                }
                else if (Stack2.Peek() == Stack3.Peek()) //
                {
                    Stack3.Push(Stack2.Pop()); //
                    Stack1.Push(Stack3.Pop());
                    Stack1.Push(Stack3.Pop());
                    Stack2.Push(Stack3.Pop());
                    Stack2.Push(Stack3.Pop());
                    Stack3.Push(Stack1.Pop());
                    Stack3.Push(Stack1.Pop());
                    Stack1.Push(Stack2.Pop());
                }

                if (Stack1.Peek() == Stack2.Peek())
                    Stack2.Push(Stack1.Pop());
                else if (Stack1.Peek() == Stack3.Peek())
                    Stack3.Push(Stack1.Pop());
                if (Stack1.Peek() != Stack2.Peek() && Stack1.Peek() != Stack3.Peek() && Stack3.Peek() != Stack2.Peek())
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
                    Console.WriteLine("▌                      ▐");
                    Console.WriteLine("▌   PUZZLE IS SOLVED   ▐");
                    Console.WriteLine("▌                      ▐");
                    Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                    Console.ResetColor();

                    Console.Write("Stack 1: ");
                    foreach (var item in Stack1)
                        Console.Write(item + " ");
                    Console.WriteLine(" ");
                    Console.Write("Stack 2: ");
                    foreach (var item in Stack2)
                        Console.Write(item + " ");
                    Console.WriteLine(" ");
                    Console.Write("Stack 3: ");
                    foreach (var item in Stack3)
                        Console.Write(item + " ");
                    Console.WriteLine(" ");
                }

            }

            Console.ReadKey();

        }
    }
}
