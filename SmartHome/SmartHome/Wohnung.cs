using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome;

public class Wohnung
{
    private List<IZimmer> zimmerList = new List<IZimmer>();
    private Wettersensor wettersensor;
    public Wohnung()
    {
        wettersensor = new Wettersensor();

        zimmerList.Add(new Heizungsventil(new BadWC()));
    }
    public void GeneriereWetterdaten()
    {

    }

    public void SetPersonenImZimmer(bool personenImZimmer)
    {

    }

    public void SetTemperaturvorgabe(double temperatur)
    {

    }
}
