using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome;

public abstract class ZimmerDecorator : IZimmer
{
    public string Name { get; set; }
    public bool PersonenImZimmer { get; set; }
    public double TemperaturVorgabe { get; set; }

    public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
    {

    }

}
