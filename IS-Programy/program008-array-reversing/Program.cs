using System.Runtime.InteropServices;

string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************************");
    Console.WriteLine("********************* Reverze pole *********************");
    Console.WriteLine("********************************************************");
    Console.WriteLine("************** Matěj Svoboda ***************************");
    Console.WriteLine("*************** 27.11.2025 *****************************");
    Console.WriteLine("********************************************************");
    Console.WriteLine();

    int numbers = 0;
    Console.Write("Zadejte počet generovaných čísel: ");
    while (!int.TryParse(Console.ReadLine(), out numbers))
    {
        Console.Write("Zadejte celé číslo: ");
    }

    Console.Write("Zadejte dolní mez (menší než horní mez): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Zadejte celé číslo:");
    }

    Console.Write("Zadejte horní mez (větší než 0): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Zadejte celé číslo: ");
    }

    Console.WriteLine();
    Console.WriteLine("================= Generovaná čísla ================");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", numbers, lowerBound, upperBound);
    Console.WriteLine("===================================================");
    Console.WriteLine();


    //deklarace pole (array)
    int[] myRandomNumbers = new int[numbers];


    //příprava pro využití třídy Random
    Random myRandomNumber = new Random(50); //50 = seed

    //generování čísel a jejich uložení do pole
    Console.WriteLine("Generovaná čísla:");
    for (int i = 0; i < numbers; i++)
    {
        myRandomNumbers[i] = myRandomNumber.Next(lowerBound, upperBound + 1);
        Console.Write("{0}; ", myRandomNumbers[i]);
    }

    

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine();
}