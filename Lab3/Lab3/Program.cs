using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using System.CodeDom;

namespace Lab3
{
    internal class Program
    {
        static string Path = @"C:\\Users\\nasib\\Desktop\\Projects\\ProgLabs\\Lab3\\Lab3\\data.json";

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;


            Counter count = new Counter { Value = 9,LowerBorder=7,UpperBorder=10 };

            Console.WriteLine("");
            Console.WriteLine(count);



            #region [Testing of a class]
            Console.WriteLine("\t\tTesting of a class");
            Console.WriteLine("\n\t5x c++");
            var c = count.Clone();
            Testing(c, (o) =>
            {
                for (int i = 0; i < 5; i++) 
                    c++;
            });
            Console.WriteLine("\n\t5x c--");
            Testing(c, (o) =>
            {
                for (int i = 0; i < 5; i++)
                    c--;
            });
            Console.WriteLine("\n\t*=5");
            Testing(c, (o) => o *= 5);
            Console.WriteLine("\n\t/=5");
            Testing(c, (o) => o /= 5);
            Console.WriteLine("\n\t+=5");
            Testing(c, (o) => o += 5);
            Console.WriteLine("\n\t-=5");
            Testing(c, (o) => o -= 5);
            #endregion

            #region [Serialization]
            SerializeObj(count, Path);

            var counter = DeserializeCounter(Path);
            #endregion

            Console.WriteLine("\n\t\tBefore Serialization\n"+count);
            Console.WriteLine("\n\t\tAfter Deserialization\n"+counter);
            Console.ReadLine();
        }
        static void SerializeObj(object obj,string path)
        {
            var cJson = JsonConvert.SerializeObject(obj,Formatting.Indented);
            File.WriteAllText(path, cJson);
        }
        static Counter DeserializeCounter(string path)
        {
            var objStr = File.ReadAllText(Path);

            return JsonConvert.DeserializeObject<Counter>(objStr);
        }
        static void Testing(Counter counter,Action<Counter> f)
        {
            Counter c = counter.Clone();
            Console.WriteLine();
            try
            {
                f(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
