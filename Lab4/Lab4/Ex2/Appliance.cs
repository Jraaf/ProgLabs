using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2
{
    internal class Appliance:Device
    {
        public Appliance(string name)
            :base(purpose:"Kitchen appliance")
        {
            Name = name;
            BrandName=this.BrandName;
        }

    }
}
