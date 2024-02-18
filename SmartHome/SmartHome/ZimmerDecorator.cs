using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome;

public abstract class ZimmerDecorator : IZimmer
{

    protected IZimmer Zimmer { get; set; }
    public string Name { get; set; }
    public bool PersonenImZimmer { get; set; }
    public double TemperaturVorgabe { get; set; }

    public abstract void VerarbeiteWetterdaten(Wetterdaten wetterdaten);


}
