 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Tests
{
    public class WettersensorMock : IWettersensor
    {
        Wetterdaten MockWetterdaten = new Wetterdaten();

        private Wetterdaten Wetterdaten { get; set; }

        public WettersensorMock(double aussentemperatur, bool regen, double wind)
        {
            this.Wetterdaten = new Wetterdaten
            {
                Aussentemperatur = aussentemperatur,
                Regen = regen,
                Windgeschwindigkeit = wind
            };
            
            
        }

        public Wetterdaten GetWetterdaten()
        {
            return this.Wetterdaten;
        }



    }
}
