namespace Uebung_Auto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie 'start' ein, um das Auto zu starten:");
            Console.WriteLine("----------------------------------------------");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "start")
            {
                Auto auto = new Auto();
                auto.Start();
            }
            else
            {
                Console.WriteLine("Das Auto wird nicht gestartet / Ungültige Eingabe.");
            }
        }
    }
}