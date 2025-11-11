using System;
using System.Collections.Generic;

namespace GeoInterface
{
    interface IGeographicObject
    {
        double X { get; }
        double Y { get; }
        string Name { get; }
        string Description { get; }
        string GetInfo();
    }

    class River : IGeographicObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }
        public decimal FlowSpeedCmPerSec { get; }
        public decimal TotalLengthKm { get; }

        public River(double x, double y, string name, string description,
                     decimal flowSpeedCmPerSec, decimal totalLengthKm)
        {
            X = x; Y = y;
            Name = string.IsNullOrWhiteSpace(name) ? "NoName" : name.Trim();
            Description = description ?? string.Empty;
            FlowSpeedCmPerSec = flowSpeedCmPerSec;
            TotalLengthKm = totalLengthKm;
        }

        public string GetInfo() =>
            $"[River] {Name} ({X}, {Y}) | {Description} | {FlowSpeedCmPerSec} cm/s | {TotalLengthKm} km";
    }

    class Mountain : IGeographicObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }
        public int HighestPointMeters { get; }

        public Mountain(double x, double y, string name, string description, int highestPointMeters)
        {
            X = x; Y = y;
            Name = string.IsNullOrWhiteSpace(name) ? "NoName" : name.Trim();
            Description = description ?? string.Empty;
            HighestPointMeters = highestPointMeters;
        }

        public string GetInfo() =>
            $"[Mountain] {Name} ({X}, {Y}) | {Description} | top {HighestPointMeters} m";
    }

    internal class Program
    {
        private static void Main()
        {
            var list = new List<IGeographicObject>
            {
                new River(30.5238, 50.4547, "Dnipro", "Main river of Ukraine", 120m, 2201m),
                new Mountain(24.4990, 48.1600, "Hoverla", "Carpathian peak", 2061)
            };

            foreach (var obj in list)
                Console.WriteLine(obj.GetInfo());
        }
    }
}