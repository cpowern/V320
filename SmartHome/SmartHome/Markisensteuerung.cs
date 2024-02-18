using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    /// <summary>
    /// Klasse, die die Steuerung der Markise implementiert.
    /// </summary>
    public class Markisensteuerung : ZimmerDecorator
    {
        private bool MarkiseOffen { get; set; }

        /// <summary>
        /// Initialisiert eine neue Instanz der Markisensteuerung mit dem angegebenen Zimmer.
        /// </summary>
        /// <param name="zimmer">Das Zimmer, für das die Markisensteuerung implementiert wird.</param>
        public Markisensteuerung(IZimmer zimmer) : base(zimmer)
        {
        }

        /// <summary>
        /// Verarbeitet die Wetterdaten und steuert die Markise basierend auf den Wetterbedingungen und den Raumzuständen.
        /// </summary>
        /// <param name="wetterdaten">Die aktuellen Wetterdaten.</param>
        public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (wetterdaten.Aussentemperatur > this.Zimmer.TemperaturVorgabe)
            {
                if (!MarkiseOffen && wetterdaten.Windgeschwindigkeit <= 30)
                {
                    Console.WriteLine($"{this.Name}: Markise wird geöffnet.\n");
                    MarkiseOffen = true;
                }
            }
            else
            {
                if (MarkiseOffen)
                {
                    Console.WriteLine($"{this.Name}: Markise wird geschlossen.\n");
                    MarkiseOffen = false;
                }
            }

            base.VerarbeiteWetterdaten(wetterdaten); // Aufruf der Methode in der Basisklasse
        }
    }
}
