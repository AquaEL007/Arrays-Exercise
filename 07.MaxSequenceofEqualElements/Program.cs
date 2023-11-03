namespace _07.MaxSequenceofEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int topCounter = 0;
            int мaxSequence = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                int counter = 1;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (numbers[i] == numbers[j])
                    {
                        counter++;
                        if (topCounter <= counter)
                        {
                            topCounter = counter;
                            мaxSequence = numbers[i];
                        }
                        
                    }
                    else
                    {
                        break;
                    }
                }

            }
            for (int i = 0; i < topCounter; i++)
            {
                Console.Write($"{мaxSequence} ");
            }
        }
    }
}