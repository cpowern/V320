using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Wohnzimmer : Zimmer
    {
        RgbColor rgbColor { get; set; }

        public Wohnzimmer() : base("Wohnzimmer")
        {

        }
    }
}
