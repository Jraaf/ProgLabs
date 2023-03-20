using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Day
    {
        private Hour hour=new Hour();
        private Minute minute=new Minute();

        public Day() { }

        public string GetCurrentTime()
            => $"It's {hour.Hours}:{minute.Minutes}";
        public string GetPartOfDay()
            => hour.Hours <= 10 ? "Morning" : hour.Hours <= 18 ? "Noon" : "Evening";
        public override string ToString()
        {
            return GetCurrentTime()+"\nit is"+GetPartOfDay();
        }
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
            }else
            {
                Day d = (Day)obj;
                return d.hour.Hours==hour.Hours && d.minute.Minutes==minute.Minutes;
            }
            
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            Console.WriteLine("day.GetHashCode() called");
return hour.GetHashCode()*minute.GetHashCode();
        }

    }
}
