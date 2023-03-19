using Lab4.Ex2.Tabletop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ex1");
            Ex1();
            Console.WriteLine("ex2");
            Ex2();
            Console.ReadLine();
        }

        static void Ex1()
        {
            Day d = new Day();
            Console.WriteLine(d.GetCurrentTime());
            Console.WriteLine(d.GetPartOfDay());
            Console.WriteLine(d);
            Console.WriteLine($"d.gethashcode(): {d.GetHashCode()}");
        }
        static void Ex2()
        {
            Desktop MyPC = new Desktop("Acer", 300,"intel core i5","geforse gtx1650",8);
            MyPC.DownloadApp("VScode");
            MyPC.DownloadApp("Chrome");
            MyPC.ShowCharactreristics();
        }

    }
}
