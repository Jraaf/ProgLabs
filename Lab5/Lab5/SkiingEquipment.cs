using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class SkiingEquipment:Equipment
    {
        public int MaxSpeed { get; set; }
        public SkiingEquipment(int maxSpeed) 
            : base("Skiing") 
        {
            MaxSpeed = maxSpeed;
        }
        public override string Info(bool? toShow)
        {
            string output = $"This id {Purpose} type of equipment" +
                $"\nit is used to ski down the mountains";
            if (toShow.HasValue)
            {
                if (toShow.Value)
                {
                    Console.WriteLine(output);
                }
            }
            return output;
        }
        public virtual void SkiDown() { }
    }
}
