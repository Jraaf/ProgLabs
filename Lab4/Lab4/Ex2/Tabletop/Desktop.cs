using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Ex2.Tabletop
{
    internal class Desktop:TableTop
    {
        private string CPU { get; set; }
        private string GPU { get; set; }
        private int RAM { get; set; }

        private List<string> InstalledApps=new List<string>();
        private List<string> InstalledGames=new List<string>();
        public Desktop(string brandName, int EnergyConsumption,string CPU,string GPU,int RAM) 
            : base(name: "Desktop")
        {
            BrandName = brandName;
            this.EnergyConsumption =EnergyConsumption >= 300 ? EnergyConsumption : 300;
            this.CPU = CPU;
            this.GPU = GPU;
            this.RAM = RAM;
        }
        public void DownloadApp(string AppName)
        {
            InstalledApps.Add(AppName);
        }
        public void DownloadGame(string NameOfGame)
        {
            InstalledGames.Add(NameOfGame);
        }
        public void DeleteApp(string AppName)
        {
            InstalledApps.Remove(AppName);
        }
        public void DeleteGame(string NameOfGame)
        {
            InstalledGames.Remove(NameOfGame);
        }
        private string ShowInstalledApps()
        {
            string res = "";
            foreach (var item in InstalledApps)
            {
                res += "\n\t"+item;
            }
            return res;
        }
        private string ShowInstalledGames()
        {
            string res = "";
            foreach (var item in InstalledGames)
            {
                res += "\n\t" + item;
            }
            return res;
        }
        public override void ShowCharactreristics()
        {
            Console.WriteLine($"My desktop is very cool:" +
                $"\nit consumes {EnergyConsumption} W" +
                $"\n\tCPU: {CPU}" +
                $"\n\tGPU: {GPU}" +
                $"\n\tRAM: {RAM}" +
                $"\nI am advanced PC user, I use {ShowInstalledApps()}" +
                $"\nAlso i play "+(InstalledGames.Count > 0 ? ShowInstalledGames() : "dota2"));
        }
    }
}
