using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome;

public class Wetterdaten
{
    /// <summary>
    /// Temperatur im Wintergarten
    /// </summary>
    public double Aussentemperatur { get; set; }

    public bool Regen { get; set; }

    public double Windgeschwindigkeit { get; set; }
}
