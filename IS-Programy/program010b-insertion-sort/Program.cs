using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("PROGRAM 010b – INSERTION SORT");
            Console.WriteLine("======================================");

            int count;
            Console.Write("Zadej počet čísel: ");
            while (!int.TryParse(Console.ReadLine(), out count) || count < 2)
            {
                Console.Write("Zadej celé číslo větší než 1: ");
            }

            int[] numbers = new int[count];
            Random rnd = new Random();

            Console.WriteLine("\nGenerovaná čísla:");
            for (int i = 0; i < count; i++)
            {
                numbers[i] = rnd.Next(1, 15);
                Console.Write(numbers[i] + " ");
            }

            // INSERTION SORT (sestupně)
            for (int i = 1; i < count; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            Console.WriteLine("\n\nSeřazené pole:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Největší a druhé největší číslo (ošetření duplicit)
            int max = numbers[0];
            int secondMax = -1;

            for (int i = 1; i < count; i++)
            {
                if (numbers[i] < max)
                {
                    secondMax = numbers[i];
                    break;
                }
            }

            // Počet lichých čísel = maximální šířka obrazce
            int oddCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    oddCount++;
                }
            }

            if (secondMax == -1 || oddCount == 0)
            {
                Console.WriteLine("\nNelze vykreslit obrazec (nevhodné hodnoty).");
            }
            else
            {
                Console.WriteLine($"\nVýška obrazce: {secondMax}");
                Console.WriteLine($"Maximální šířka obrazce: {oddCount}");
                Console.WriteLine("\nObrazec – schody:\n");

                // SCHODOVITÝ OBRAZEC
                for (int i = 1; i <= secondMax; i++)
                {
                    int starsInRow = i;

                    if (starsInRow > oddCount)
                        starsInRow = oddCount;

                    for (int j = 0; j < starsInRow; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\nPro opakování stiskni 'a': ");
            again = Console.ReadLine();
        }
    }
}
