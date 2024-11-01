using System;

class Program
{
    static void Main()
    {
        int number; // متغیر برای ذخیره عدد ورودی

        while (true) // حلقه بی‌نهایت
        {
            Console.Write("لطفا عدد 1 را وارد کنید: ");
            string input = Console.ReadLine(); // دریافت ورودی از کاربر

            // بررسی اینکه آیا ورودی عدد صحیح و برابر با 1 است
            if (int.TryParse(input, out number) && number == 1)
            {
                // اگر ورودی برابر با 1 بود، از حلقه خارج می‌شویم
                break;
            }
            else
            {
                // اگر ورودی عدد 1 نبود، پیام خطا نمایش می‌دهیم
                Console.WriteLine("ورودی نامعتبر است. لطفا عدد 1 را وارد کنید.");
            }
        }

        // نمایش عدد ورودی
        Console.WriteLine($"شما عدد {number} را وارد کردید.");
    }
}
