using System;

class Program
{
    static void Main()
    {
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        bool isFirstElement = true;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (!isFirstElement)
                {
                    Console.Write(" ");
                }
                
                Console.Write(array[i, j]);
                
                isFirstElement = false;
            }
        }

        Console.WriteLine();
    }
}
