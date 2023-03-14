using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class DodgeRam : RaceCar
    {
        public DodgeRam() 
        {
            Name = "Dodge Ram";
            TopSpeed = 95;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} powers up!"); ;
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} power slides across the finish line!");
            base.Brake();
        }
    }
}
