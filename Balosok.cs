using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulzaro0414
{
    class Balosok
    {
        public string nev { get; set; }
        public string elso { get; set; }
        public string utolso { get; set; }
        public double suly { get; set; }
        public double magassag { get; set; }

        public Balosok(string soronkent)
        {
            string[] sor = soronkent.Split(';');
            nev = sor[0];
            elso = sor[1];
            utolso = sor[2];
            suly = int.Parse(sor[3]);
            magassag = int.Parse(sor[4]);
        }
    }


    
}
