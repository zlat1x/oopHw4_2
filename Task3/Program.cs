using System;
using System.Globalization;

namespace Task3
{
    internal class Program
    {
        static decimal ReadDecimal(string prompt)
        {
            Console.Write(prompt);
            var s = (Console.ReadLine() ?? "").Trim().Replace(',', '.');
            if (!decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out var v))
            {
                Console.WriteLine("Невірне число, взято 0.");
                return 0m;
            }
            return v;
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Введіть курс (скільки грн за 1 одиницю валюти):");
            decimal usdToUah = ReadDecimal("USD->UAH: ");
            decimal eurToUah = ReadDecimal("EUR->UAH: ");

            var conv = new Converter(usdToUah, eurToUah);

            while (true)
            {
                Console.WriteLine("\n1) UAH -> USD");
                Console.WriteLine("2) USD -> UAH");
                Console.WriteLine("3) UAH -> EUR");
                Console.WriteLine("4) EUR -> UAH");
                Console.WriteLine("0) Вихід");
                Console.Write("Вибір: ");

                var k = Console.ReadLine();
                if (k == "0" || k == null) break;

                decimal amount = ReadDecimal("Сума: ");
                decimal res;

                switch (k)
                {
                    case "1": res = conv.UahToUsd(amount); break;
                    case "2": res = conv.UsdToUah(amount); break;
                    case "3": res = conv.UahToEur(amount); break;
                    case "4": res = conv.EurToUah(amount); break;
                    default: Console.WriteLine("Невірний вибір."); continue;
                }

                Console.WriteLine($"Результат: {res:F2}");
            }
        }
    }
}