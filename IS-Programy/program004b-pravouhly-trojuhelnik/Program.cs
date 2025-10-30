//Vykresleni pravoúhlého trojúhelníku hvězdičkami podle zadané výšky.
string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Vykreslení pravoúhlého **********");
    Console.WriteLine("*************** trojúhelníku ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Svoboda ******************");
    Console.WriteLine("************** 30.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("Zadejte výšku trojúhelníku (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte výšku trojúhelníku znovu: ");
    }
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}