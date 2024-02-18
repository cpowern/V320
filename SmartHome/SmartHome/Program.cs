namespace SmartHome;

public class Program
{
    static void Main(string[] args)
    {
        Wettersensor wettersensor = new Wettersensor();
        Wohnung wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("BadWC", 25);
        wohnung.SetPersonenImZimmer("BadWC", true);
        wohnung.SetTemperaturvorgabe("Kueche", 24);
        wohnung.SetPersonenImZimmer("Kueche", true);
        wohnung.SetTemperaturvorgabe("Schlafzimmer", 21);
        wohnung.SetPersonenImZimmer("Schlafzimmer", false);
        wohnung.SetTemperaturvorgabe("Wohnzimmer", 22);
        wohnung.SetPersonenImZimmer("Wohnzimmer", false);


        for (int i = 0; i < 60; i++)
        {
            wohnung.GeneriereWetterdaten();
        }

    }
}