using System;

class Program
{
    static void Main()
    {
        string again = "a"; // proměnná pro opakování celé hry

        while (again == "a")
        {
            Console.Clear();

            int playerScore = 0;
            int computerScore = 0;
            int rounds;

            Random random = new Random();

            Console.WriteLine("=================================");
            Console.WriteLine("   KÁMEN – NŮŽKY – PAPÍR");
            Console.WriteLine("=================================");
            Console.WriteLine("Zadej jednu z možností:");
            Console.WriteLine("kámen | nůžky | papír");
            Console.WriteLine();

            // Bezpečné načtení počtu kol (TryParse)
            Console.Write("Zadej počet kol: ");
            while (!int.TryParse(Console.ReadLine(), out rounds) || rounds <= 0)
            {
                Console.WriteLine("Neplatný vstup. Zadej kladné celé číslo.");
                Console.Write("Zadej počet kol: ");
            }

            // Hlavní herní cyklus
            for (int round = 1; round <= rounds; round++)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine($"Kolo {round} z {rounds}");
                Console.WriteLine("---------------------------------");

                // Načtení textové volby hráče
                Console.Write("Tvoje volba: ");
                string playerInput = Console.ReadLine().ToLower();

                // Převod textu na číselnou volbu
                int playerChoice;
                if (playerInput == "kámen" || playerInput == "kamen") playerChoice = 1;
                else if (playerInput == "nůžky" || playerInput == "nuzky") playerChoice = 2;
                else if (playerInput == "papír" || playerInput == "papir") playerChoice = 3;
                else
                {
                    Console.WriteLine("Neplatná volba, kolo se opakuje.");
                    round--;
                    continue;
                }

                // Náhodná volba počítače
                int computerChoice = random.Next(1, 4);
                Console.WriteLine($"Počítač zvolil: {ChoiceToText(computerChoice)}");

                // Vyhodnocení kola
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("➡ Remíza");
                }
                else if (
                    (playerChoice == 1 && computerChoice == 2) ||
                    (playerChoice == 2 && computerChoice == 3) ||
                    (playerChoice == 3 && computerChoice == 1)
                )
                {
                    Console.WriteLine("✔ Vyhrál jsi kolo");
                    playerScore++;
                }
                else
                {
                    Console.WriteLine("✘ Počítač vyhrál kolo");
                    computerScore++;
                }

                // Výpis skóre
                Console.WriteLine($"Skóre momentálně je -> Hráč {playerScore} : {computerScore} Počítač");
            }

            // Vyhodnocení celé hry
            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("           KONEC HRY");
            Console.WriteLine("=================================");

            if (playerScore > computerScore)
                Console.WriteLine("🎉 Vyhrál jsi celou hru!");
            else if (computerScore > playerScore)
                Console.WriteLine("💻 Počítač vyhrál celou hru!");
            else
                Console.WriteLine("🤝 Celková remíza!");

            // Dotaz na opakování hry
            Console.WriteLine();
            Console.Write("Pro opakování hry stiskni 'a': ");
            again = Console.ReadLine().ToLower();
        }
    }

    // Pomocná metoda – převod čísla na text
    static string ChoiceToText(int choice)
    {
        if (choice == 1) return "Kámen";
        if (choice == 2) return "Nůžky";
        if (choice == 3) return "Papír";
        return "Neznámá volba";
    }
}
