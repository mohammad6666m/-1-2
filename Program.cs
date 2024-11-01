using System;

class Program
{
    static void Main()
    {
        int m = 40;
        int n = 20;

        Console.WriteLine($"adad aval bain {n} و {m}:");

        for (int i = n; i <= m; i++)
        {
            if (IsPrime(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false; // adad kamtar a 2 aval nis tan
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false; //akar bar i bakhbazier bashad adad aval nist
        }
        return true; // dar khai sorat aval and
    }
}




