using Lab5.Hiking;
using Lab5.Skiing;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Hiker
    {
        public bool IsAlive { get; } = true;
        private Backpack Bag { get; }
        public Hiker(Backpack bag)
        {
            Bag = bag;
        }
        public Hiker(SkiingEquipment skies,Helmet helmet)
        {
            Bag=new Backpack(skies, helmet);
        }
        public void GoHiking()
        {
            Console.WriteLine($"So you chose {Bag.Slides.Info(false)}\n");
            Thread.Sleep(1000);
            Console.WriteLine("But you fell of you slides...");
            Thread.Sleep(2000);
            Console.WriteLine("ouch...");
            Thread.Sleep(1500);
            if (HavingHelmet())
            {
                Console.WriteLine($"Luckily you had helmet: {Bag.Hat.Info(false)}");
                Console.WriteLine("You are alive. But helmet is completly broken");
                Bag.Hat = null;
            }
            else
            {
                Console.WriteLine("You died.");
            }
            Console.WriteLine();
        }
        public void PutHelmet()
        {
            Bag.Hat = new Helmet();
        }
        private bool HavingHelmet()
        {
            if (Bag.Hat != null)
            {
                return true;
            }
            return false;
        }
       
    }
}
