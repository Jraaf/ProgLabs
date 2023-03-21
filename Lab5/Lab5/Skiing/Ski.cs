using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Skiing
{
    internal class Ski:SkiingEquipment
    {
        public Ski(int maxSpeed):base(maxSpeed)
        {
            MaxSpeed = maxSpeed;
        }
        public override string Info(bool? toShow)
        {
            string output = $"This id {Purpose} type of equipment" +
                $"\nit is used to ski down the artificial hill" +
                $"\n theese skies can develop max speed of {MaxSpeed}kph";
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
            Console.WriteLine($"WSHHH! You're goind down the hill {MaxSpeed} kph!");
        }
    }
}
