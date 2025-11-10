using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task2_2
{
    public abstract class Worker
    {
        public string Name { get; protected set; }
        public string Position { get; protected set; }
        public string WorkDay { get; protected set; } = string.Empty;

        protected Worker(string name)
        {
            Name = string.IsNullOrWhiteSpace(name) ? "NoName" : name.Trim();
        }

        protected void Call() { WorkDay += "Call; "; }
        protected void WriteCode() { WorkDay += "WriteCode; "; }
        protected void Relax() { WorkDay += "Relax; "; }

        public abstract void FillWorkDay();

        protected void ResetDay() { WorkDay = string.Empty; }
        
        public override string ToString() => $"{Name} - {Position} - {WorkDay}";
    }
}