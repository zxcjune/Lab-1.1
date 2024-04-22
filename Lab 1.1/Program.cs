using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._1
{
    internal class Program
    {
        public class TV
        {
            public string Model;
            public string Diagonal;
            public string Display;
            public string Resolution;
            public string Platform;
            public string Tuner;
            public bool AI;

            public string TV4k()
            {
                if (Display[0] == '4' || !string.IsNullOrEmpty(Display))
                {
                    return "TV has 4k";
                }
                return "TV doesn't have 4k";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a model");
            string sModel = Console.ReadLine();
            Console.WriteLine("Enter a Diagonal");
            string sDiagonal = Console.ReadLine();
            Console.WriteLine("Enter a Display");
            string sDisplay = Console.ReadLine();
            Console.WriteLine("Enter a Resolution");
            string sResolution = Console.ReadLine();
            Console.WriteLine("Enter a Platform");
            string sPlatform = Console.ReadLine();
            Console.WriteLine("Enter a Tuner");
            string sTuner = Console.ReadLine();
            Console.WriteLine("Enter a AI(y - yes, or n - no)");
            ConsoleKeyInfo keyHasAI = Console.ReadKey();
            TV tV = new TV();
            tV.Model = sModel;
            tV.Diagonal = sDiagonal;
            tV.Display = sDisplay;
            tV.Resolution = sResolution;
            tV.Platform = sPlatform;
            tV.Tuner = sTuner;
            tV.AI = keyHasAI.Key == ConsoleKey.Y ? true : false;
            Console.WriteLine();
            Console.WriteLine($"-------------");
            Console.WriteLine($"Дані про об'єкт");
            Console.WriteLine($"-------------");
            Console.WriteLine($"Model = {tV.Model}");
            Console.WriteLine($"Diagonal = {tV.Diagonal}");
            Console.WriteLine($"Display = {tV.Display}");
            Console.WriteLine($"Resolution = {tV.Resolution}");
            Console.WriteLine($"Platform = {tV.Platform}");
            Console.WriteLine($"Tuner = {tV.Tuner}");
            Console.WriteLine($"AI = {(tV.AI ? "TV have AI" : "TV doesn't have AI")}");
            Console.WriteLine($"{tV.TV4k()}");
            Console.ReadLine();
        }
    }
}
