using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung_Auto
{
    public class Auto
    {
        private Motor motor;

        public Auto()
        {
            motor = new Motor();
        }

        public void Start()
        {
            Console.WriteLine("Auto anlassen");
            motor.Starten();
        }
    }
}
