/*

Hey hello 2 4
10 hey 4 hello

*/
internal class Program
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split();
        string[] secondArray = Console.ReadLine().Split();

        for (int i = 0; i < secondArray.Length; i++)
        {
            for (int j = 0; j < firstArray.Length; j++)
            {
                if (firstArray[j] == secondArray[i])
                {
                    Console.Write($"{secondArray[i]} ");
                }

            }
        }

        //Console.WriteLine(string.Join(" ", firstArray));
        //Console.WriteLine(string.Join(" ", firstArray));
    }
}
