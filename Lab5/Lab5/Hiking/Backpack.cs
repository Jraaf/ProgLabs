using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Hiking
{
    internal class Backpack:HikingEquipment
    {
        public SkiingEquipment Slides { get; } 
        public Helmet Hat { get; set; }
        List<string> Things { get; set; } = new List<string>(); 
        public Backpack(SkiingEquipment slides) 
        {
            Slides=slides;
        }
        public Backpack(SkiingEquipment slides, Helmet hat) : this(slides)
        {
            Hat = hat;
        }

        public override string Info(bool? toShow)
        {
            string output = $"This id {Purpose} type of equipment" +
                $"\nit is used to store useful things while you go out";
            if (toShow.HasValue)
            {
                if (toShow.Value)
                {
                    Console.WriteLine(output);
                }
            }
            return output;
        }
    }
}
