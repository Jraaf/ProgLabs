using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2
{
    internal class TableTop:Device
    {
        public TableTop(string name)
            : base(purpose: "Tabletop")
        {
            Name = name;
        }

    }
}
