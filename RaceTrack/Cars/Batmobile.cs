using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Batmobile : RaceCar
    {
        public Batmobile()
        {
            Name = "Batmobile";
            TopSpeed = 105;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine fires up!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is brought to a halt!");
            base.Brake();
        }
    }
}
