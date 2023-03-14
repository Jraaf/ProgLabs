using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Lab1
{
    internal class Program
    {
        static JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        static void Main(string[] args)
        {
            Ex3();
        }

        static void Ex1()
        {
            var path = @"C:\\Users\\nasib\\Desktop\\Projects\\ProgLabs\\Lab1\\Lab1\\Text.txt";
            var textfile = new StreamReader(path);
            string text = textfile.ReadLine();
            while (!textfile.EndOfStream)
            {
                text += (textfile.ReadLine() + " ");
            }
            var wrds = text.ToLower().Split(' ').ToList();
            var distinctwords = wrds.Distinct().ToList();

            var path1 = @"C:\\Users\\nasib\\Desktop\\Projects\\ProgLabs\\Lab1\\Lab1\\Output.txt";

            using (var writer = new StreamWriter(path1))
            {
                foreach (var item in distinctwords)
                {
                    writer.Write(item + " ");
                }
            }
        }
        static async Task Ex2()
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                ["item1"] = 500,
                ["item2"] = 850
            };
            Dictionary<string, int> d2 = new Dictionary<string, int>()
            {
                ["item1"] = 200,
                ["item2"] = 150
            };
            Dictionary<string, int> OutPut = new Dictionary<string, int>();
            foreach (var item in d1)
            {
                if (d2.ContainsKey(item.Key))
                {
                    OutPut.Add(item.Key, item.Value + d2[item.Key]);
                }
            }
            var path = @"out.json";

            JsonConvert.SerializeObject(OutPut, Formatting.Indented);
            File.WriteAllText(path, JsonConvert.SerializeObject(OutPut, Formatting.Indented));

        }
        static void Ex3()
        {
            Dictionary<string, double> ProductMenu = new Dictionary<string, double>()
            {
                ["Milk"] = 34.99,
                ["Gouda cheese"] = 499.99,
                ["Butter 82,5%"] = 60.00,
                ["Milled coffee 250g"] = 230.50
            };
            var over100 = from product in ProductMenu where product.Value >= 100 select product;
            var under100= from product in ProductMenu where product.Value < 100 select product;

            string Products= JsonConvert.SerializeObject(under100, Formatting.Indented)+ 
                JsonConvert.SerializeObject(over100, Formatting.Indented);
            string path = @"C:\Users\nasib\Desktop\Projects\ProgLabs\ProgLabs\Lab1\Lab1\ex3.json";
            File.WriteAllText(path,Products);
        }
    }
}
