using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Hiking
{
    internal class Helmet:HikingEquipment
    {
        public override string Info(bool? toShow)
        {
            string output = $"This id {Purpose} type of equipment" +
    $"\nit is used to protect your head from rocks";
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
