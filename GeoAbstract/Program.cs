using System;

namespace GeoAbstract
{
    abstract class GeographicObject
    {
        public double X { get; protected set; }
        public double Y { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        protected GeographicObject(double x, double y, string name, string description)
        {
            X = x;
            Y = y;
            Name = string.IsNullOrWhiteSpace(name) ? "NoName" : name.Trim();
            Description = description ?? string.Empty;
        }

        // Абстрактний метод: кожен нащадок повертає свій опис
        public abstract string GetInfo();
    }

    class River : GeographicObject
    {
        // см/с
        public decimal FlowSpeedCmPerSec { get; private set; }
        // км
        public decimal TotalLengthKm { get; private set; }

        public River(double x, double y, string name, string description,
                     decimal flowSpeedCmPerSec, decimal totalLengthKm)
            : base(x, y, name, description)
        {
            FlowSpeedCmPerSec = flowSpeedCmPerSec;
            TotalLengthKm = totalLengthKm;
        }

        public override string GetInfo()
        {
            return $"[River] {Name} ({X}, {Y})\n" +
                   $"  Desc: {Description}\n" +
                   $"  Flow speed: {FlowSpeedCmPerSec} cm/s\n" +
                   $"  Length: {TotalLengthKm} km";
        }
    }

    class Mountain : GeographicObject
    {
        // м
        public int HighestPointMeters { get; private set; }

        public Mountain(double x, double y, string name, string description, int highestPointMeters)
            : base(x, y, name, description)
        {
            HighestPointMeters = highestPointMeters;
        }

        public override string GetInfo()
        {
            return $"[Mountain] {Name} ({X}, {Y})\n" +
                   $"  Desc: {Description}\n" +
                   $"  Highest point: {HighestPointMeters} m";
        }
    }

    internal class Program
    {
        private static void Main()
        {
            var dnipro = new River(30.5238, 50.4547, "Dnipro", "Main river of Ukraine",
                                    flowSpeedCmPerSec: 120m, totalLengthKm: 2201m);
            var hoverla = new Mountain(24.4990, 48.1600, "Hoverla", "Carpathian peak", 2061);

            Console.WriteLine(dnipro.GetInfo());
            Console.WriteLine();
            Console.WriteLine(hoverla.GetInfo());
        }
    }
}