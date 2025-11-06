using System.Runtime.InteropServices;

string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************************");
    Console.WriteLine("************ Genetáror pseudonáhodných čísel ************");
    Console.WriteLine("********************************************************");
    Console.WriteLine("************** Matěj Svoboda ***************************");
    Console.WriteLine("*************** 6.11.2025 *****************************");
    Console.WriteLine("********************************************************");
    Console.WriteLine();

    int numbers = 0;
    Console.Write("Zadejte počet generovaných čísel: ");
    while (!int.TryParse(Console.ReadLine(), out numbers))
    {
        Console.Write("Zadejte celé číslo: ");
    }

    Console.Write("Zadejte horní mez (větší než 0): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Zadejte celé číslo: ");
    }

    Console.Write("Zadejte dolní mez (menší než horní mez): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Zadejte celé číslo:");
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

    //počet kladných, záporných a nulových čísel
    int kladna = 0;
    int zaporny = 0;
    int nula = 0;
    for (int i = 0; i < numbers; i++)
    {
        if (myRandomNumbers[i] > 0)
        {kladna++;}
        else if (myRandomNumbers[i] < 0)
        {zaporny++;}
        else
        {nula++;}
    }

    int suda = 0;
    int licha = 0;
    for (int i = 0; i < numbers; i++)
    {
        if (myRandomNumbers[i] % 2 == 0)
        { suda++; }
        else
        { licha++; }
    }

    Console.WriteLine();
    Console.WriteLine("================= Statistiky ================");
    Console.WriteLine("Počet kladných čísel: {0}", kladna);
    Console.WriteLine("Počet záporných čísel: {0}", zaporny);
    Console.WriteLine("Počet nulových čísel: {0}", nula);
    Console.WriteLine("Počet sudých čísel: {0}", suda);
    Console.WriteLine("Počet lichých čísel: {0}", licha);
    Console.WriteLine("============================================");

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine();
}