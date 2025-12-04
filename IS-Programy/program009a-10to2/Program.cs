string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("***** Převod z desítkové do dvojkové ********");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Svoboda ******************");
    Console.WriteLine("************** 27.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte první číslo řady (celé číslo): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte přirozené (desítkové) číslo: ");
    }

    Console.WriteLine();
    Console.WriteLine("Vypsání jednobajtového čísla: ");

    string vypis = "";

    //převod jednobajtového čísla
    for (int i = 0; number10 > 0; i++)
    {
        if ((number10 % 2) == 1)
        {
            vypis = "1" + vypis;
        }
        else
        {
            vypis = "0" + vypis;
        }
        number10 = number10 / 2;
    }

    //pomalejší cesta
    /*
    
    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;
    uint zbytek;

    uint i;
    for(i = 0; number10 > 0; i++)
    {
      zbytek = number10 % 2;
      number10 = (number10 - zbytek) / 2;
      myArray[i] = zbytek;

      Console.WriteLine("Celá část: {0}; Zbytek: {1}", number10, zbytek);
    }
    
    Console.WriteLine("Desítkové číslo: {0}", backupNumber10);

    

    */

    Console.WriteLine(vypis);








    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
