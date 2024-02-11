namespace Uebung_Auto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Schriben Sie 'start', um das Auto zu starten:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "start")
            {
                Auto auto = new Auto();
                auto.Start();
            }
            else
            {
                Console.WriteLine("Das Auto wird nicht gestartet");
            }
        }
    }
}
