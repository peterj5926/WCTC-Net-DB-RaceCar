using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class PhillipJ : Driver
    {
        public PhillipJ(RaceCar car) : base(car)
        {
            Name = "Phillip J";
            SkillLevel = 4;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

        public override void StopEngine()
        {
            Console.WriteLine($"{Name} does donuts in the infield till the motor runs out of gas!");
        }
    }
}
