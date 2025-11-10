using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Manager : Worker
    {
        private readonly Random Rng = new Random();

        public Manager(string name) : base(name) { Position = "Менеджер"; }

        // Call x[1..10] - Relax - Call x[1..5]
        public override void FillWorkDay()
        {
            ResetDay();

            int c1 = Rng.Next(1, 11);
            for (int i = 0; i < c1; i++) Call();

            Relax();

            int c2 = Rng.Next(1, 6);
            for (int i = 0; i < c2; i++) Call();
        }
    }
}