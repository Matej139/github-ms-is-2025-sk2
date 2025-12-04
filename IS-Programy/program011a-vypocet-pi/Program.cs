string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Výpočet PI  ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Matěj Svoboda*****************");
    Console.WriteLine("************** 4.12.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte přesnost výpočtu: ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {
        Console.Write("Nezadali jste platné číslo přesnosti. Zadejte ho znovu: ");
    }

    int i = 1;
    double piCtvrt = 1.0;
    int znamenko = 1;


    Console.WriteLine();

    while ((1.0/i)>=presnost)
    {
        i+=2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * (1.0/i);
    }

    double pi = 4 * piCtvrt;

    Console.WriteLine();
    Console.WriteLine("Vaše PI dané s přesností je: {0}", pi);



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
