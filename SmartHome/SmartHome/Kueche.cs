using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Kueche: Zimmer
    {
        public Kueche() : base("Kueche") // Aufruf des Konstruktors der Basisklasse
        {
            // Weitere Initialisierungen für die abgeleitete Klasse
        }

        private KochherdStatus kochherdStatus { get; set; }
    }
}
