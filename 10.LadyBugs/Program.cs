﻿using System.Diagnostics.SymbolStore;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldLength = int.Parse(Console.ReadLine());

            int[] bugPlaces = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int[] field = new int[fieldLength];
            
            for (int i = 0; i < bugPlaces.Length; i++)
            {
                int bugIndex = bugPlaces[i];
                if (bugIndex >= 0 && bugIndex < field.Length)
                {
                    field[bugIndex] = 1; //ima kalinka
                }
            }

            string command = "";
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();
                // ["0", "right", "1"] poslednoto e skoka / vsichki sa stringove

                int bugIndex = int.Parse(arguments[0]);
                string direction = arguments[1];
                int flyLength = int.Parse(arguments[2]);

                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
                {
                    continue;
                }

                field[bugIndex] = 0;
                int landIndex;

                switch (direction)
                {
                    case "right":
                        landIndex = bugIndex + flyLength; // 0 + 1 = 1
                        if (landIndex > field.Length - 1)
                        {
                            continue;
                        }

                        if (field[landIndex] == 1)   // logikata da proverim, ako skacha varhu kalinki
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex += flyLength;
                                if (landIndex > field.Length - 1)
                                {
                                    break;
                                }
                            }
                        }

                        if (landIndex <= field.Length - 1)
                        {
                            field[landIndex] = 1;
                        }

                        break;
                    case "left":
                        landIndex = bugIndex - flyLength;

                        if (landIndex < 0)
                        {
                            continue; 
                        }

                        if (field[landIndex ] == 1)
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex -= flyLength;

                                if (landIndex < 0)
                                {
                                    break;
                                }
                            }
                        }

                        if (landIndex >= 0)
                        {
                            field[landIndex] = 1;
                        }

                        break;                    
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}