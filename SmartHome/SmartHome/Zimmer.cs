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


        public void VerarbeiteWetterdaten()
        {
            // Wettterdaten wetterdaten
        }
    }
}
