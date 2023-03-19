using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2.Appliances
{
    internal class Microwave:Appliance
    {
        public Microwave(string BrandName,int EnergyConsuption):base(name:"Microwave")
        {
            BrandName=this.BrandName;
            EnergyConsumption = this.EnergyConsumption>=700?this.EnergyConsumption:700;
        }
        public override void ShowCharactreristics()
        {
            Console.WriteLine($"WrRrrwRRWrrwmmmmm it's {BrandName} microwave!" +
                $"\n It consumes {EnergyConsumption} W and used to hotten food");
        }
        public void HottenFood(string foodName)
        {
            Console.WriteLine($"Ouch! {foodName} is now superhot!");
        }
    }
}
