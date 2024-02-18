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
        zimmerList.Add(new Jalousienstuerung(new Heizungsventil(new BadWC())));
        zimmerList.Add(new Jalousienstuerung(new Heizungsventil()));
        zimmerList.Add(new Jalousienstuerung(new Heizungsventil()));
        zimmerList.Add(new Jalousienstuerung(new Markisensteuerung()));
    }
    public void GeneriereWetterdaten()
    {

    }

    public void SetPersonenImZimmer(string zimmername, bool personenImZimmer, string temperaturvorgabe)
    {
        var zimmer = zimmerList.FirstOrDefault(x => x.Name == zimmername);
        if (zimmer != null)
        {
            zimmer.PersonenImZimmer = personenImZimmer;
        }
    }

    public void SetTemperaturvorgabe(double temperatur, string zimmername, double temperaturvorgabe)
    {
        var zimmer = zimmerList.FirstOrDefault(x => x.Name == zimmername);
        if (zimmer != null)
        {
            zimmer.TemperaturVorgabe = temperaturvorgabe;
        }

    }
}

