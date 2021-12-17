using System;

namespace Assigment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the number : ");
            int input;
            while (!int.TryParse(Console.ReadLine(), out input));
            
            bool[] numbers = new bool[input + 1];
            
            for (int i = 2; i < input; i++)
            {
                if (!numbers[i])
                {
                    if (i != 2)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(i + " ");
                    for (int j = i + i; j < input; j += i)
                    {
                        numbers[j] = true;

                    }
                }
            }
        }
    }
}


