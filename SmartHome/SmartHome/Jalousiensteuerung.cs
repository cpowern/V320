using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    /// <summary>
    /// Klasse, die die Steuerung der Jalousie implementiert.
    /// </summary>
    public class Jalousiensteuerung : ZimmerDecorator
    {
        private bool JalousienOffen { get; set; }

        /// <summary>
        /// Initialisiert eine neue Instanz der Jalousiensteuerung mit dem angegebenen Zimmer.
        /// </summary>
        /// <param name="zimmer">Das Zimmer, für das die Jalousiensteuerung implementiert wird.</param>
        public Jalousiensteuerung(IZimmer zimmer) : base(zimmer)
        {

        }

        /// <summary>
        /// Verarbeitet die Wetterdaten und steuert die Jalousie basierend auf den Wetterbedingungen und den Raumzuständen.
        /// </summary>
        /// <param name="wetterdaten">Die aktuellen Wetterdaten.</param>
        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            Console.WriteLine($"{this.Name}: Verarbeitung der Wetterdaten gestartet.\n");

            if (wetterdaten.Aussentemperatur > this.Zimmer.TemperaturVorgabe)
            {
                if (!this.JalousienOffen)
                {
                    Console.WriteLine($"{this.Name}: Jalousie wird geschlossen.\n");
                    JalousienOffen = true;
                }
            }
            else
            {
                if (this.JalousienOffen)
                {
                    Console.WriteLine($"{this.Name}: Jalousie wird geöffnet.\n");
                    JalousienOffen = false;
                }
            }

            base.VerarbeiteWetterdaten(wetterdaten);
        }
    }
}
