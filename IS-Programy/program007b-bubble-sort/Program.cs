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

    

    for(int i=0; i < numbers - 1; i++)
    {
        
        //tento cyklus musí zajistit porovnávání dvou sousedních hodnot
        // musí dále zajistit, aby se zmenšoval počet porovnávaných hodnot 
        for(int j = 0; j < numbers - 1 - i; j++)
        {
            if (myRandomNumbers[j] < myRandomNumbers[j + 1])
            {
                //prohodit hodnoty na pozicích j a j+1
                int temp = myRandomNumbers[j + 1];
                myRandomNumbers[j + 1] = myRandomNumbers[j];
                myRandomNumbers[j] = temp;
                
            }
        }
    }

    Console.WriteLine();
    
    // určení druhého největšího čísla v poli
    int biggestNumber = myRandomNumbers[0];
    int secondBiggestNumber = lowerBound; // nastavíme na nejmenší možnou hodnotu

for (int i = 1; i < numbers; i++)
{
    if (myRandomNumbers[i] > biggestNumber)
    {
        secondBiggestNumber = biggestNumber;
        biggestNumber = myRandomNumbers[i];
    }
    else if (myRandomNumbers[i] > secondBiggestNumber && myRandomNumbers[i] != biggestNumber)
    {
        secondBiggestNumber = myRandomNumbers[i];
    }
}

// vykreslení obrazce s výškou secondBiggestNumber a šířkou secondBiggestNumber a kde mezi prvními dvěma a posledními dvěma řádky jsou jen krajní hvězdičky
Console.WriteLine("Druhé největší číslo je: {0}", secondBiggestNumber);
Console.WriteLine("Obrazec s výškou a šířkou {0}:", secondBiggestNumber);
for (int i = 0; i < secondBiggestNumber; i++)
{
    for (int j = 0; j < secondBiggestNumber; j++)
    {
        if (i < 2 || i >= secondBiggestNumber - 2 || j == 0 || j == secondBiggestNumber - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("===================================================");
    Console.WriteLine();
    Console.WriteLine("Seřazená čísla:");
    for (int i = 0; i < numbers; i++)
    {
        Console.Write("{0}; ", myRandomNumbers[i]);
    }

    

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine();
}