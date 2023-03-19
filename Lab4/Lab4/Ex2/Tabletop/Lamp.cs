using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2.Tabletop
{
    internal class Lamp:TableTop
    {
        public string BrandName { get; set; }
        private bool OnOff = false;
        public Lamp(string brandName,int EnergyConsumption) :base(name:"Lamp")
        {
            BrandName = brandName;
            EnergyConsumption = this.EnergyConsumption>=50?this.EnergyConsumption:50;
        }
        public override void ShowCharactreristics()
        {
            Console.WriteLine($"It is {BrandName} lamp. " +
                $"\nIt can brighten your dark phisics lab only using {EnergyConsumption} W");
        }
        public void SwitchLights()
        {
            OnOff = !OnOff;
            if (OnOff)
            {
                if (EnergyConsumption > 100)
                {
                    Console.WriteLine("☺OMG that is too bright to do phisics☺");
                }
                else
                {
                    Console.WriteLine("Ok i'll do phisics... tomorow");
                }
            }
            else
            {
                Console.WriteLine("It's dark again...");
            }
        }

    }
}
