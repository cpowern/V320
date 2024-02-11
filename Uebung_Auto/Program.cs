namespace Uebung_Auto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schriben Sie 'start', um das auto zu starten:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "start")
            {
                Auto auto = new Auto();
                auto.Start();
            }
            else
            {
                Console.WriteLine("Falls Sie 'start' nicht eingeben, wird das Auto nicht gestartet");
            }
        }
    }
}
