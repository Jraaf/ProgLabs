using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class HikingEquipment:Equipment
    {
        public HikingEquipment()
            : base("Hiking")
        {
        }
        public override string Info(bool? toShow)
        {
            string output = $"This is {Purpose} type of equipment" +
                $"\nit is used help you when you go hiking";
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
