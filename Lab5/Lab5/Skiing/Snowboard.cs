﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Skiing
{
    internal class Snowboard:SkiingEquipment
    {
        public Snowboard(int maxSpeed) : base(maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }
        public override string Info(bool? toShow)
        {
            string output = $"This id {Purpose} type of equipment" +
                $"\nit is used to ski down the mountains or artifical hill" +
                $"\n this snowboard can develop max speed of {MaxSpeed}kph";
            if (toShow.HasValue)
            {
                if (toShow.Value)
                {
                    Console.WriteLine(output);
                }
            }
            return output;
        }
        public override void SkiDown()
        {
            Console.WriteLine($"WSHHH! You're goind down the mountain {MaxSpeed} kph!");
        }
    }
}
