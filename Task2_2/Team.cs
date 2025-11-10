using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Task2_2
{
    public class Team
    {
        public string Name { get; }
        private readonly List<Worker> members = new List<Worker>();

        public Team(string name) { Name = string.IsNullOrWhiteSpace(name) ? "Team" : name.Trim(); }

        public void Add(Worker w) { if (w != null) members.Add(w); }

        // Назва + ПІБ
        public string Info()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Team: {Name}");
            sb.AppendLine("Members:");
            foreach (var m in members) sb.AppendLine($"- {m.Name}");
            return sb.ToString();
        }

        // <Name> - <Position> - <WorkDay>
        public string DetailedInfo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Team: {Name}");
            sb.AppendLine("Details:");
            foreach (var m in members) sb.AppendLine(m.ToString());
            return sb.ToString();
        }
    }
}