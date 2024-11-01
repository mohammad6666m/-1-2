using System;

class Program
{
    static void Main()
    {
        int m = 10;
        int n = 100;

        Console.WriteLine("{0} adad ayanai bain n , m {1}:", m, n);

        for (int i = m; i < n; i++)
        {
            if (IsPalindromic(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPalindromic(int number)
    {
        string str = number.ToString();
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        string reversedStr = new string(arr);
        return str == reversedStr;
    }
}
