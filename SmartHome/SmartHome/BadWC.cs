using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome;

public class BadWC: Zimmer
{
    public double Feuchtigkeit { get; set; }

    public BadWC() : base("badWC")
    {

    }
}
