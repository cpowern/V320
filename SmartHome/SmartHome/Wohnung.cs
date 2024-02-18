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
    private Wetterdaten WohnungWetterdaten = new Wetterdaten();
    
    public Wohnung(Wettersensor wettersensor)
    {
        this.wettersensor = new Wettersensor();

        this.zimmerList.Add(new Heizungsventil(new BadWC()));
        this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Wohnzimmer())));
        this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Schlafzimmer())));
        this.zimmerList.Add(new Jalousiensteuerung(new Heizungsventil(new Kueche())));
        this.zimmerList.Add(new Jalousiensteuerung(new Markisensteuerung(new Wintergarten())));

    }

    public void GeneriereWetterdaten()
    {
        WohnungWetterdaten = wettersensor.GetWetterdaten();

        Console.WriteLine();
        Console.WriteLine("-----Verarbeite Wetterdaten-----");
        Console.WriteLine();

        foreach(var zimmer in zimmerList) 
        {
            zimmer.VerarbeiteWetterdaten(WohnungWetterdaten);
        }
    }

    public void SetPersonenImZimmer(string zimmername, bool personenImZimmer)
    {
        var zimmer = zimmerList.FirstOrDefault(x => x.Name == zimmername);
        if (zimmer != null)
        {
            zimmer.PersonenImZimmer = personenImZimmer;
        }
    }

    public void SetTemperaturvorgabe(string zimmername, double temperaturvorgabe)
    {
        var zimmer = zimmerList.FirstOrDefault(x => x.Name == zimmername);
        if (zimmer != null)
        {
            zimmer.TemperaturVorgabe = temperaturvorgabe;
        }

    }
}

