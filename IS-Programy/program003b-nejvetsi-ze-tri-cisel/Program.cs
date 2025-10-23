string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("************Nejvetsi ze tri cisel***********");
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

    Console.Write("Zadejte celé číslo C: ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte znovu číslo C");
    }
    Console.WriteLine();

    //Zpracování
    int nejvetsi = a;
    if (b > nejvetsi)
    {
        nejvetsi = b;
    }
    if (c > nejvetsi)
    {
        nejvetsi = c;
    }
    //Výstup
    Console.WriteLine("Největší číslo zadané je: " + nejvetsi);
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte 'a', pro ukončení programu stiskněte libovolnou jinou klávesu.");
    again = Console.ReadLine();


}