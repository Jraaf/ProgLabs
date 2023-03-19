using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2.Appliances
{
    internal class Kettle:Appliance
    {
        public Kettle(string BrandName, int EnergyConsuption) : base(name: "Kettle")
        {
            BrandName = this.BrandName;
            EnergyConsumption = this.EnergyConsumption >= 500 ? this.EnergyConsumption : 500;
        }
        public override void ShowCharactreristics()
        {
            Console.WriteLine($"*BoilBoilBoil* it's {BrandName} kettle!" +
                $"\n It consumes {EnergyConsumption} W and used to boil water for your tea");
        }
        public void BoilWater()
        {
            Console.WriteLine("WOW! Water got hot (really hot (it evaperates)).");
        }
    }
}
