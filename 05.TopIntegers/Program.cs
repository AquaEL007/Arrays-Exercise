﻿using System.Text;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isTop = true;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] <= numbers[j])
                    {
                        isTop = false;
                        break;
                    }
                }
                if (isTop)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }

        }
    }
}