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

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup řešený lépe
    Console.Write("Zadejte první číslo řady: ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte první číslo řady znovu");
    }
    
    Console.Write("Zadejte poslední číslo řady: ");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte poslední číslo řady znovu");
    }

    Console.Write("Zadejte krok řady: ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte krok řady znovu");
    }

    //Výstup zadaných hodnot
    Console.WriteLine("==========================================");
    Console.WriteLine("Zadali jste tyto hodnoty: ");
    Console.WriteLine($"První číslo řady: {first}");
    Console.WriteLine($"Poslední číslo řady: {last}");
    Console.WriteLine($"Krok řady: {step}");
    Console.WriteLine("==========================================");

    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}