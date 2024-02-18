using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public class Schlafzimmer: Zimmer
    {
        public DateTime WeckZeit { get; set; }

        public Schlafzimmer() : base("schlafzimmer")
        {

        }

    }
}
