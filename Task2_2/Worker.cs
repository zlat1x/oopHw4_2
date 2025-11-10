using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2_2
{
    public abstract class Worker(string name)
    {
        public string Name { get; protected set; } = string.IsNullOrWhiteSpace(name) ? "NoName" : name.Trim();
        public string? Position { get; protected set; }
        public string WorkDay { get; protected set; } = string.Empty;

        protected void Call() { WorkDay += "Call; "; }
        protected void WriteCode() { WorkDay += "WriteCode; "; }
        protected void Relax() { WorkDay += "Relax; "; }

        public abstract void FillWorkDay();

        protected void ResetDay() { WorkDay = string.Empty; }
        
        public override string ToString() => $"{Name} - {Position ?? "Unknown"} - {WorkDay}";
    }
}