﻿namespace _01.Train
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] people = new int[n];

            for (int i = 0; i < people.Length; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }            
            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(people.Sum());
        }
    }
}