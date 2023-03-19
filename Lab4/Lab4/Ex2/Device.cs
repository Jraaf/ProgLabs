using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2
{
    internal class Device
    {
        public int EnergyConsumption { get; set; }
        public string Purpose { get;}
        public string Name { get; set; }
        public string BrandName { get; set; }

        public Device(int energyConsuption,string purpose, string name, string brandName)
        {
            EnergyConsumption = energyConsuption;
            EnergyConsumption = 0;
            Purpose = purpose;
            Name = name;
            BrandName = brandName;
        }
        public Device(string purpose)
        {
            Purpose = purpose;
        }
        public Device(string purpose,int energyConsuption)
        {
            Purpose=purpose; 
            EnergyConsumption=energyConsuption;
        }
        public virtual void ShowCharactreristics() { }
    }
}
