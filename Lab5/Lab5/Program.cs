using Lab5.Hiking;
using Lab5.Skiing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Backpack b = new Backpack(new Ski(200), new Helmet());
            Hiker Johnathan = new Hiker(b);
            Johnathan.GoHiking();
            Johnathan.GoHiking();
            Console.ReadLine();
        }
    }
}
