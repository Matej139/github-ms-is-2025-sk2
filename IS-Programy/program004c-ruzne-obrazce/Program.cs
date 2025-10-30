using System;

class Program
{
    static void Main()
    {
        string again = "a";

        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("********************************************");
            Console.WriteLine("************ Vykreslení obrazců ************");
            Console.WriteLine("********************************************");
            Console.WriteLine("************** Matěj Svoboda ***************");
            Console.WriteLine("*************** 30.10.2025 *****************");
            Console.WriteLine("********************************************");
            Console.WriteLine();
            Console.WriteLine("Vyberte obrazec:");
            Console.WriteLine("1 - Písmeno Z");
            Console.WriteLine("2 - Kosočtverec");
            Console.WriteLine("3 - Přesýpací hodiny");
            Console.Write("\nVaše volba: ");

            int volba;
            while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 3)
            {
                Console.Write("Zadejte číslo 1 až 3: ");
            }

            Console.Write("\nZadejte výšku (doporučeno 8): ");
            int vyska;
            while (!int.TryParse(Console.ReadLine(), out vyska) || vyska < 2)
            {
                Console.Write("Zadejte celé číslo větší než 1: ");
            }

            Console.Write("\nZadejte šířku (doporučeno 8): ");
            int sirka;
            while (!int.TryParse(Console.ReadLine(), out sirka) || sirka < 2)
            {
                Console.Write("Zadejte celé číslo větší než 1: ");
            }

            Console.WriteLine("\n");

            switch (volba)
            {
                case 1:
                    VykresliZ(vyska, sirka);
                    break;
                case 2:
                    VykresliKosoctverec(vyska, sirka);
                    break;
                case 3:
                    VykresliHodiny(vyska, sirka);
                    break;
            }

            Console.WriteLine("\nPro opakování programu stiskněte klávesu 'a'.");
            again = Console.ReadLine();
        }
    }

    // (4) Písmeno Z
    static void VykresliZ(int vyska, int sirka)
    {
        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < sirka; j++)
            {
                if (i == 0 || i == vyska - 1 || j == sirka - 1 - i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }


    // (16) Kosočtverec
    static void VykresliKosoctverec(int vyska, int sirka)
    {
        int stred = vyska / 2; // střed kosočtverce

        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < sirka; j++)
            {
                // horní polovina
                if (i < stred)
                {
                    if (j >= stred - i - 1 && j <= stred + i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                // dolní polovina
                else
                {
                    int k = vyska - i - 1;
                    if (j >= stred - k - 1 && j <= stred + k)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }




    // (19) Přesýpací hodiny
    static void VykresliHodiny(int vyska, int sirka)
    {
        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < sirka; j++)
            {
                if (i <= vyska / 2 - 1)
                {
                    if (j >= i && j < sirka - i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                else
                {
                    if (j >= vyska - i - 1 && j < sirka - (vyska - i - 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
