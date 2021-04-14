using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro0414
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] soronkent = File.ReadAllLines("balkezesek.csv");
            List<Balosok> balosSportolok = new List<Balosok>();

            foreach (string sor in soronkent.Skip(1))
            {
                balosSportolok.Add(new Balosok(sor));
            }
            //1 feldat
            int N = balosSportolok.Count;
            Console.WriteLine($"1.feladat: {N} versenyző");

            Console.ReadLine();
        }

        
    }
}
