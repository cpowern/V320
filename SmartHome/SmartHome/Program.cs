namespace SmartHome;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Project start!");

        Wohnung wohnungOne = new Wohnung();
        wohnungOne = 0;
        Schlafzimmer woSchlafzimmer = new Schlafzimmer(wohnungOne);


    }
}