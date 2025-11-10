using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2_2
{
    public class Developer : Worker
    {
        public Developer(string name) : base(name) { Position = "Розробник"; }

        // WriteCode - Call - Relax - WriteCode
        public override void FillWorkDay()
        {
            ResetDay();
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }
}