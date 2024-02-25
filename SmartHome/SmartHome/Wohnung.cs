using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SmartHome
{
    /// <summary>
    /// Stellt eine Wohnung dar, die aus verschiedenen Zimmern besteht und einen Wettersensor verwendet, um Wetterdaten zu generieren und zu verarbeiten.
    /// </summary>
    public class Wohnung
    {
        private List<IZimmer> zimmerList = new List<IZimmer>();
        private Wettersensor wettersensor;
        private Wetterdaten WohnungWetterdaten = new Wetterdaten();

        /// <summary>
        /// Initialisiert eine neue Instanz der Wohnung-Klasse mit dem angegebenen Wettersensor.
        /// </summary>
        /// <param name="wettersensor">Der Wettersensor, der für die Wetterdatenerfassung verwendet wird.</param>
        public Wohnung(IWettersensor wettersensor)
        {
            this.wettersensor = new Wettersensor();

            this.zimmerList.Add(new Heizungsventil(new BadWC()));
            this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Wohnzimmer())));
            this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Schlafzimmer())));
            this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Kueche())));
            this.zimmerList.Add(new Jalousiensteuerung(new Markisensteuerung(new Wintergarten())));
        }

        /// <summary>
        /// Generiert Wetterdaten für die Wohnung und verarbeitet sie für jedes Zimmer.
        /// </summary>
        public void GeneriereWetterdaten()
        {
            WohnungWetterdaten = wettersensor.GetWetterdaten();

            Console.WriteLine();
            Console.WriteLine("-----Verarbeite Wetterdaten-----");
            Console.WriteLine($"Aussentemperatur: {WohnungWetterdaten.Aussentemperatur}");
            Console.WriteLine($"Regen: {WohnungWetterdaten.Regen}");
            Console.WriteLine($"Windgeschwindigkeit: {WohnungWetterdaten.Windgeschwindigkeit}");

            Console.WriteLine();


            foreach (var zimmer in zimmerList)
            {
                zimmer.VerarbeiteWetterdaten(WohnungWetterdaten);
            }
        }

        /// <summary>
        /// Setzt die Anwesenheit von Personen in einem bestimmten Zimmer.
        /// </summary>
        /// <param name="zimmername">Der Name des Zimmers, in dem sich die Personen befinden.</param>
        /// <param name="personenImZimmer">True, wenn sich Personen im Zimmer befinden, sonst False.</param>
        public void SetPersonenImZimmer(string zimmername, bool personenImZimmer)
        {
            var zimmer = zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if (zimmer != null)
            {
                zimmer.PersonenImZimmer = personenImZimmer;
            }
        }

        /// <summary>
        /// Setzt die Temperaturvorgabe für ein bestimmtes Zimmer.
        /// </summary>
        /// <param name="zimmername">Der Name des Zimmers, für das die Temperaturvorgabe festgelegt wird.</param>
        /// <param name="temperaturvorgabe">Die gewünschte Temperaturvorgabe für das Zimmer.</param>
        public void SetTemperaturvorgabe(string zimmername, double temperaturvorgabe)
        {
            var zimmer = zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if (zimmer != null)
            {
                zimmer.TemperaturVorgabe = temperaturvorgabe;
            }
        }

        public IZimmer GetZimmer(string zimmername)
        {
            return this.zimmerList.FirstOrDefault(x => x.Name == zimmername);
        }

        public T GetZimmer<T>(string zimmername)
        {
            var zimmer = this.GetZimmer(zimmername);
            var fi = typeof(ZimmerDecorator).GetField("zimmer", BindingFlags.NonPublic | BindingFlags.Instance);
            while (true)
            { 
                if (zimmer is T) 
                { 
                    return (T)zimmer; 
                } 
                zimmer = (IZimmer)fi.GetValue(zimmer); 
            }
        }
        
    }
}
