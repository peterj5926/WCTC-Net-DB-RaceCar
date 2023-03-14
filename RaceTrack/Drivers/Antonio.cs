﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class Antonio : Driver
    {
        public Antonio(RaceCar car) : base(car)
        {
            Name = "Antonio";
            SkillLevel = 10;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

        public override void StopEngine()
        {
            
            Car.StopEngine();
            //Console.WriteLine($"{Name} turns the keys off and waves to the crowd");
        }
    }
}
