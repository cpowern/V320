using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    /// <summary>
    /// Stellt einen Wettersensor dar, der aktuelle Wetterdaten wie Temperatur, Windgeschwindigkeit und Regen erfasst.
    /// </summary>
    public class Wettersensor
    {
        private double AktuelleTemperatur { get; set; }

        private double AktuelleWindgeschwindigkeit { get; set; }

        private bool Regen { get; set; }

        private Random Zufaellig { get; set; }

        private const int MAX_TEMP = 35;

        private const int MIN_TEMP = 0;

        public Wettersensor()
        {
            Zufaellig = new Random();
        }

        /// <summary>
        /// Ruft die aktuellen Wetterdaten ab, einschliesslich Temperatur, Windgeschwindigkeit und Regen.
        /// </summary>
        /// <returns>Ein Wetterdatenobjekt mit den aktuellen Wetterinformationen.</returns>
        public Wetterdaten GetWetterdaten()
        {
            GetTemperatur();
            GetWindgeschwindigkeit();
            GetRegen();

            return new Wetterdaten
            {
                Aussentemperatur = AktuelleTemperatur,
                Regen = Regen,
                Windgeschwindigkeit = AktuelleWindgeschwindigkeit,
            };
        }

        /// <summary>
        /// Berechnet und aktualisiert die aktuelle Temperatur des Wettersensors.
        /// </summary>
        private void GetTemperatur()
        {
            double zielTemperatur = Zufaellig.NextDouble() * 25;
            double temperaturAenderung = (zielTemperatur - AktuelleTemperatur) * 0.05;
            AktuelleTemperatur += temperaturAenderung;

            AktuelleTemperatur = Math.Max(MIN_TEMP, Math.Min(MAX_TEMP, AktuelleTemperatur));
        }

        /// <summary>
        /// Berechnet und aktualisiert die aktuelle Windgeschwindigkeit des Wettersensors.
        /// </summary>
        /// <returns>Die aktuelle Windgeschwindigkeit in Metern pro Sekunde.</returns>
        private double GetWindgeschwindigkeit()
        {
            double zielWindgeschwindigkeit = Zufaellig.Next() * 30;
            double windgeschwindigkeitAenderung = (zielWindgeschwindigkeit - AktuelleWindgeschwindigkeit) * 0.05;
            AktuelleWindgeschwindigkeit += windgeschwindigkeitAenderung;

            return AktuelleWindgeschwindigkeit;
        }

        /// <summary>
        /// Berechnet und aktualisiert den aktuellen Regenstatus des Wettersensors.
        /// </summary>
        private void GetRegen()
        {
            Regen = Zufaellig.Next(2) == 0;
        }

    }
}
