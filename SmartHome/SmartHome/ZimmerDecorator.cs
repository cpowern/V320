using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    /// <summary>
    /// Stellt eine abstrakte Basisimplementierung für Zimmer-Dekoratoren bereit, die das IZimmer-Interface implementieren.
    /// </summary>
    public abstract class ZimmerDecorator : IZimmer
    {
        /// <summary>
        /// Das dekorierte Zimmerobjekt.
        /// </summary>
        protected IZimmer Zimmer { get; set; }

        /// <summary>
        /// Der Name des Zimmers.
        /// </summary>
        public string Name
        {
            get => this.Zimmer.Name;
            set => this.Zimmer.Name = value;
        }

        /// <summary>
        /// Die vorgegebene Temperatur für das Zimmer.
        /// </summary>
        public double TemperaturVorgabe
        {
            get => this.Zimmer.TemperaturVorgabe;
            set => this.Zimmer.TemperaturVorgabe = value;
        }

        /// <summary>
        /// Gibt an, ob sich Personen im Zimmer befinden.
        /// </summary>
        public bool PersonenImZimmer
        {
            get => this.Zimmer.PersonenImZimmer;
            set => this.Zimmer.PersonenImZimmer = value;
        }

        /// <summary>
        /// Initialisiert eine neue Instanz der ZimmerDecorator-Klasse mit dem angegebenen Zimmerobjekt.
        /// </summary>
        /// <param name="zimmer">Das zu dekorierende Zimmerobjekt.</param>
        public ZimmerDecorator(IZimmer zimmer)
        {
            this.Zimmer = zimmer ?? throw new ArgumentNullException(nameof(zimmer), "Zimmer darf nicht null sein.");
        }

        /// <summary>
        /// Verarbeitet die Wetterdaten für das dekorierte Zimmer.
        /// </summary>
        /// <param name="wetterdaten">Die aktuellen Wetterdaten.</param>
        public virtual void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            this.Zimmer.VerarbeiteWetterdaten(wetterdaten);
        }
    }
}
