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


    //hledání maxima, pozice maxim, minima, pozice minima
    int max = myRandomNumbers[0];
    int min = myRandomNumbers[0];
    int posMax = 0;
    int posMin = 0;

    for (int i = 1; i < myRandomNumbers.Length; i++)
    {
        if (myRandomNumbers[i] > max)
        {
            max = myRandomNumbers[i];
            posMax = i;
        }
        if (myRandomNumbers[i] < min)
        {
            min = myRandomNumbers[i];
            posMin = i;
        }
    }


    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine($"Maximum je {max} na pozici {posMax}");
    Console.WriteLine($"Minimum je {min} na pozici {posMin}");
    Console.WriteLine("================================================");
    Console.WriteLine();

    //vykreslování přesypacích hodin
    Console.Write("Vykreslování přesypacích hodin: ");
    if(max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine("================================================");
        Console.WriteLine();
        Console.WriteLine($"Přesýpací hodiny o velikosti {max}:");
        Console.WriteLine();

        //Tento cyklus se stará o to, aby se vykreslil správný počet řádkůs
        for (int i = 0; i < max; i++)
        {
            int spaces, stars;


            if (i < max / 2)
            {
                //horní polovina - počet mezer v i-tém řádku je i
                spaces = i;

                //horní polovina - s každým řádkem ubývá počet hvězdiček o 2
                stars = max - 2 * i;
            }
            else
            {
                //dolní polovina - počet mezer v i-tém řádku
                spaces = max - i - 1;
                if (max % 2 == 1)
                {
                    //pro liché max
                    stars = 2 * (i - max / 2) + 1;
                }
                else
                {
                    //pro sudé max
                    stars = 2 * (i - max / 2) + 2;
                }
            }
                for (int sp = 0; sp < spaces; sp++)
                {
                    Console.Write(" ");
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                //vykreslení správného počtu hvězdiček pro každý řádek
                // st = star (1 hvězdička)
                for (int st = 0; st < stars; st++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            
        }

        
    }













    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    again = Console.ReadLine();
}

