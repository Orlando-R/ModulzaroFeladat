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

            //2 feladat
            //nem müdökik, ha a kezdőévet stringként kezelem; int, double nem lehet, akkor DateTime? -vagy Dictionar
            
            List<string> nyolcvanasok = new List<string>();
            foreach (var Balosok in balosSportolok)
            {
                if (Balosok.elso == "1980" // 1980-00-00)
                {
                    nyolcvanasok.Add($"{Balosok.nev}");
                }
            }
            Console.WriteLine($"2 Feladat: {nyolcvanasok}");

            Console.ReadLine();

            //3 feladat
            //4 feladat Date-Time
            //5 feladat Date-Time
            //6 feladat

        }
    }

        
}

