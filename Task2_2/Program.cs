using System;

namespace Task2_2
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введи назву команди: ");
            string tname = Console.ReadLine() ?? "Team";
            var team = new Team(tname);

            Console.Write("Кількість співробітників: ");
            int n = int.TryParse(Console.ReadLine(), out var k) ? Math.Max(0, k) : 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nПрацівник #{i + 1}: 1 - Developer, 2 - Manager");
                Console.Write("Тип: ");
                var type = Console.ReadLine();
                Console.Write("Ім'я: ");
                var name = Console.ReadLine() ?? "NoName";

                Worker w = (type == "1") ? new Developer(name) : new Manager(name);
                w.FillWorkDay();
                team.Add(w);
            }

            Console.WriteLine("\n--- Коротка інформація ---");
            Console.WriteLine(team.Info());

            Console.WriteLine("--- Детальна інформація ---");
            Console.WriteLine(team.DetailedInfo());
        }
    }
}
