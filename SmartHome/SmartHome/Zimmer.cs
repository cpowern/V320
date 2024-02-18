using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Zimmer : IZimmer
    {
        public string Name { get; set; }
        public bool PersonenImZimmer { get; set; }
        public double TemperaturVorgabe { get; set; }

        public Zimmer(string name)
        {
            this.Name = name;
        }

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine($"Wetterdaten für {this.Name} wurden verarbeitet: Temperaturvorgabe: {this.TemperaturVorgabe}°C, Personen im Zimmer: {(this.PersonenImZimmer ? "anwesend" : "abwesend")}.");
            Console.WriteLine();
        }
    }
}
