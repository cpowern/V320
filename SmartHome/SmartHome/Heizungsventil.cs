using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    /// <summary>
    /// Stellt ein Heizungsventil dar, das die Temperatur im Zimmer regelt, basierend auf den Wetterdaten.
    /// </summary>
    public class Heizungsventil : ZimmerDecorator
    {
        public bool IsHeizungsventilOffen { get; set; }
        private IZimmer Zimmer;

        /// <summary>
        /// Initialisiert eine neue Instanz der Heizungsventil-Klasse mit dem angegebenen Zimmerobjekt.
        /// </summary>
        /// <param name="zimmer">Das zu dekorierende Zimmerobjekt.</param>
        public Heizungsventil(IZimmer zimmer) : base(zimmer)
        {
            this.Zimmer = zimmer;
        }

        /// <summary>
        /// Verarbeitet die Wetterdaten für das Heizungsventil und passt die Heizung entsprechend an.
        /// </summary>
        /// <param name="wetterdaten">Die aktuellen Wetterdaten.</param>
        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (wetterdaten.Aussentemperatur < this.Zimmer.TemperaturVorgabe)
            {
                if (IsHeizungsventilOffen == false)
                {
                    Console.WriteLine($"{this.Name}: Heizungsventil öffnen");
                    IsHeizungsventilOffen = true;
                }
            }
            else
            {
                if (IsHeizungsventilOffen == true)
                {
                    Console.WriteLine($"{this.Name}: Heizungsventil schliessen");
                    IsHeizungsventilOffen = false;
                }
            }

            base.VerarbeiteWetterdaten(wetterdaten);
        }
    }
}
