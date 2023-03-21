using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal abstract class Equipment
    {
        public string Purpose { get; set; }
        public Equipment(string purpose)
        {
            Purpose=purpose;
        }
        public virtual string Info(bool? toShow)
        {
            string output = $"This id {Purpose} type of equipment";
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
