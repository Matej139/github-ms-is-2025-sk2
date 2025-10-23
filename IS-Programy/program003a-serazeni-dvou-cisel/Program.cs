string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************Seřazení dvou čísel***********");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("***************Matěj Svoboda**************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");

    //Vstup řešený lépe
    Console.Write("Zadejte celé číslo A: ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu číslo A");
    }

    Console.Write("Zadejte celé číslo B: ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu číslo B");
    }
    Console.WriteLine();

    int pomocna;
    if (a > b)
    {
        pomocna = a;
        a = b;
        b = pomocna;
    }

    Console.WriteLine("================================");
    Console.WriteLine($"Seřazená čísla jsou: {a}, {b}");
    Console.WriteLine("================================");
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();


}