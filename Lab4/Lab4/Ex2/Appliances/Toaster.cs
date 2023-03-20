using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2.Appliances
{
    internal class Toaster:Appliance
    {
        public Toaster(string BrandName, int EnergyConsuption) : base(name: "Microwave")
        {
            BrandName = this.BrandName;
            EnergyConsumption = this.EnergyConsumption >= 700 ? this.EnergyConsumption : 700;
        }
        public override void ShowCharactreristics()
        {
            Console.WriteLine($"Tink! It's {BrandName} toaster!" +
                $"\n It consumes {EnergyConsumption} W and used to make ");
        }
        public void HottenFood(string foodName)
        {
            Console.WriteLine($"Ouch! {foodName} is now superhot!");
        }
    }
}
