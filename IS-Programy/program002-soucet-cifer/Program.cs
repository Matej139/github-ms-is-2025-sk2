string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************Výpis číselné řady************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("***************Matěj Svoboda**************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    //Vstup řešený lépe
    Console.Write("Zadejte celé číslo: ");
    int number;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte ho znovu");
    }

    int suma = 0;

    int numberBackup = number; // záloha původního čísla
    int digit; // proměnná pro jednotlivé cifry čísla

    if (number < 0)
    {
        number = -number; // pokud je číslo záporné, převedeme ho na kladné
    }

    while (number > 0)
    {
        digit = number % 10; // získání poslední cifry čísla
        number = (number - digit) / 10; // odstranění poslední cifry čísla
        Console.WriteLine("Hodnota zbytku: {0}", digit);
        suma += digit; // přičtení cifry k součtu
    }

    //musíme poslední cifru vypsat
    Console.WriteLine("Hodnota zbytku: {0}", number);

    //musíme poslední cifru přičíst k součtu
    suma += number; // přičtení cifry k součtu

    Console.WriteLine();
    Console.WriteLine("Součet cifer čísla {0} je {1}", numberBackup, suma);
    Console.WriteLine();


    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}