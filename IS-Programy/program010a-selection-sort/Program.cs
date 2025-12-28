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
            Console.WriteLine("PROGRAM 010a - SELECTION SORT");
            Console.WriteLine("======================================");

            int count;
            Console.Write("Zadej počet čísel: ");
            while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
            {
                Console.Write("Zadej kladné celé číslo: ");
            }

            int[] numbers = new int[count];
            Random rnd = new Random();

            Console.WriteLine("\nGenerovaná čísla:");
            for (int i = 0; i < count; i++)
            {
                numbers[i] = rnd.Next(1, 10);
                Console.Write(numbers[i] + " ");
            }

            // SELECTION SORT (vzestupně)
            for (int i = 0; i < count - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < count; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }

            Console.WriteLine("\n\nSeřazené pole:");
            for (int i = 0; i < count; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Největší číslo
            int max = numbers[count - 1];

            // Průměr hodnot
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }
            int average = sum / count;

            Console.WriteLine($"\n\nVýška obrazce: {max}");
            Console.WriteLine($"Šířka obrazce: {average}");
            Console.WriteLine();

            // OBDELNÍK
            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < average; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPro opakování stiskni 'a': ");
            again = Console.ReadLine();
        }
    }
}
