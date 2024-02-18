namespace SmartHome;

public class Program
{
    static void Main(string[] args)
    {
        Wettersensor wettersensor = new Wettersensor();
        Wohnung wohnung = new Wohnung(wettersensor);

        wohnung.SetTemperaturvorgabe("BadWC", 25);
        wohnung.SetTemperaturvorgabe("Kueche", 24);
        wohnung.SetTemperaturvorgabe("Schlafzimmer", 21);
        wohnung.SetTemperaturvorgabe("Wohnzimmer", 22);

        for (int i = 0; i < 60; i++)
        {
            wohnung.GeneriereWetterdaten();
        }

    }
}