using System;
using System.Text;

class Program
{
    const int MAXN = 100;

    static void Main(string[] args)
    {
        int n, dm, hm;
        int[] a = new int[MAXN];

        Console.Write("Zadej n, dolni a horni mez: ");
        string? line = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line))
        {
            Console.WriteLine("Spatny vstup.");
            return;
        }

        string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length < 3)
        {
            Console.WriteLine("Musis zadat tri cisla.");
            return;
        }

        n = int.Parse(parts[0]);
        dm = int.Parse(parts[1]);
        hm = int.Parse(parts[2]);

        if (n <= 0 || n > MAXN)
        {
            Console.WriteLine("n mimo rozsah 1..{0}", MAXN);
            return;
        }

        Random rnd = new Random();

        FillRandom(a, n, dm, hm, rnd);

        Console.Write("Nahodne vygenerovana cisla jsou: ");
        PrintArray(a, n);
        Console.WriteLine("-----");

        int min, max;
        FindMinMax(a, n, out min, out max);

        Console.Write("Maximum: {0}, vsechny pozice maxima: ", max);
        PrintPositions(a, n, max);
        Console.WriteLine();

        Console.Write("Minimum: {0}, vsechny pozice minima: ", min);
        PrintPositions(a, n, min);
        Console.WriteLine();
        Console.WriteLine("-----");

        ShakerSortDesc(a, n);

        Console.WriteLine("Pole po serazeni algoritmem Shaker sort:");
        PrintArray(a, n);
        Console.WriteLine("-----");

        int second = KthLargestDistinct(a, n, 2);
        int third = KthLargestDistinct(a, n, 3);
        int fourth = KthLargestDistinct(a, n, 4);

        Console.WriteLine("Druhe nejvetsi cislo: {0}", second);
        Console.WriteLine("Treti nejvetsi cislo: {0}", third);
        Console.WriteLine("Ctvrte nejvetsi cislo: {0}", fourth);
        Console.WriteLine("-----");

        int med = Median(a, n);
        Console.WriteLine("Median generovanych cisel = {0}", med);
        Console.WriteLine("-----");

        Console.Write("Ctvrte nejvetsi cislo prevedene do binarni soustavy: {0}(2) = ", fourth);
        PrintBinary(fourth);
        Console.WriteLine();
        Console.WriteLine("-----");

        Console.WriteLine("Obrazec – vyska = median ({0}); sirka = treti nejvetsi ({1})", med, third);
        DrawPattern(med, third);
    }

    static void FillRandom(int[] a, int n, int dm, int hm, Random rnd)
    {
        for (int i = 0; i < n; i++)
        {
            a[i] = dm + rnd.Next(hm - dm + 1);
        }
    }

    static void PrintArray(int[] a, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i]);
            if (i < n - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    static void FindMinMax(int[] a, int n, out int min, out int max)
    {
        min = a[0];
        max = a[0];
        for (int i = 1; i < n; i++)
        {
            if (a[i] < min) min = a[i];
            if (a[i] > max) max = a[i];
        }
    }

    static void PrintPositions(int[] a, int n, int value)
    {
        bool first = true;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == value)
            {
                if (!first)
                    Console.Write(", ");
                Console.Write(i + 1); // 1-based index
                first = false;
            }
        }
    }

    static void ShakerSortDesc(int[] a, int n)
    {
        bool swapped = true;
        int start = 0;
        int end = n - 1;

        while (swapped)
        {
            swapped = false;

            for (int i = start; i < end; i++)
            {
                if (a[i] < a[i + 1])
                {
                    int tmp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tmp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;

            swapped = false;
            end--;

            for (int i = end - 1; i >= start; i--)
            {
                if (a[i] < a[i + 1])
                {
                    int tmp = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tmp;
                    swapped = true;
                }
            }
            start++;
        }
    }

    static int KthLargestDistinct(int[] a, int n, int k)
    {
        int distinctCount = 0;
        int lastValue = int.MinValue;
        bool first = true;

        for (int i = 0; i < n; i++)
        {
            if (first || a[i] != lastValue)
            {
                distinctCount++;
                lastValue = a[i];
                first = false;

                if (distinctCount == k)
                    return lastValue;
            }
        }

        // Kdyby nahodou nebylo dost odlisnych hodnot:
        return lastValue;
    }

    static int Median(int[] a, int n)
    {
        if (n % 2 == 1)
        {
            return a[n / 2];
        }
        else
        {
            // prumer dvou prostrednich
            return (a[n / 2 - 1] + a[n / 2]) / 2;
        }
    }

    static void PrintBinary(int x)
    {
        if (x == 0)
        {
            Console.Write("0");
            return;
        }

        bool negative = x < 0;
        if (negative) x = -x;

        StringBuilder sb = new StringBuilder();

        while (x > 0)
        {
            int bit = x % 2;
            sb.Insert(0, bit);
            x /= 2;
        }

        if (negative)
            sb.Insert(0, "-");

        Console.Write(sb.ToString());
    }

    static void DrawPattern(int height, int width)
    {
        if (height <= 0 || width <= 0)
        {
            Console.WriteLine("Nelze vykreslit obrazec (neplatne rozmery).");
            return;
        }

        for (int i = 0; i < height; i++)
        {
            PrintStarsLine(width);
        }
    }

    static void PrintStarsLine(int count)
    {
        Console.WriteLine(new string('*', count));
    }
}
