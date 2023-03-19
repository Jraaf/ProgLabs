using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Minute
    {
        public int Minutes { get=> DateTime.Now.Minute;}
        // override object.Equals
        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                Minute m = (Minute)obj;
                return m.Minutes == Minutes;
            }

            // TODO: write your implementation of Equals() here

        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            Console.WriteLine("minute.GetHashCode() called");
            return ((Minutes ^ 2) - 5) ^ 2;
        }
    }
}
