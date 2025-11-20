using System.Runtime.InteropServices;

string again = "a";

while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************************");
    Console.WriteLine("************ Generátor pseudonáhodných čísel ************");
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

    int compare = 0;    // počet porovnávání
    int change = 0;   // počet výměň


    for(int i=0; i < numbers - 1; i++)
    {
        //tento cyklus musí zajistit porovnávání dvou sousedních hodnot
        // musí dále zajistit, aby se zmenšoval počet porovnávaných hodnot 
        for(int j = 0; j < numbers - 1 - i; j++)
        {
            compare++;
            if (myRandomNumbers[j] > myRandomNumbers[j + 1])
            {
                //prohodit hodnoty na pozicích j a j+1
                int temp = myRandomNumbers[j + 1];
                myRandomNumbers[j + 1] = myRandomNumbers[j];
                myRandomNumbers[j] = temp;
                change++;
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("=================== Seřazená čísla ================");
    for (int i = 0; i < numbers; i++)
    {
        Console.Write("{0}; ", myRandomNumbers[i]);
    }


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine();
}