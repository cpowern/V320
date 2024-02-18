using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome;

public class Jalousienstuerung : ZimmerDecorator
{
    private bool HeizungsventilOffen { get; set; }

    public override void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
    {

    }
}
