string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Vykreslení obdelníku *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Svoboda ******************");
    Console.WriteLine("************** 23.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("Zadejte šířku obdélníku (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte šířku obdélníku znovu: ");
    }
    Console.Write("Zadejte výšku obdélníku (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku obdélníku znovu: ");
    }

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
